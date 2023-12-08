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
    public partial class frmLabourSetting : Form
    {
        
 
        public frmLabourSetting()
        {
            InitializeComponent();
        }
        
        decimal traTax = 0m;
        decimal districtTax = 0m;
        

        //poperties
        public decimal TraTax
        {
            get
            {
                return traTax;
            }
        }

        public decimal DistrictTax
        {
            get
            {
                return districtTax;
            }
        }

        //public string groupBox { get; set; }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //grpBox selection
            
            if ((grpBoxTraSet.Visible == true) && (grpBoxLabourSLevy.Visible == true))
            {
                if (!(Decimal.TryParse(txtPercentTRA.Text, out _)))
                {
                    MessageBox.Show("TRA Tax must be a valid decimal value", "Valid TRA Tax Value Is Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPercentTRA.Focus();
                }
                else if (!(Decimal.TryParse(txtPercentDistrict.Text, out _)))
                {
                    MessageBox.Show("District Tax must be a valid decimal value", "Valid District Tax Value Is Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPercentTRA.Focus();
                }
                else
                {
                    //if the TotalPay is greater than 500000 both group box are visble hence TRA and Service Levy will be deducted
                    traTax = Convert.ToDecimal(txtPercentTRA.Text);
                    districtTax = Convert.ToDecimal(txtPercentDistrict.Text);
                }
                
            }
            else
            {
                if (!(Decimal.TryParse(txtPercentTRA.Text, out _)))
                {
                    MessageBox.Show("TRA Tax must be a valid decimal value", "Valid TRA Tax Value Is Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPercentTRA.Focus();
                }
                else
                {
                    //if totalpay is less than 500000, tra only will be deducted
                    traTax = Convert.ToDecimal(txtPercentTRA.Text);
                }
                
            }
           
            //traTax = Convert.ToDecimal(txtPercentTRASupplier.Text);
            //districtTax = Convert.ToDecimal(txtPercentTRALabour.Text);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            traTax = 0;
            districtTax = 0;
        }


    }
}
