
namespace PaymentDeductionsCalculator
{
    partial class frmLabour
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
            this.txtNetPay = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotalDeductionAmount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotalPercent = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDistrictAmount = new System.Windows.Forms.TextBox();
            this.txtTraAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPercentServiceLevy = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPercentTRA = new System.Windows.Forms.TextBox();
            this.grpBoxserviceLevy = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.grpBoxSupplierTRA = new System.Windows.Forms.GroupBox();
            this.grpBoxAlert = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTotalPay = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGoToSupplier = new System.Windows.Forms.Button();
            this.btnNetPayLabour = new System.Windows.Forms.Button();
            this.txtBoxCustomer = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnValidate = new System.Windows.Forms.Button();
            this.btnAddDeductions = new System.Windows.Forms.Button();
            this.btnAddPayee = new System.Windows.Forms.Button();
            this.printfrmLabour = new System.Drawing.Printing.PrintDocument();
            this.groupBox2.SuspendLayout();
            this.grpBoxserviceLevy.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpBoxSupplierTRA.SuspendLayout();
            this.grpBoxAlert.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNetPay
            // 
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtNetPay);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtTotalDeductionAmount);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtTotalPercent);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 368);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(430, 149);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Total Deductions";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(97, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 18);
            this.label8.TabIndex = 10;
            this.label8.Text = "Net Pay";
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
            // txtTraAmount
            // 
            this.txtTraAmount.Location = new System.Drawing.Point(263, 43);
            this.txtTraAmount.Name = "txtTraAmount";
            this.txtTraAmount.ReadOnly = true;
            this.txtTraAmount.Size = new System.Drawing.Size(151, 24);
            this.txtTraAmount.TabIndex = 7;
            this.txtTraAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // txtPercentServiceLevy
            // 
            this.txtPercentServiceLevy.Location = new System.Drawing.Point(77, 43);
            this.txtPercentServiceLevy.Name = "txtPercentServiceLevy";
            this.txtPercentServiceLevy.ReadOnly = true;
            this.txtPercentServiceLevy.Size = new System.Drawing.Size(69, 24);
            this.txtPercentServiceLevy.TabIndex = 3;
            this.txtPercentServiceLevy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // grpBoxserviceLevy
            // 
            this.grpBoxserviceLevy.Controls.Add(this.label2);
            this.grpBoxserviceLevy.Controls.Add(this.txtDistrictAmount);
            this.grpBoxserviceLevy.Controls.Add(this.label3);
            this.grpBoxserviceLevy.Controls.Add(this.txtPercentServiceLevy);
            this.grpBoxserviceLevy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxserviceLevy.Location = new System.Drawing.Point(12, 247);
            this.grpBoxserviceLevy.Name = "grpBoxserviceLevy";
            this.grpBoxserviceLevy.Size = new System.Drawing.Size(430, 106);
            this.grpBoxserviceLevy.TabIndex = 8;
            this.grpBoxserviceLevy.TabStop = false;
            this.grpBoxserviceLevy.Text = "District Service Levy Deduction";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(12, 248);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 114);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "District Service Levy Deduction";
            this.groupBox1.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 64);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(277, 18);
            this.label12.TabIndex = 1;
            this.label12.Text = "This Amount Has No Tax Deduction";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(344, 18);
            this.label13.TabIndex = 0;
            this.label13.Text = "The Supplier Amount Is Less Than 500 000/=";
            // 
            // grpBoxSupplierTRA
            // 
            this.grpBoxSupplierTRA.Controls.Add(this.label5);
            this.grpBoxSupplierTRA.Controls.Add(this.grpBoxAlert);
            this.grpBoxSupplierTRA.Controls.Add(this.txtTraAmount);
            this.grpBoxSupplierTRA.Controls.Add(this.label4);
            this.grpBoxSupplierTRA.Controls.Add(this.txtPercentTRA);
            this.grpBoxSupplierTRA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxSupplierTRA.Location = new System.Drawing.Point(12, 141);
            this.grpBoxSupplierTRA.Name = "grpBoxSupplierTRA";
            this.grpBoxSupplierTRA.Size = new System.Drawing.Size(430, 100);
            this.grpBoxSupplierTRA.TabIndex = 7;
            this.grpBoxSupplierTRA.TabStop = false;
            this.grpBoxSupplierTRA.Text = "Tanzania Revenue Authority Deduction";
            // 
            // grpBoxAlert
            // 
            this.grpBoxAlert.BackColor = System.Drawing.Color.Gainsboro;
            this.grpBoxAlert.Controls.Add(this.label10);
            this.grpBoxAlert.Controls.Add(this.label9);
            this.grpBoxAlert.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxAlert.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grpBoxAlert.Location = new System.Drawing.Point(6, 98);
            this.grpBoxAlert.Name = "grpBoxAlert";
            this.grpBoxAlert.Size = new System.Drawing.Size(430, 114);
            this.grpBoxAlert.TabIndex = 10;
            this.grpBoxAlert.TabStop = false;
            this.grpBoxAlert.Text = "District Service Levy Deduction";
            this.grpBoxAlert.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(245, 18);
            this.label10.TabIndex = 1;
            this.label10.Text = "This Amount Has No Tax Deduction";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(302, 18);
            this.label9.TabIndex = 0;
            this.label9.Text = "The Supplier Amount Is Less Than 500 000/=";
            // 
            // txtTotalPay
            // 
            this.txtTotalPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPay.Location = new System.Drawing.Point(86, 54);
            this.txtTotalPay.Name = "txtTotalPay";
            this.txtTotalPay.Size = new System.Drawing.Size(212, 24);
            this.txtTotalPay.TabIndex = 2;
            this.txtTotalPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Total Pay";
            // 
            // btnGoToSupplier
            // 
            this.btnGoToSupplier.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnGoToSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoToSupplier.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnGoToSupplier.Location = new System.Drawing.Point(319, 99);
            this.btnGoToSupplier.Name = "btnGoToSupplier";
            this.btnGoToSupplier.Size = new System.Drawing.Size(129, 36);
            this.btnGoToSupplier.TabIndex = 10;
            this.btnGoToSupplier.Text = "Go To Supplier >>";
            this.btnGoToSupplier.UseVisualStyleBackColor = false;
            this.btnGoToSupplier.Click += new System.EventHandler(this.btnGoToSupplier_Click);
            // 
            // btnNetPayLabour
            // 
            this.btnNetPayLabour.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnNetPayLabour.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNetPayLabour.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnNetPayLabour.Location = new System.Drawing.Point(126, 533);
            this.btnNetPayLabour.Name = "btnNetPayLabour";
            this.btnNetPayLabour.Size = new System.Drawing.Size(212, 30);
            this.btnNetPayLabour.TabIndex = 11;
            this.btnNetPayLabour.Text = "Calculate Labour Net Pay";
            this.btnNetPayLabour.UseVisualStyleBackColor = false;
            this.btnNetPayLabour.Click += new System.EventHandler(this.btnNetPayLabour_Click);
            // 
            // txtBoxCustomer
            // 
            this.txtBoxCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCustomer.Location = new System.Drawing.Point(89, 12);
            this.txtBoxCustomer.Name = "txtBoxCustomer";
            this.txtBoxCustomer.Size = new System.Drawing.Size(209, 24);
            this.txtBoxCustomer.TabIndex = 1;
            this.txtBoxCustomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(7, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 18);
            this.label11.TabIndex = 18;
            this.label11.Text = "Payee:";
            // 
            // btnValidate
            // 
            this.btnValidate.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnValidate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnValidate.Location = new System.Drawing.Point(327, 54);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(121, 24);
            this.btnValidate.TabIndex = 3;
            this.btnValidate.Text = "Validate Amount";
            this.btnValidate.UseVisualStyleBackColor = false;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // btnAddDeductions
            // 
            this.btnAddDeductions.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnAddDeductions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDeductions.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddDeductions.Image = global::PaymentDeductionsCalculator.Properties.Resources.update_button1;
            this.btnAddDeductions.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddDeductions.Location = new System.Drawing.Point(12, 99);
            this.btnAddDeductions.Name = "btnAddDeductions";
            this.btnAddDeductions.Size = new System.Drawing.Size(130, 36);
            this.btnAddDeductions.TabIndex = 13;
            this.btnAddDeductions.Text = "Add Deduction";
            this.btnAddDeductions.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddDeductions.UseVisualStyleBackColor = false;
            this.btnAddDeductions.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAddPayee
            // 
            this.btnAddPayee.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnAddPayee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPayee.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddPayee.Image = global::PaymentDeductionsCalculator.Properties.Resources.add_button;
            this.btnAddPayee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddPayee.Location = new System.Drawing.Point(177, 99);
            this.btnAddPayee.Name = "btnAddPayee";
            this.btnAddPayee.Size = new System.Drawing.Size(111, 36);
            this.btnAddPayee.TabIndex = 19;
            this.btnAddPayee.Text = "Add Payee";
            this.btnAddPayee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddPayee.UseVisualStyleBackColor = false;
            this.btnAddPayee.Click += new System.EventHandler(this.button3_Click);
            // 
            // printfrmLabour
            // 
            this.printfrmLabour.DocumentName = "frmLabour";
            // 
            // frmLabour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(463, 575);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAddPayee);
            this.Controls.Add(this.txtBoxCustomer);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnAddDeductions);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.btnNetPayLabour);
            this.Controls.Add(this.btnGoToSupplier);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpBoxserviceLevy);
            this.Controls.Add(this.grpBoxSupplierTRA);
            this.Controls.Add(this.txtTotalPay);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLabour";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Labour Deductions Sheet";
            this.Load += new System.EventHandler(this.frmLabour_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpBoxserviceLevy.ResumeLayout(false);
            this.grpBoxserviceLevy.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpBoxSupplierTRA.ResumeLayout(false);
            this.grpBoxSupplierTRA.PerformLayout();
            this.grpBoxAlert.ResumeLayout(false);
            this.grpBoxAlert.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNetPay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTotalDeductionAmount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotalPercent;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDistrictAmount;
        private System.Windows.Forms.TextBox txtTraAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPercentServiceLevy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPercentTRA;
        private System.Windows.Forms.GroupBox grpBoxserviceLevy;
        private System.Windows.Forms.GroupBox grpBoxSupplierTRA;
        private System.Windows.Forms.TextBox txtTotalPay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGoToSupplier;
        private System.Windows.Forms.Button btnNetPayLabour;
        private System.Windows.Forms.Button btnAddDeductions;
        private System.Windows.Forms.TextBox txtBoxCustomer;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.GroupBox grpBoxAlert;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAddPayee;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Drawing.Printing.PrintDocument printfrmLabour;
    }
}