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
    public partial class BankUI_LoginScreen : Form
    {
        private IUserService _userService;


        public BankUI_LoginScreen()
        {
            InitializeComponent();
            _userService = InstanceFactory.GetInstance<IUserService>();

        }

        private void BankUI_LoginScreen_Load(object sender, EventArgs e)
        {
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (! String.IsNullOrEmpty(tbxName.Text) && !String.IsNullOrEmpty(tbxPassword.Text))
            {
                switch (_userService.Login(tbxName.Text,tbxPassword.Text))
                {
                    case "True":
                        this.Hide();
                        BankUI_MainScreen bankUiMainScreen = new BankUI_MainScreen();
                        bankUiMainScreen.ShowDialog();
                        this.Close();
                        break;

                    case "FalsePassword":
                        MessageBox.Show("Yanlış Şifre!");
                        break;

                    case "FalseUser":
                        MessageBox.Show("Böyle bir kullanıcı bulunamadı!");
                        break;
                }
                
            }
            else
            {
                MessageBox.Show("Alanlar boş bırakılamaz!");
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
              if (! String.IsNullOrEmpty(tbxName.Text) && !String.IsNullOrEmpty(tbxPassword.Text))
              {
                  switch (_userService.SignUp(tbxName.Text,tbxPassword.Text))
                  {
                    case "Added":
                        MessageBox.Show("User Added, please login to proceed");
                        tbxName.Clear();
                        tbxPassword.Clear();
                        break;

                    case "AlreadyExists":
                        MessageBox.Show("Aynı isimde bir kullanıcı zaten var, lütfen farklı isim seçiniz");
                        tbxName.Clear();
                        tbxPassword.Clear();
                        break;
                    
                  }
              }
              else
              {
                  MessageBox.Show("Alanlar boş bırakılamaz");
              }
        }
    }
}
