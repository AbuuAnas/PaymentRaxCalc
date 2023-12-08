
namespace PaymentDeductionsCalculator
{
    partial class frmSupplies
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotalPay = new System.Windows.Forms.TextBox();
            this.grpBoxSupplierTRA = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTraAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPercentTRA = new System.Windows.Forms.TextBox();
            this.groupBoxServiceLevy = new System.Windows.Forms.GroupBox();
            this.txtPercentSLevy = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDistrictAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grpBoxAlert = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNetPay = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotalDeductionAmount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotalPercent = new System.Windows.Forms.TextBox();
            this.btnGoToLabour = new System.Windows.Forms.Button();
            this.btnNetPaySupplier = new System.Windows.Forms.Button();
            this.btnValidate = new System.Windows.Forms.Button();
            this.txtBoxCustomer = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnAnotherPAY = new System.Windows.Forms.Button();
            this.btnDeductions = new System.Windows.Forms.Button();
            this.grpBoxSupplierTRA.SuspendLayout();
            this.groupBoxServiceLevy.SuspendLayout();
            this.grpBoxAlert.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Pay:";
            // 
            // txtTotalPay
            // 
            this.txtTotalPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPay.Location = new System.Drawing.Point(87, 54);
            this.txtTotalPay.Name = "txtTotalPay";
            this.txtTotalPay.Size = new System.Drawing.Size(209, 24);
            this.txtTotalPay.TabIndex = 2;
            this.txtTotalPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grpBoxSupplierTRA
            // 
            this.grpBoxSupplierTRA.Controls.Add(this.label5);
            this.grpBoxSupplierTRA.Controls.Add(this.txtTraAmount);
            this.grpBoxSupplierTRA.Controls.Add(this.label4);
            this.grpBoxSupplierTRA.Controls.Add(this.txtPercentTRA);
            this.grpBoxSupplierTRA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxSupplierTRA.Location = new System.Drawing.Point(9, 144);
            this.grpBoxSupplierTRA.Name = "grpBoxSupplierTRA";
            this.grpBoxSupplierTRA.Size = new System.Drawing.Size(430, 100);
            this.grpBoxSupplierTRA.TabIndex = 2;
            this.grpBoxSupplierTRA.TabStop = false;
            this.grpBoxSupplierTRA.Text = "Tanzania Revenue Authority Deduction";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(185, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Amount:";
            // 
            // txtTraAmount
            // 
            this.txtTraAmount.Location = new System.Drawing.Point(263, 43);
            this.txtTraAmount.Name = "txtTraAmount";
            this.txtTraAmount.ReadOnly = true;
            this.txtTraAmount.Size = new System.Drawing.Size(151, 24);
            this.txtTraAmount.TabIndex = 7;
            this.txtTraAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Percent:";
            // 
            // txtPercentTRA
            // 
            this.txtPercentTRA.Location = new System.Drawing.Point(77, 43);
            this.txtPercentTRA.Name = "txtPercentTRA";
            this.txtPercentTRA.ReadOnly = true;
            this.txtPercentTRA.Size = new System.Drawing.Size(69, 24);
            this.txtPercentTRA.TabIndex = 3;
            this.txtPercentTRA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBoxServiceLevy
            // 
            this.groupBoxServiceLevy.Controls.Add(this.txtPercentSLevy);
            this.groupBoxServiceLevy.Controls.Add(this.label2);
            this.groupBoxServiceLevy.Controls.Add(this.txtDistrictAmount);
            this.groupBoxServiceLevy.Controls.Add(this.label3);
            this.groupBoxServiceLevy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxServiceLevy.Location = new System.Drawing.Point(9, 250);
            this.groupBoxServiceLevy.Name = "groupBoxServiceLevy";
            this.groupBoxServiceLevy.Size = new System.Drawing.Size(430, 106);
            this.groupBoxServiceLevy.TabIndex = 3;
            this.groupBoxServiceLevy.TabStop = false;
            this.groupBoxServiceLevy.Text = "District Service Levy Deduction";
            // 
            // txtPercentSLevy
            // 
            this.txtPercentSLevy.Location = new System.Drawing.Point(77, 46);
            this.txtPercentSLevy.Name = "txtPercentSLevy";
            this.txtPercentSLevy.ReadOnly = true;
            this.txtPercentSLevy.Size = new System.Drawing.Size(69, 24);
            this.txtPercentSLevy.TabIndex = 10;
            this.txtPercentSLevy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Amount:";
            // 
            // txtDistrictAmount
            // 
            this.txtDistrictAmount.Location = new System.Drawing.Point(263, 43);
            this.txtDistrictAmount.Name = "txtDistrictAmount";
            this.txtDistrictAmount.ReadOnly = true;
            this.txtDistrictAmount.Size = new System.Drawing.Size(151, 24);
            this.txtDistrictAmount.TabIndex = 7;
            this.txtDistrictAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Percent:";
            // 
            // grpBoxAlert
            // 
            this.grpBoxAlert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grpBoxAlert.Controls.Add(this.label10);
            this.grpBoxAlert.Controls.Add(this.label9);
            this.grpBoxAlert.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxAlert.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grpBoxAlert.Location = new System.Drawing.Point(12, 242);
            this.grpBoxAlert.Name = "grpBoxAlert";
            this.grpBoxAlert.Size = new System.Drawing.Size(430, 114);
            this.grpBoxAlert.TabIndex = 9;
            this.grpBoxAlert.TabStop = false;
            this.grpBoxAlert.Text = "District Service Levy Deduction";
            this.grpBoxAlert.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(277, 18);
            this.label10.TabIndex = 1;
            this.label10.Text = "This Amount Has No Tax Deduction";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(9, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(344, 18);
            this.label9.TabIndex = 0;
            this.label9.Text = "The Supplier Amount Is Less Than 500 000/=";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtNetPay);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtTotalDeductionAmount);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtTotalPercent);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(14, 362);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(430, 149);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Total Deductions";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(97, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 18);
            this.label8.TabIndex = 10;
            this.label8.Text = "Net Pay";
            // 
            // txtNetPay
            // 
            this.txtNetPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNetPay.Location = new System.Drawing.Point(175, 107);
            this.txtNetPay.Name = "txtNetPay";
            this.txtNetPay.ReadOnly = true;
            this.txtNetPay.Size = new System.Drawing.Size(151, 24);
            this.txtNetPay.TabIndex = 9;
            this.txtNetPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(185, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Amount:";
            // 
            // txtTotalDeductionAmount
            // 
            this.txtTotalDeductionAmount.Location = new System.Drawing.Point(263, 43);
            this.txtTotalDeductionAmount.Name = "txtTotalDeductionAmount";
            this.txtTotalDeductionAmount.ReadOnly = true;
            this.txtTotalDeductionAmount.Size = new System.Drawing.Size(151, 24);
            this.txtTotalDeductionAmount.TabIndex = 7;
            this.txtTotalDeductionAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Percent:";
            // 
            // txtTotalPercent
            // 
            this.txtTotalPercent.Location = new System.Drawing.Point(77, 43);
            this.txtTotalPercent.Name = "txtTotalPercent";
            this.txtTotalPercent.ReadOnly = true;
            this.txtTotalPercent.Size = new System.Drawing.Size(69, 24);
            this.txtTotalPercent.TabIndex = 3;
            this.txtTotalPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnGoToLabour
            // 
            this.btnGoToLabour.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnGoToLabour.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoToLabour.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnGoToLabour.Location = new System.Drawing.Point(315, 104);
            this.btnGoToLabour.Name = "btnGoToLabour";
            this.btnGoToLabour.Size = new System.Drawing.Size(124, 34);
            this.btnGoToLabour.TabIndex = 5;
            this.btnGoToLabour.Text = "Go To Labour >>>";
            this.btnGoToLabour.UseVisualStyleBackColor = false;
            this.btnGoToLabour.Click += new System.EventHandler(this.btnGoToSupplier_Click);
            // 
            // btnNetPaySupplier
            // 
            this.btnNetPaySupplier.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnNetPaySupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNetPaySupplier.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnNetPaySupplier.Location = new System.Drawing.Point(131, 510);
            this.btnNetPaySupplier.Name = "btnNetPaySupplier";
            this.btnNetPaySupplier.Size = new System.Drawing.Size(220, 37);
            this.btnNetPaySupplier.TabIndex = 6;
            this.btnNetPaySupplier.Text = "Calculate Supplier Net Pay";
            this.btnNetPaySupplier.UseVisualStyleBackColor = false;
            this.btnNetPaySupplier.Click += new System.EventHandler(this.btnNetPaySupplier_Click);
            // 
            // btnValidate
            // 
            this.btnValidate.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnValidate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnValidate.Location = new System.Drawing.Point(318, 51);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(121, 27);
            this.btnValidate.TabIndex = 8;
            this.btnValidate.Text = "Validate Amount";
            this.btnValidate.UseVisualStyleBackColor = false;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // txtBoxCustomer
            // 
            this.txtBoxCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCustomer.Location = new System.Drawing.Point(87, 12);
            this.txtBoxCustomer.Name = "txtBoxCustomer";
            this.txtBoxCustomer.Size = new System.Drawing.Size(209, 24);
            this.txtBoxCustomer.TabIndex = 1;
            this.txtBoxCustomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(18, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 18);
            this.label11.TabIndex = 10;
            this.label11.Text = "Payee:";
            // 
            // btnAnotherPAY
            // 
            this.btnAnotherPAY.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnAnotherPAY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnotherPAY.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAnotherPAY.Image = global::PaymentDeductionsCalculator.Properties.Resources.add_button;
            this.btnAnotherPAY.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnotherPAY.Location = new System.Drawing.Point(167, 104);
            this.btnAnotherPAY.Name = "btnAnotherPAY";
            this.btnAnotherPAY.Size = new System.Drawing.Size(129, 34);
            this.btnAnotherPAY.TabIndex = 11;
            this.btnAnotherPAY.Text = "Another Payee";
            this.btnAnotherPAY.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAnotherPAY.UseVisualStyleBackColor = false;
            this.btnAnotherPAY.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnDeductions
            // 
            this.btnDeductions.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnDeductions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeductions.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDeductions.Image = global::PaymentDeductionsCalculator.Properties.Resources.update_button1;
            this.btnDeductions.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeductions.Location = new System.Drawing.Point(14, 104);
            this.btnDeductions.Name = "btnDeductions";
            this.btnDeductions.Size = new System.Drawing.Size(136, 34);
            this.btnDeductions.TabIndex = 7;
            this.btnDeductions.Text = "Add Deductions";
            this.btnDeductions.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeductions.UseVisualStyleBackColor = false;
            this.btnDeductions.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmSupplies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(446, 558);
            this.Controls.Add(this.btnAnotherPAY);
            this.Controls.Add(this.txtBoxCustomer);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.grpBoxAlert);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.btnDeductions);
            this.Controls.Add(this.btnNetPaySupplier);
            this.Controls.Add(this.btnGoToLabour);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxServiceLevy);
            this.Controls.Add(this.grpBoxSupplierTRA);
            this.Controls.Add(this.txtTotalPay);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSupplies";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Supplier Deductions Sheet";
            this.Load += new System.EventHandler(this.frmSupplies_Load);
            this.grpBoxSupplierTRA.ResumeLayout(false);
            this.grpBoxSupplierTRA.PerformLayout();
            this.groupBoxServiceLevy.ResumeLayout(false);
            this.groupBoxServiceLevy.PerformLayout();
            this.grpBoxAlert.ResumeLayout(false);
            this.grpBoxAlert.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpBoxSupplierTRA;
        private System.Windows.Forms.TextBox txtPercentTRA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTraAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBoxServiceLevy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDistrictAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNetPay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTotalDeductionAmount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotalPercent;
        private System.Windows.Forms.Button btnGoToLabour;
        private System.Windows.Forms.Button btnNetPaySupplier;
        private System.Windows.Forms.Button btnDeductions;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.GroupBox grpBoxAlert;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBoxCustomer;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txtTotalPay;
        private System.Windows.Forms.Button btnAnotherPAY;
        private System.Windows.Forms.TextBox txtPercentSLevy;
    }
}