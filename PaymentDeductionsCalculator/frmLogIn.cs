using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaymentDeductionsCalculator
{
    public partial class frmLogIn : Form
    {
        public frmLogIn()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (txtBoxUserName.Text == "admin" && txtUserPassword.Text == "admin@2023")
            {
                frmSupplierSetting frmSet = new frmSupplierSetting();
                //show frm setting
                DialogResult response = frmSet.ShowDialog();

                if(response == DialogResult.OK)
                {

                }
                if(response == DialogResult.Cancel)
                {

                }
            }
            else
            {
                MessageBox.Show("Sorry, You are not Authorised To Make Changes On TRA and Service Levy Percentage", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
