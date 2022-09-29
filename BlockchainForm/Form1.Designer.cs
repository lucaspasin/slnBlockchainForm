
namespace BlockchainForm
{
    partial class frmBlockchain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.txtAmmount = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblAmmount = new System.Windows.Forms.Label();
            this.txtContractList = new System.Windows.Forms.TextBox();
            this.grbContract = new System.Windows.Forms.GroupBox();
            this.btnGenerateNewBlock = new System.Windows.Forms.Button();
            this.lblContractList = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.grbBlockchain = new System.Windows.Forms.GroupBox();
            this.txtBlockchain = new System.Windows.Forms.TextBox();
            this.grbContract.SuspendLayout();
            this.grbBlockchain.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(66, 50);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(100, 23);
            this.txtFrom.TabIndex = 0;
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(186, 50);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(100, 23);
            this.txtTo.TabIndex = 1;
            // 
            // txtAmmount
            // 
            this.txtAmmount.Location = new System.Drawing.Point(310, 50);
            this.txtAmmount.Name = "txtAmmount";
            this.txtAmmount.Size = new System.Drawing.Size(100, 23);
            this.txtAmmount.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(555, 50);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(106, 32);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(21, 15);
            this.lblFrom.TabIndex = 4;
            this.lblFrom.Text = "De";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(217, 32);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(30, 15);
            this.lblTo.TabIndex = 5;
            this.lblTo.Text = "Para";
            // 
            // lblAmmount
            // 
            this.lblAmmount.AutoSize = true;
            this.lblAmmount.Location = new System.Drawing.Point(326, 32);
            this.lblAmmount.Name = "lblAmmount";
            this.lblAmmount.Size = new System.Drawing.Size(69, 15);
            this.lblAmmount.TabIndex = 6;
            this.lblAmmount.Text = "Quantidade";
            // 
            // txtContractList
            // 
            this.txtContractList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContractList.Location = new System.Drawing.Point(6, 103);
            this.txtContractList.Multiline = true;
            this.txtContractList.Name = "txtContractList";
            this.txtContractList.Size = new System.Drawing.Size(764, 86);
            this.txtContractList.TabIndex = 7;
            // 
            // grbContract
            // 
            this.grbContract.Controls.Add(this.btnGenerateNewBlock);
            this.grbContract.Controls.Add(this.lblContractList);
            this.grbContract.Controls.Add(this.lblItem);
            this.grbContract.Controls.Add(this.txtItem);
            this.grbContract.Controls.Add(this.txtContractList);
            this.grbContract.Controls.Add(this.lblAmmount);
            this.grbContract.Controls.Add(this.txtAmmount);
            this.grbContract.Controls.Add(this.lblTo);
            this.grbContract.Controls.Add(this.txtFrom);
            this.grbContract.Controls.Add(this.lblFrom);
            this.grbContract.Controls.Add(this.txtTo);
            this.grbContract.Controls.Add(this.btnAdd);
            this.grbContract.Location = new System.Drawing.Point(12, 12);
            this.grbContract.Name = "grbContract";
            this.grbContract.Size = new System.Drawing.Size(776, 228);
            this.grbContract.TabIndex = 9;
            this.grbContract.TabStop = false;
            this.grbContract.Text = "Contrato";
            // 
            // btnGenerateNewBlock
            // 
            this.btnGenerateNewBlock.Location = new System.Drawing.Point(186, 195);
            this.btnGenerateNewBlock.Name = "btnGenerateNewBlock";
            this.btnGenerateNewBlock.Size = new System.Drawing.Size(394, 23);
            this.btnGenerateNewBlock.TabIndex = 11;
            this.btnGenerateNewBlock.Text = "Gerar Novo Bloco";
            this.btnGenerateNewBlock.UseVisualStyleBackColor = true;
            this.btnGenerateNewBlock.Click += new System.EventHandler(this.btnGenerateNewBlock_Click);
            // 
            // lblContractList
            // 
            this.lblContractList.AutoSize = true;
            this.lblContractList.Location = new System.Drawing.Point(310, 85);
            this.lblContractList.Name = "lblContractList";
            this.lblContractList.Size = new System.Drawing.Size(102, 15);
            this.lblContractList.TabIndex = 10;
            this.lblContractList.Text = "Lista de Contratos";
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(465, 32);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(31, 15);
            this.lblItem.TabIndex = 9;
            this.lblItem.Text = "Item";
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(432, 50);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(100, 23);
            this.txtItem.TabIndex = 8;
            // 
            // grbBlockchain
            // 
            this.grbBlockchain.Controls.Add(this.txtBlockchain);
            this.grbBlockchain.Location = new System.Drawing.Point(12, 246);
            this.grbBlockchain.Name = "grbBlockchain";
            this.grbBlockchain.Size = new System.Drawing.Size(776, 211);
            this.grbBlockchain.TabIndex = 10;
            this.grbBlockchain.TabStop = false;
            this.grbBlockchain.Text = "Blockchain";
            // 
            // txtBlockchain
            // 
            this.txtBlockchain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBlockchain.Location = new System.Drawing.Point(6, 22);
            this.txtBlockchain.Multiline = true;
            this.txtBlockchain.Name = "txtBlockchain";
            this.txtBlockchain.Size = new System.Drawing.Size(764, 183);
            this.txtBlockchain.TabIndex = 11;
            // 
            // frmBlockchain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 469);
            this.Controls.Add(this.grbBlockchain);
            this.Controls.Add(this.grbContract);
            this.Name = "frmBlockchain";
            this.RightToLeftLayout = true;
            this.Text = "Blockchain";
            this.grbContract.ResumeLayout(false);
            this.grbContract.PerformLayout();
            this.grbBlockchain.ResumeLayout(false);
            this.grbBlockchain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.TextBox txtAmmount;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblAmmount;
        private System.Windows.Forms.TextBox txtContractList;
        private System.Windows.Forms.GroupBox grbContract;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Label lblContractList;
        private System.Windows.Forms.GroupBox grbBlockchain;
        private System.Windows.Forms.TextBox txtBlockchain;
        private System.Windows.Forms.Button btnGenerateNewBlock;
    }
}

