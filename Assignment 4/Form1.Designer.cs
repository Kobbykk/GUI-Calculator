namespace Assignment_4
{
    partial class Form1
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
            this.txtPurchasePrice = new System.Windows.Forms.TextBox();
            this.txtDownPaymentAmount = new System.Windows.Forms.TextBox();
            this.txtInterestRate = new System.Windows.Forms.TextBox();
            this.txtLoanTerm = new System.Windows.Forms.TextBox();
            this.txtAmountToFinance = new System.Windows.Forms.TextBox();
            this.txtMonthlyPayment = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblDownPaymentAmount = new System.Windows.Forms.Label();
            this.lblInterestRate = new System.Windows.Forms.Label();
            this.lblPurchasePrice = new System.Windows.Forms.Label();
            this.lblAmountToFinance = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblLoanTerm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPurchasePrice
            // 
            this.txtPurchasePrice.Location = new System.Drawing.Point(151, 48);
            this.txtPurchasePrice.Name = "txtPurchasePrice";
            this.txtPurchasePrice.Size = new System.Drawing.Size(100, 20);
            this.txtPurchasePrice.TabIndex = 0;
            // 
            // txtDownPaymentAmount
            // 
            this.txtDownPaymentAmount.Location = new System.Drawing.Point(151, 100);
            this.txtDownPaymentAmount.Name = "txtDownPaymentAmount";
            this.txtDownPaymentAmount.Size = new System.Drawing.Size(100, 20);
            this.txtDownPaymentAmount.TabIndex = 1;
            // 
            // txtInterestRate
            // 
            this.txtInterestRate.BackColor = System.Drawing.SystemColors.Window;
            this.txtInterestRate.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtInterestRate.Location = new System.Drawing.Point(151, 153);
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.Size = new System.Drawing.Size(100, 20);
            this.txtInterestRate.TabIndex = 2;
            // 
            // txtLoanTerm
            // 
            this.txtLoanTerm.Location = new System.Drawing.Point(151, 215);
            this.txtLoanTerm.Name = "txtLoanTerm";
            this.txtLoanTerm.Size = new System.Drawing.Size(100, 20);
            this.txtLoanTerm.TabIndex = 3;
            // 
            // txtAmountToFinance
            // 
            this.txtAmountToFinance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtAmountToFinance.Location = new System.Drawing.Point(526, 48);
            this.txtAmountToFinance.Name = "txtAmountToFinance";
            this.txtAmountToFinance.ReadOnly = true;
            this.txtAmountToFinance.Size = new System.Drawing.Size(121, 20);
            this.txtAmountToFinance.TabIndex = 4;
            // 
            // txtMonthlyPayment
            // 
            this.txtMonthlyPayment.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtMonthlyPayment.Location = new System.Drawing.Point(526, 100);
            this.txtMonthlyPayment.Name = "txtMonthlyPayment";
            this.txtMonthlyPayment.ReadOnly = true;
            this.txtMonthlyPayment.Size = new System.Drawing.Size(121, 20);
            this.txtMonthlyPayment.TabIndex = 5;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(572, 275);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(20, 284);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblDownPaymentAmount
            // 
            this.lblDownPaymentAmount.AutoSize = true;
            this.lblDownPaymentAmount.Location = new System.Drawing.Point(17, 103);
            this.lblDownPaymentAmount.Name = "lblDownPaymentAmount";
            this.lblDownPaymentAmount.Size = new System.Drawing.Size(121, 13);
            this.lblDownPaymentAmount.TabIndex = 8;
            this.lblDownPaymentAmount.Text = "Down Payment Amount:";
            // 
            // lblInterestRate
            // 
            this.lblInterestRate.AutoSize = true;
            this.lblInterestRate.Location = new System.Drawing.Point(22, 156);
            this.lblInterestRate.Name = "lblInterestRate";
            this.lblInterestRate.Size = new System.Drawing.Size(113, 13);
            this.lblInterestRate.TabIndex = 9;
            this.lblInterestRate.Text = "Interest Rate (Annual):";
            // 
            // lblPurchasePrice
            // 
            this.lblPurchasePrice.AutoSize = true;
            this.lblPurchasePrice.Location = new System.Drawing.Point(57, 51);
            this.lblPurchasePrice.Name = "lblPurchasePrice";
            this.lblPurchasePrice.Size = new System.Drawing.Size(82, 13);
            this.lblPurchasePrice.TabIndex = 10;
            this.lblPurchasePrice.Text = "Purchase Price:";
            // 
            // lblAmountToFinance
            // 
            this.lblAmountToFinance.AutoSize = true;
            this.lblAmountToFinance.Location = new System.Drawing.Point(421, 51);
            this.lblAmountToFinance.Name = "lblAmountToFinance";
            this.lblAmountToFinance.Size = new System.Drawing.Size(99, 13);
            this.lblAmountToFinance.TabIndex = 11;
            this.lblAmountToFinance.Text = "Amount to Finance:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(429, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Monthly Payment:";
            // 
            // lblLoanTerm
            // 
            this.lblLoanTerm.AutoSize = true;
            this.lblLoanTerm.Location = new System.Drawing.Point(30, 218);
            this.lblLoanTerm.Name = "lblLoanTerm";
            this.lblLoanTerm.Size = new System.Drawing.Size(105, 13);
            this.lblLoanTerm.TabIndex = 13;
            this.lblLoanTerm.Text = "Loan Term (Months):";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(706, 319);
            this.Controls.Add(this.lblLoanTerm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblAmountToFinance);
            this.Controls.Add(this.lblPurchasePrice);
            this.Controls.Add(this.lblInterestRate);
            this.Controls.Add(this.lblDownPaymentAmount);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtMonthlyPayment);
            this.Controls.Add(this.txtAmountToFinance);
            this.Controls.Add(this.txtLoanTerm);
            this.Controls.Add(this.txtInterestRate);
            this.Controls.Add(this.txtDownPaymentAmount);
            this.Controls.Add(this.txtPurchasePrice);
            this.Name = "Form1";
            this.Text = "Monthly Payment Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPurchasePrice;
        private System.Windows.Forms.TextBox txtDownPaymentAmount;
        private System.Windows.Forms.TextBox txtInterestRate;
        private System.Windows.Forms.TextBox txtLoanTerm;
        private System.Windows.Forms.TextBox txtAmountToFinance;
        private System.Windows.Forms.TextBox txtMonthlyPayment;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblDownPaymentAmount;
        private System.Windows.Forms.Label lblInterestRate;
        private System.Windows.Forms.Label lblPurchasePrice;
        private System.Windows.Forms.Label lblAmountToFinance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblLoanTerm;
    }
}

