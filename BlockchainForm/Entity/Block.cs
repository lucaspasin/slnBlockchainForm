using System;
using System.Collections.Generic;
using System.Text;

namespace BlockchainForm.Entity
{
    public class Block
    {
        public long Index { get; set; }
        public DateTime TimeStamp { get; set; }
        public string Hash { get; set; }
        public string PrevHash { get; set; }
        public long Nounce { get; set; }
        public List<Contract> ContractList { get; set; }
    }
}
