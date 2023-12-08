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
    public partial class frmSupplierSetting : Form
    {
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
        public frmSupplierSetting()
        {
            InitializeComponent();
        }

        
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
                //grpBox selection

                if ((grpBoxTraSet.Visible == true) && (grpServDisTax.Visible == true))
                {
                    if (!(Decimal.TryParse(txtPercentTRASupplier.Text, out _)))
                    {
                        MessageBox.Show("TRA Tax must be a valid decimal value", "Valid TRA Tax Value Is Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtPercentTRASupplier.Focus();
                    }
                    else if (!(Decimal.TryParse(txtPercentDistrictSupplier.Text, out _)))
                    {
                        MessageBox.Show("District Tax must be a valid decimal value", "Valid District Tax Value Is Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtPercentTRASupplier.Focus();
                    }
                    else
                    {
                        //decimal traPercent = Convert.ToDecimal(txtPercentDistrictSupplier.Text);
                        //if the TotalPay is greater than 500000 both group box are visble hence TRA and Service Levy will be deducted
                        traTax = Convert.ToDecimal(txtPercentTRASupplier.Text);
                        districtTax = Convert.ToDecimal(txtPercentDistrictSupplier.Text);
                    }
                

                }
                else
                {
                    if (!(Decimal.TryParse(txtPercentTRASupplier.Text, out _)))
                    {
                        MessageBox.Show("District Tax must be a valid decimal value", "Valid District  Tax Value Is Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtPercentTRASupplier.Focus();
                    }
                    else
                    {
                    //if totalpay is less than 500000, tra only will be deducted
                    traTax = Convert.ToDecimal(txtPercentTRASupplier.Text);
                    }
                    
                }

                //traTax = Convert.ToDecimal(txtPercentTRASupplier.Text);
                //districtTax = Convert.ToDecimal(txtPercentDistrictSupplier.Text)
            }
        

        private void btnCancel_Click(object sender, EventArgs e)
        {
            traTax = 0;
            districtTax = 0;
        }

        private void frmSupplierSetting_Load(object sender, EventArgs e)
        {
             
        }
    }
}
