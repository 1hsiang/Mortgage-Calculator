using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MortgageCalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtHousePrice.Text = "12000000";
            txtDownPaymentPercent.Text = "20";
            txtDownPaymentAmount.Text = "";
            txtAnnualRate.Text = "2.15";
            txtYears.Text = "30";
            txtGraceYears.Text = "0";

            lblLoanAmountValue.Text = "";
            lblMonthlyPaymentValue.Text = "";
            lblFirstInterestValue.Text = "";
            lblFirstPrincipalValue.Text = "";
            lblTotalInterestValue.Text = "";
            lblTotalPaymentValue.Text = "";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtHousePrice.Text, out double housePrice) || housePrice <= 0)
            {
                MessageBox.Show("請輸入正確的房屋總價！", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(txtAnnualRate.Text, out double annualRate) || annualRate < 0)
            {
                MessageBox.Show("請輸入正確的年利率！", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtYears.Text, out int years) || years <= 0)
            {
                MessageBox.Show("請輸入正確的貸款年限！", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtGraceYears.Text, out int graceYears) || graceYears < 0 || graceYears >= years)
            {
                MessageBox.Show("寬限期必須大於等於 0，且小於貸款年限！", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double loanAmount = 0;

            bool percentFilled = !string.IsNullOrWhiteSpace(txtDownPaymentPercent.Text);
            bool amountFilled = !string.IsNullOrWhiteSpace(txtDownPaymentAmount.Text);

            if (percentFilled && amountFilled)
            {
                MessageBox.Show("自備款比例與自備款金額請擇一輸入！", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!percentFilled && !amountFilled)
            {
                MessageBox.Show("請輸入自備款比例或自備款金額！", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (percentFilled)
            {
                if (!double.TryParse(txtDownPaymentPercent.Text, out double downPaymentPercent))
                {
                    MessageBox.Show("自備款比例格式錯誤！", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (downPaymentPercent < 0 || downPaymentPercent >= 100)
                {
                    MessageBox.Show("自備款比例必須介於 0 到 100 之間！", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                loanAmount = housePrice * (1 - downPaymentPercent / 100.0);
            }
            else
            {
                if (!double.TryParse(txtDownPaymentAmount.Text, out double downPaymentAmount))
                {
                    MessageBox.Show("自備款金額格式錯誤！", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (downPaymentAmount < 0 || downPaymentAmount >= housePrice)
                {
                    MessageBox.Show("自備款金額不可小於 0 或大於等於房價！", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                loanAmount = housePrice - downPaymentAmount;
            }

            double monthlyRate = annualRate / 12.0 / 100.0;
            int totalMonths = years * 12;
            int graceMonths = graceYears * 12;

            double monthlyPayment = 0;
            double firstInterest = 0;
            double firstPrincipal = 0;
            double totalInterest = 0;
            double totalPayment = 0;

            if (graceMonths == 0)
            {
                if (monthlyRate == 0)
                {
                    monthlyPayment = loanAmount / totalMonths;
                }
                else
                {
                    monthlyPayment = loanAmount * monthlyRate * Math.Pow(1 + monthlyRate, totalMonths)
                                   / (Math.Pow(1 + monthlyRate, totalMonths) - 1);
                }

                firstInterest = loanAmount * monthlyRate;
                firstPrincipal = monthlyPayment - firstInterest;
                totalPayment = monthlyPayment * totalMonths;
                totalInterest = totalPayment - loanAmount;
            }
            else
            {
                double graceMonthlyInterest = loanAmount * monthlyRate;
                int remainMonths = totalMonths - graceMonths;
                double paymentAfterGrace;

                if (remainMonths <= 0)
                {
                    MessageBox.Show("寬限期設定錯誤！", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (monthlyRate == 0)
                {
                    paymentAfterGrace = loanAmount / remainMonths;
                }
                else
                {
                    paymentAfterGrace = loanAmount * monthlyRate * Math.Pow(1 + monthlyRate, remainMonths)
                                      / (Math.Pow(1 + monthlyRate, remainMonths) - 1);
                }

                monthlyPayment = paymentAfterGrace;
                firstInterest = graceMonthlyInterest;
                firstPrincipal = 0;
                totalPayment = graceMonthlyInterest * graceMonths + paymentAfterGrace * remainMonths;
                totalInterest = totalPayment - loanAmount;
            }

            lblLoanAmountValue.Text = loanAmount.ToString("N2");
            lblMonthlyPaymentValue.Text = monthlyPayment.ToString("N2");
            lblFirstInterestValue.Text = firstInterest.ToString("N2");
            lblFirstPrincipalValue.Text = firstPrincipal.ToString("N2");
            lblTotalInterestValue.Text = totalInterest.ToString("N2");
            lblTotalPaymentValue.Text = totalPayment.ToString("N2");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtHousePrice.Text = "";
            txtDownPaymentPercent.Text = "";
            txtDownPaymentAmount.Text = "";
            txtAnnualRate.Text = "";
            txtYears.Text = "";
            txtGraceYears.Text = "";

            lblLoanAmountValue.Text = "";
            lblMonthlyPaymentValue.Text = "";
            lblFirstInterestValue.Text = "";
            lblFirstPrincipalValue.Text = "";
            lblTotalInterestValue.Text = "";
            lblTotalPaymentValue.Text = "";
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
