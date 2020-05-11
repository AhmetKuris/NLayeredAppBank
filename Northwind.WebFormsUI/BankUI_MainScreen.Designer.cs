namespace Northwind.WebFormsUI
{
    partial class BankUI_MainScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BankUI_MainScreen));
            this.gbxDeposit = new System.Windows.Forms.GroupBox();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.lblDeposit = new System.Windows.Forms.Label();
            this.tbxDepositAmount = new System.Windows.Forms.TextBox();
            this.gbxTransfer = new System.Windows.Forms.GroupBox();
            this.lblAmountTransfer = new System.Windows.Forms.Label();
            this.tbxTransferAmount = new System.Windows.Forms.TextBox();
            this.btnTransferMoney = new System.Windows.Forms.Button();
            this.lblNameTransfer = new System.Windows.Forms.Label();
            this.tbxNameTransfer = new System.Windows.Forms.TextBox();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.gbxUserPanel = new System.Windows.Forms.GroupBox();
            this.lblBalanceOutput = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.gbxWithdraw = new System.Windows.Forms.GroupBox();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.lblWithdraw = new System.Windows.Forms.Label();
            this.tbxWithdrawAmount = new System.Windows.Forms.TextBox();
            this.gbxDeposit.SuspendLayout();
            this.gbxTransfer.SuspendLayout();
            this.gbxUserPanel.SuspendLayout();
            this.gbxWithdraw.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxDeposit
            // 
            this.gbxDeposit.Controls.Add(this.btnDeposit);
            this.gbxDeposit.Controls.Add(this.lblDeposit);
            this.gbxDeposit.Controls.Add(this.tbxDepositAmount);
            this.gbxDeposit.Location = new System.Drawing.Point(12, 74);
            this.gbxDeposit.Name = "gbxDeposit";
            this.gbxDeposit.Size = new System.Drawing.Size(300, 191);
            this.gbxDeposit.TabIndex = 4;
            this.gbxDeposit.TabStop = false;
            this.gbxDeposit.Text = "Deposit Money";
            // 
            // btnDeposit
            // 
            this.btnDeposit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDeposit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeposit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeposit.Location = new System.Drawing.Point(181, 139);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(75, 37);
            this.btnDeposit.TabIndex = 5;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = false;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // lblDeposit
            // 
            this.lblDeposit.AutoSize = true;
            this.lblDeposit.Location = new System.Drawing.Point(20, 87);
            this.lblDeposit.Name = "lblDeposit";
            this.lblDeposit.Size = new System.Drawing.Size(43, 13);
            this.lblDeposit.TabIndex = 4;
            this.lblDeposit.Text = "Amount";
            // 
            // tbxDepositAmount
            // 
            this.tbxDepositAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDepositAmount.Location = new System.Drawing.Point(79, 75);
            this.tbxDepositAmount.Name = "tbxDepositAmount";
            this.tbxDepositAmount.Size = new System.Drawing.Size(161, 32);
            this.tbxDepositAmount.TabIndex = 3;
            // 
            // gbxTransfer
            // 
            this.gbxTransfer.Controls.Add(this.lblAmountTransfer);
            this.gbxTransfer.Controls.Add(this.tbxTransferAmount);
            this.gbxTransfer.Controls.Add(this.btnTransferMoney);
            this.gbxTransfer.Controls.Add(this.lblNameTransfer);
            this.gbxTransfer.Controls.Add(this.tbxNameTransfer);
            this.gbxTransfer.Location = new System.Drawing.Point(333, 307);
            this.gbxTransfer.Name = "gbxTransfer";
            this.gbxTransfer.Size = new System.Drawing.Size(300, 186);
            this.gbxTransfer.TabIndex = 8;
            this.gbxTransfer.TabStop = false;
            this.gbxTransfer.Text = "Transfer Money";
            // 
            // lblAmountTransfer
            // 
            this.lblAmountTransfer.AutoSize = true;
            this.lblAmountTransfer.Location = new System.Drawing.Point(63, 98);
            this.lblAmountTransfer.Name = "lblAmountTransfer";
            this.lblAmountTransfer.Size = new System.Drawing.Size(43, 13);
            this.lblAmountTransfer.TabIndex = 7;
            this.lblAmountTransfer.Text = "Amount";
            // 
            // tbxTransferAmount
            // 
            this.tbxTransferAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTransferAmount.Location = new System.Drawing.Point(112, 86);
            this.tbxTransferAmount.Name = "tbxTransferAmount";
            this.tbxTransferAmount.Size = new System.Drawing.Size(161, 32);
            this.tbxTransferAmount.TabIndex = 6;
            // 
            // btnTransferMoney
            // 
            this.btnTransferMoney.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTransferMoney.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTransferMoney.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTransferMoney.Location = new System.Drawing.Point(198, 134);
            this.btnTransferMoney.Name = "btnTransferMoney";
            this.btnTransferMoney.Size = new System.Drawing.Size(75, 37);
            this.btnTransferMoney.TabIndex = 5;
            this.btnTransferMoney.Text = "Send";
            this.btnTransferMoney.UseVisualStyleBackColor = false;
            this.btnTransferMoney.Click += new System.EventHandler(this.btnTransferMoney_Click);
            // 
            // lblNameTransfer
            // 
            this.lblNameTransfer.AutoSize = true;
            this.lblNameTransfer.Location = new System.Drawing.Point(42, 42);
            this.lblNameTransfer.Name = "lblNameTransfer";
            this.lblNameTransfer.Size = new System.Drawing.Size(54, 13);
            this.lblNameTransfer.TabIndex = 4;
            this.lblNameTransfer.Text = "To Whom";
            // 
            // tbxNameTransfer
            // 
            this.tbxNameTransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNameTransfer.Location = new System.Drawing.Point(112, 30);
            this.tbxNameTransfer.Name = "tbxNameTransfer";
            this.tbxNameTransfer.Size = new System.Drawing.Size(161, 32);
            this.tbxNameTransfer.TabIndex = 3;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Maroon;
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogOut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogOut.Location = new System.Drawing.Point(198, 139);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 37);
            this.btnLogOut.TabIndex = 8;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // gbxUserPanel
            // 
            this.gbxUserPanel.Controls.Add(this.lblBalanceOutput);
            this.gbxUserPanel.Controls.Add(this.lblBalance);
            this.gbxUserPanel.Controls.Add(this.btnLogOut);
            this.gbxUserPanel.Location = new System.Drawing.Point(333, 74);
            this.gbxUserPanel.Name = "gbxUserPanel";
            this.gbxUserPanel.Size = new System.Drawing.Size(300, 191);
            this.gbxUserPanel.TabIndex = 9;
            this.gbxUserPanel.TabStop = false;
            this.gbxUserPanel.Text = "User Panel";
            // 
            // lblBalanceOutput
            // 
            this.lblBalanceOutput.AutoSize = true;
            this.lblBalanceOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalanceOutput.Location = new System.Drawing.Point(141, 78);
            this.lblBalanceOutput.Name = "lblBalanceOutput";
            this.lblBalanceOutput.Size = new System.Drawing.Size(30, 26);
            this.lblBalanceOutput.TabIndex = 9;
            this.lblBalanceOutput.Text = "...";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(19, 87);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(46, 13);
            this.lblBalance.TabIndex = 4;
            this.lblBalance.Text = "Balance";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(237, 22);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(192, 26);
            this.lblWelcome.TabIndex = 9;
            this.lblWelcome.Text = "Welcome AHMET!";
            // 
            // gbxWithdraw
            // 
            this.gbxWithdraw.Controls.Add(this.btnWithdraw);
            this.gbxWithdraw.Controls.Add(this.lblWithdraw);
            this.gbxWithdraw.Controls.Add(this.tbxWithdrawAmount);
            this.gbxWithdraw.Location = new System.Drawing.Point(12, 307);
            this.gbxWithdraw.Name = "gbxWithdraw";
            this.gbxWithdraw.Size = new System.Drawing.Size(300, 186);
            this.gbxWithdraw.TabIndex = 9;
            this.gbxWithdraw.TabStop = false;
            this.gbxWithdraw.Text = "Withdraw Money";
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnWithdraw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWithdraw.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnWithdraw.Location = new System.Drawing.Point(181, 134);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(75, 37);
            this.btnWithdraw.TabIndex = 5;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = false;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // lblWithdraw
            // 
            this.lblWithdraw.AutoSize = true;
            this.lblWithdraw.Location = new System.Drawing.Point(20, 79);
            this.lblWithdraw.Name = "lblWithdraw";
            this.lblWithdraw.Size = new System.Drawing.Size(43, 13);
            this.lblWithdraw.TabIndex = 4;
            this.lblWithdraw.Text = "Amount";
            // 
            // tbxWithdrawAmount
            // 
            this.tbxWithdrawAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxWithdrawAmount.Location = new System.Drawing.Point(79, 67);
            this.tbxWithdrawAmount.Name = "tbxWithdrawAmount";
            this.tbxWithdrawAmount.Size = new System.Drawing.Size(161, 32);
            this.tbxWithdrawAmount.TabIndex = 3;
            // 
            // BankUI_MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 531);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.gbxWithdraw);
            this.Controls.Add(this.gbxUserPanel);
            this.Controls.Add(this.gbxTransfer);
            this.Controls.Add(this.gbxDeposit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BankUI_MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Key Inc. International ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BankUI_MainScreen_FormClosed);
            this.Load += new System.EventHandler(this.BankUI_MainScreen_Load);
            this.gbxDeposit.ResumeLayout(false);
            this.gbxDeposit.PerformLayout();
            this.gbxTransfer.ResumeLayout(false);
            this.gbxTransfer.PerformLayout();
            this.gbxUserPanel.ResumeLayout(false);
            this.gbxUserPanel.PerformLayout();
            this.gbxWithdraw.ResumeLayout(false);
            this.gbxWithdraw.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxDeposit;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Label lblDeposit;
        private System.Windows.Forms.TextBox tbxDepositAmount;
        private System.Windows.Forms.GroupBox gbxTransfer;
        private System.Windows.Forms.Button btnTransferMoney;
        private System.Windows.Forms.Label lblNameTransfer;
        private System.Windows.Forms.TextBox tbxNameTransfer;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.GroupBox gbxUserPanel;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblAmountTransfer;
        private System.Windows.Forms.TextBox tbxTransferAmount;
        private System.Windows.Forms.GroupBox gbxWithdraw;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Label lblWithdraw;
        private System.Windows.Forms.TextBox tbxWithdrawAmount;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblBalanceOutput;
    }
}