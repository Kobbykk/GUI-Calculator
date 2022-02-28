using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double purchasePrice, downPayment, interestRate; 
            int  loanTerm;

            if (txtPurchasePrice.Text == "")
            {
                txtPurchasePrice.BackColor = Color.Tomato;
                MessageBox.Show("This inputs on this form cannot be empty.");
            }
            else if (txtDownPaymentAmount.Text == "")
            {
                txtDownPaymentAmount.BackColor = Color.Tomato;
                MessageBox.Show("This inputs on this form cannot be empty.");
            }
            else if (txtInterestRate.Text == "")
            {
                txtInterestRate.BackColor = Color.Tomato;
                MessageBox.Show("This inputs on this form cannot be empty.");
            }
            else if (txtLoanTerm.Text == "")
            {
                txtLoanTerm.BackColor = Color.Tomato;
                MessageBox.Show("This inputs on this form cannot be empty.");
            }

            else if (!Double.TryParse(txtPurchasePrice.Text, out purchasePrice))
            {
                MessageBox.Show("This input's value must be a valid decimal.");
            }
            else if (!Double.TryParse(txtDownPaymentAmount.Text, out downPayment))
            {
                MessageBox.Show("This input's value must be a valid decimal.");
            }
            else if (!Double.TryParse(txtInterestRate.Text, out interestRate))
            {
                MessageBox.Show("This input's value must be a valid decimal.");
            }
            else if (!Int32.TryParse(txtLoanTerm.Text, out loanTerm))
            {
                MessageBox.Show("This input's value must be a valid decimal.");
            }
            else
            {
                double amountToFinance = purchasePrice - downPayment;
                var monthlyPayment = ((interestRate /1200) * amountToFinance) / (1 - Math.Pow(1 + (interestRate / 1200), loanTerm * -1));
                txtAmountToFinance.Text = amountToFinance.ToString("C2");
                txtMonthlyPayment.Text = monthlyPayment.ToString("C2");
            }
        }
    }
}
