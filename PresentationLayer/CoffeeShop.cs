using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class CoffeeShop : Form
    {
        public CoffeeShop()
        {
            InitializeComponent();
        }

        private void CoffeeShop_Load(object sender, EventArgs e)
        {
            this.Show();
            this.Enabled = false;

            Login login = new Login();
            DialogResult result = login.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.Enabled = true;
                this.lbWelcome.Text = "Welcome" + "Truong Thi Bich Thuy";
            }
            else
            {
                Application.Exit();
            }
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            //create
            SupplierFolder.frmSupplier frmSupplier = new SupplierFolder.frmSupplier();
            //
            frmSupplier.TopLevel = false;
            pnMain.Controls.Clear(); //xoa label 
            pnMain.Controls.Add(frmSupplier);

            frmSupplier.Dock = DockStyle.Fill;
            frmSupplier.FormBorderStyle = FormBorderStyle.None;

            frmSupplier.Show();

        }
    }
}
