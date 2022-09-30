using BlockchainForm.Entity;
using BlockchainForm.Miner;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlockchainForm
{
    public partial class frmBlockchain : Form
    {
        private readonly ContractPool _contractPool = new ContractPool();
        private readonly BlockMiner _blockMiner;

        public frmBlockchain()
        {
            InitializeComponent();
            _blockMiner = new BlockMiner(_contractPool);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Int32.TryParse(this.txtAmmount.Text, out int ammount);
            Contract contract = new Contract(this.txtFrom.Text, this.txtTo.Text, ammount, this.txtItem.Text);

            _contractPool.Add(contract);

            this.txtFrom.Text = string.Empty;
            this.txtTo.Text = string.Empty;
            this.txtAmmount.Text = string.Empty;
            this.txtItem.Text = string.Empty;

            this.txtContractList.Text = JsonSerializer.Serialize(_contractPool.ListContracts());
        }

        private void btnGenerateNewBlock_Click(object sender, EventArgs e)
        {
            _blockMiner.Generate();
            this.txtBlockchain.Text = JsonSerializer.Serialize(_blockMiner.Blockchain);
            this.txtContractList.Text = string.Empty;
        }
    }
}
