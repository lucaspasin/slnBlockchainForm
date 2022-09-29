using BlockchainForm.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlockchainForm.Miner
{
    public class ContractPool
    {
        private List<Contract> ContractList;

        public ContractPool()
        {
            ContractList = new List<Contract>();
        }

        public void Add(Contract contract)
        {
            ContractList.Add(contract);
        }

        public List<Contract> TakeAll()
        {
            var all = ContractList.ToList();
            ContractList.Clear();
            return all;
        }

        public List<Contract> ListContracts()
        {
            var all = ContractList.ToList();
            return all;
        }
    }
}
