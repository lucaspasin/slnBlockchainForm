using System;
using System.Collections.Generic;
using System.Text;

namespace BlockchainForm.Entity
{
    public class Contract
    {
        public Contract() { }

        public Contract(string from, string to, int amount, string item)
        {
            From = from;
            To = to;
            Amount = amount;
            Item = item;
        }

        public string From { get; set; }
        public string To { get; set; }
        public int Amount { get; set; }
        public string Item { get; set; }
    }
}
