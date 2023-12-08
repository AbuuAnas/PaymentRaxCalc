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
    public partial class frmLabour : Form
    {
        public frmLabour()
        {
            InitializeComponent();
        }

        private void btnGoToSupplier_Click(object sender, EventArgs e)
        {
            frmSupplies supplies = new frmSupplies();
            supplies.ShowDialog();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            btnValidate.Enabled = false;
            btnAddDeductions.Enabled = true;
            btnAddPayee.Enabled = false;
            btnGoToSupplier.Enabled = false;
            btnNetPayLabour.Enabled = true;


            txtBoxCustomer.Text = txtBoxCustomer.Text.ToUpperInvariant().Trim();

            if (txtBoxCustomer.Text == "")
            {
                MessageBox.Show("Enter The Payee Name and Total Pay, Then Click Validate Amount Button Before Clicking Add Deduction Button", "Procedure Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (txtTotalPay.Text == "")
            {
                MessageBox.Show("Total Pay Is Required Field", "Entry Error");
                txtTotalPay.Focus();
            }

            else if (!(Decimal.TryParse(txtTotalPay.Text, out _)))
            {
                MessageBox.Show("Total Pay must be a valid decimal value", "Entry Error");
                txtTotalPay.Focus();
            }
            else
            {
                decimal totalPay = Convert.ToDecimal(txtTotalPay.Text);
                frmLabourSetting lbSetting = new frmLabourSetting();

                //close the group box of service levy in labour setting fif total pay < 500000
                if (totalPay < 500000)
                {

                    lbSetting.grpBoxLabourSLevy.Visible = false;
                }

                //use dialog to submit percentage entered by the user in labourseeting form to labour form
                //supplierSetting.ShowDialog();

                DialogResult response = lbSetting.ShowDialog();

                if (response == DialogResult.OK)
                {
                    txtPercentTRA.Text = lbSetting.TraTax.ToString();
                    txtPercentServiceLevy.Text = lbSetting.DistrictTax.ToString();
                }
                if (response == DialogResult.Cancel)
                {

                    txtPercentTRA.Text = lbSetting.TraTax.ToString();
                    txtPercentServiceLevy.Text = lbSetting.ToString();
                }

            }

        }

        private void btnNetPayLabour_Click(object sender, EventArgs e)
        {
            btnValidate.Enabled = false;
            btnAddDeductions.Enabled = false;
            btnAddPayee.Enabled = true;
            btnGoToSupplier.Enabled = true;
            //btnNetPaySupplier.Enabled = false;

            decimal totalPay = Convert.ToDecimal(txtTotalPay.Text);

            if (totalPay >= 500000)
            {
                decimal percentTRA = Convert.ToDecimal(txtPercentTRA.Text);
                decimal percentDistrict = Convert.ToDecimal(txtPercentServiceLevy.Text);

                decimal traDeductionAmount;
                decimal districtDeductionAmount;
                decimal totalPercentDeduction;
                decimal totaldeductionAmount;
                decimal netPay;

                traDeductionAmount = percentTRA * totalPay;
                txtTraAmount.Text = traDeductionAmount.ToString("n0");

                districtDeductionAmount = percentDistrict * totalPay;
                txtDistrictAmount.Text = districtDeductionAmount.ToString("n0");

                totalPercentDeduction = percentTRA + percentDistrict;
                txtTotalPercent.Text = totalPercentDeduction.ToString("p1");

                totaldeductionAmount = traDeductionAmount + districtDeductionAmount;
                txtTotalDeductionAmount.Text = totaldeductionAmount.ToString("n0");

                netPay = totalPay - totaldeductionAmount;
                txtNetPay.Text = netPay.ToString("n0");
              
            }
            if (totalPay < 500000)
            {
                decimal percentTRA = Convert.ToDecimal(txtPercentTRA.Text);
                decimal traDeductionAmount;
                decimal totalPercentDeduction;
                decimal totaldeductionAmount;
                decimal netPay;

                traDeductionAmount = percentTRA * totalPay;
                txtTraAmount.Text = traDeductionAmount.ToString("n0");

                totalPercentDeduction = percentTRA;
                txtTotalPercent.Text = totalPercentDeduction.ToString("P1");

                totaldeductionAmount = traDeductionAmount;
                txtTotalDeductionAmount.Text = totaldeductionAmount.ToString("n0");

                netPay = totalPay - totaldeductionAmount;
                txtNetPay.Text = netPay.ToString("n0");
            }
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            //btnValidate.Enabled = true;
            btnAddDeductions.Enabled = true;
            btnAddPayee.Enabled = false;
            btnGoToSupplier.Enabled = false;
            btnNetPayLabour.Enabled = false;

            txtBoxCustomer.Text = txtBoxCustomer.Text.ToUpperInvariant().Trim();

            if (txtBoxCustomer.Text == "")
            {
                MessageBox.Show("Enter The Payee Name", "Entry Error");
            }

            else if (txtTotalPay.Text == "")
            {
                MessageBox.Show("Total Pay Is Required Field", "Entry Error");
                txtTotalPay.Focus();
            }

            else if (!(Decimal.TryParse(txtTotalPay.Text, out _)))
            {
                MessageBox.Show("Total Pay must be a valid decimal value", "Entry Error");
                txtTotalPay.Focus();
            }
            else
            {
                decimal totalPay = Convert.ToDecimal(txtTotalPay.Text);
                if (totalPay <= 0)
                {
                    MessageBox.Show("Total Pay Must Be Greater thab 0", "Entry Error");
                }
                else if (totalPay >= 500000)
                {
                    groupBox1.Visible = false;
                    grpBoxserviceLevy.Visible = true;

                    txtTotalPay.Text = totalPay.ToString("n0");
                }
                else if (totalPay < 500000)
                {
                    groupBox1.Visible = true;

                    txtTotalPay.Text = totalPay.ToString("n0");
                }
            }
        }

            private void button3_Click(object sender, EventArgs e)
            {
                btnValidate.Enabled = true;
                btnAddDeductions.Enabled = false;
                btnAddPayee.Enabled = false;
                btnGoToSupplier.Enabled = false;
                btnNetPayLabour.Enabled = false;

                txtBoxCustomer.Clear();
                txtTotalPay.Clear();
                txtPercentTRA.Clear();
                txtPercentServiceLevy.Clear();
                txtTotalPercent.Clear();
                txtTraAmount.Clear();
                txtDistrictAmount.Clear();
                txtTotalDeductionAmount.Clear();
                txtNetPay.Clear();
            }


        private void frmLabour_Load(object sender, EventArgs e)
        {
            btnValidate.Enabled = true;
            btnAddDeductions.Enabled = false;
            btnAddPayee.Enabled = false;
            btnGoToSupplier.Enabled = false;
            btnNetPayLabour.Enabled = false;
        }
    }
}



