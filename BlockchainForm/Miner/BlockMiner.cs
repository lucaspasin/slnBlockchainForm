using BlockchainForm.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace BlockchainForm.Miner
{
    public class BlockMiner
    {
        private readonly ContractPool _contractPool;

        public BlockMiner(ContractPool contractPool)
        {
            Blockchain = new List<Block>();
            _contractPool = contractPool;
        }

        public List<Block> Blockchain { get; private set; }

        public void Generate()
        {
            this.GenerateBlock();
        }

        private void GenerateBlock()
        {
            var lastBlock = Blockchain.LastOrDefault();
            var contractList = _contractPool.TakeAll();

            var block = new Block()
            {
                TimeStamp = DateTime.Now,
                Nounce = 0,
                ContractList = contractList,
                Index = (lastBlock?.Index + 1 ?? 0),
                PrevHash = lastBlock?.Hash ?? string.Empty
            };

            MineBlock(block);
            Blockchain.Add(block);
        }

        private void MineBlock(Block block)
        {
            var merkleRootHash = FindMerkleRootHash(block.ContractList);
            long nounce = -1;
            var hash = string.Empty;
            do
            {
                nounce++;
                var rowData = block.Index + block.PrevHash + block.TimeStamp.ToString() + nounce + merkleRootHash;
                hash = CalculateHash(CalculateHash(rowData));
            }
            while (!hash.StartsWith("0000"));
            block.Hash = hash;
            block.Nounce = nounce;
        }

        //Merkle
        private string FindMerkleRootHash(IList<Contract> contractList)
        {
            var contractStrList = contractList.Select(contract => CalculateHash(contract.From + contract.To + contract.Amount)).ToList();
            return BuildMerkleRootHash(contractStrList);
        }

        private string BuildMerkleRootHash(IList<string> merkelLeaves)
        {
            if (merkelLeaves == null || !merkelLeaves.Any())
                return string.Empty;

            if (merkelLeaves.Count() == 1)
                return merkelLeaves.First();

            if (merkelLeaves.Count() % 2 > 0)
                merkelLeaves.Add(merkelLeaves.Last());

            var merkleBranches = new List<string>();

            for (int i = 0; i < merkelLeaves.Count(); i += 2)
            {
                var leafPair = string.Concat(merkelLeaves[i], merkelLeaves[i + 1]);
                merkleBranches.Add(CalculateHash(leafPair));
            }
            return BuildMerkleRootHash(merkleBranches);
        }

        //Criptografia
        private static string CalculateHash(string data)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(data));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
