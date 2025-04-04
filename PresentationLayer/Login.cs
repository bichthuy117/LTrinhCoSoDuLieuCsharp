using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// 
using BusinessLayer;
using TransferObject;

namespace PresentationLayer
{
    public partial class Login : Form
    {
        private LoginBL loginBL; 

        public Login ()
        {
            InitializeComponent();
            loginBL = new LoginBL(); //thieu -> err
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        private bool UserLogin(Account account) //lay tu database
        {
            //return false; //chua ktra pass 
            try
            {
                return (loginBL.Login(account));
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false; 
            } 
            return false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user, pass;
            user = txtUsername.Text.Trim();
            pass = txtPassword.Text;

            Account account = new Account(user, pass);

            if (UserLogin(account) == true)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                string msg = "Username and password are incorrect";
                DialogResult result = MessageBox.Show(msg, "Login", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (result == DialogResult.Retry)
                {
                    txtPassword.Clear();
                    txtUsername.Focus();
                }
                else
                    this.DialogResult = DialogResult.Cancel;
            }
        }
    }
}
