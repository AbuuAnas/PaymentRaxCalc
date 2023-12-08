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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
           
            frmSupplies supplies = new frmSupplies();
            supplies.ShowDialog();
        }

        private void btnLabours_Click(object sender, EventArgs e)
        {
            frmLabour labour = new frmLabour();
            labour.ShowDialog();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmSupplierSetting frm = new frmSupplierSetting();
            frm.ShowDialog();
        }
    }
}
