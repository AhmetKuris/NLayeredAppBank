using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Northwind.Business.Abstract;
using Northwind.Business.DependencyResolvers.Ninject;

namespace Northwind.WebFormsUI
{
    public partial class BankUI_MainScreen : Form
    {
        private IUserService _userService;

        public BankUI_MainScreen()
        {
            InitializeComponent();
            _userService = InstanceFactory.GetInstance<IUserService>();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            _userService.ResetTempData();
            this.Hide();
            BankUI_LoginScreen bankUiLoginScreen=new BankUI_LoginScreen();
            bankUiLoginScreen.ShowDialog();
            this.Close();
        }

        private void BankUI_MainScreen_Load(object sender, EventArgs e)
        {

            RefreshBalance();

           lblWelcome.Text = _userService.WelcomeUser();

        }

        private void BankUI_MainScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            _userService.ResetTempData();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            _userService.DepositMoney(Convert.ToDecimal(tbxDepositAmount.Text));
            RefreshBalance();
            tbxDepositAmount.Clear();
        }

      
        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            _userService.WithdrawMoney(Convert.ToDecimal(tbxWithdrawAmount.Text));
            RefreshBalance();
            tbxWithdrawAmount.Clear();
        }

        public void RefreshBalance()
        {
            lblBalanceOutput.Text = _userService.ShowMyBalance();
        }

        private void btnTransferMoney_Click(object sender, EventArgs e)
        {
            _userService.TransferMoney(tbxNameTransfer.Text,Convert.ToDecimal(tbxTransferAmount.Text));
            RefreshBalance();
            tbxNameTransfer.Clear();
            tbxTransferAmount.Clear();
        }
    }
}
