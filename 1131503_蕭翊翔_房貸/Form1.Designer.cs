namespace MortgageCalculatorApp
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblHousePrice = new System.Windows.Forms.Label();
            this.lblDownPaymentPercent = new System.Windows.Forms.Label();
            this.lblDownPaymentAmount = new System.Windows.Forms.Label();
            this.lblAnnualRate = new System.Windows.Forms.Label();
            this.lblYears = new System.Windows.Forms.Label();
            this.lblGraceYears = new System.Windows.Forms.Label();
            this.txtHousePrice = new System.Windows.Forms.TextBox();
            this.txtDownPaymentPercent = new System.Windows.Forms.TextBox();
            this.txtDownPaymentAmount = new System.Windows.Forms.TextBox();
            this.txtAnnualRate = new System.Windows.Forms.TextBox();
            this.txtYears = new System.Windows.Forms.TextBox();
            this.txtGraceYears = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblLoanAmount = new System.Windows.Forms.Label();
            this.lblMonthlyPayment = new System.Windows.Forms.Label();
            this.lblFirstInterest = new System.Windows.Forms.Label();
            this.lblFirstPrincipal = new System.Windows.Forms.Label();
            this.lblTotalInterest = new System.Windows.Forms.Label();
            this.lblTotalPayment = new System.Windows.Forms.Label();
            this.lblLoanAmountValue = new System.Windows.Forms.Label();
            this.lblMonthlyPaymentValue = new System.Windows.Forms.Label();
            this.lblFirstInterestValue = new System.Windows.Forms.Label();
            this.lblFirstPrincipalValue = new System.Windows.Forms.Label();
            this.lblTotalInterestValue = new System.Windows.Forms.Label();
            this.lblTotalPaymentValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(160, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(204, 35);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "個人房貸試算器";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // lblHousePrice
            // 
            this.lblHousePrice.AutoSize = true;
            this.lblHousePrice.Location = new System.Drawing.Point(44, 71);
            this.lblHousePrice.Name = "lblHousePrice";
            this.lblHousePrice.Size = new System.Drawing.Size(92, 15);
            this.lblHousePrice.TabIndex = 1;
            this.lblHousePrice.Text = "房屋總價(元)";
            // 
            // lblDownPaymentPercent
            // 
            this.lblDownPaymentPercent.AutoSize = true;
            this.lblDownPaymentPercent.Location = new System.Drawing.Point(44, 103);
            this.lblDownPaymentPercent.Name = "lblDownPaymentPercent";
            this.lblDownPaymentPercent.Size = new System.Drawing.Size(104, 15);
            this.lblDownPaymentPercent.TabIndex = 2;
            this.lblDownPaymentPercent.Text = "自備款比例(%)";
            // 
            // lblDownPaymentAmount
            // 
            this.lblDownPaymentAmount.AutoSize = true;
            this.lblDownPaymentAmount.Location = new System.Drawing.Point(44, 134);
            this.lblDownPaymentAmount.Name = "lblDownPaymentAmount";
            this.lblDownPaymentAmount.Size = new System.Drawing.Size(107, 15);
            this.lblDownPaymentAmount.TabIndex = 3;
            this.lblDownPaymentAmount.Text = "自備款金額(元)";
            // 
            // lblAnnualRate
            // 
            this.lblAnnualRate.AutoSize = true;
            this.lblAnnualRate.Location = new System.Drawing.Point(44, 166);
            this.lblAnnualRate.Name = "lblAnnualRate";
            this.lblAnnualRate.Size = new System.Drawing.Size(74, 15);
            this.lblAnnualRate.TabIndex = 4;
            this.lblAnnualRate.Text = "年利率(%)";
            // 
            // lblYears
            // 
            this.lblYears.AutoSize = true;
            this.lblYears.Location = new System.Drawing.Point(44, 197);
            this.lblYears.Name = "lblYears";
            this.lblYears.Size = new System.Drawing.Size(92, 15);
            this.lblYears.TabIndex = 5;
            this.lblYears.Text = "貸款年限(年)";
            // 
            // lblGraceYears
            // 
            this.lblGraceYears.AutoSize = true;
            this.lblGraceYears.Location = new System.Drawing.Point(44, 229);
            this.lblGraceYears.Name = "lblGraceYears";
            this.lblGraceYears.Size = new System.Drawing.Size(77, 15);
            this.lblGraceYears.TabIndex = 6;
            this.lblGraceYears.Text = "寬限期(年)";
            // 
            // txtHousePrice
            // 
            this.txtHousePrice.Location = new System.Drawing.Point(160, 69);
            this.txtHousePrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHousePrice.Name = "txtHousePrice";
            this.txtHousePrice.Size = new System.Drawing.Size(143, 25);
            this.txtHousePrice.TabIndex = 7;
            // 
            // txtDownPaymentPercent
            // 
            this.txtDownPaymentPercent.Location = new System.Drawing.Point(160, 100);
            this.txtDownPaymentPercent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDownPaymentPercent.Name = "txtDownPaymentPercent";
            this.txtDownPaymentPercent.Size = new System.Drawing.Size(143, 25);
            this.txtDownPaymentPercent.TabIndex = 8;
            // 
            // txtDownPaymentAmount
            // 
            this.txtDownPaymentAmount.Location = new System.Drawing.Point(160, 132);
            this.txtDownPaymentAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDownPaymentAmount.Name = "txtDownPaymentAmount";
            this.txtDownPaymentAmount.Size = new System.Drawing.Size(143, 25);
            this.txtDownPaymentAmount.TabIndex = 9;
            // 
            // txtAnnualRate
            // 
            this.txtAnnualRate.Location = new System.Drawing.Point(160, 163);
            this.txtAnnualRate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAnnualRate.Name = "txtAnnualRate";
            this.txtAnnualRate.Size = new System.Drawing.Size(143, 25);
            this.txtAnnualRate.TabIndex = 10;
            // 
            // txtYears
            // 
            this.txtYears.Location = new System.Drawing.Point(160, 195);
            this.txtYears.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtYears.Name = "txtYears";
            this.txtYears.Size = new System.Drawing.Size(143, 25);
            this.txtYears.TabIndex = 11;
            // 
            // txtGraceYears
            // 
            this.txtGraceYears.Location = new System.Drawing.Point(160, 227);
            this.txtGraceYears.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGraceYears.Name = "txtGraceYears";
            this.txtGraceYears.Size = new System.Drawing.Size(143, 25);
            this.txtGraceYears.TabIndex = 12;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(62, 272);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(98, 32);
            this.btnCalculate.TabIndex = 13;
            this.btnCalculate.Text = "開始試算";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(187, 272);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(98, 32);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "清除";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblLoanAmount
            // 
            this.lblLoanAmount.AutoSize = true;
            this.lblLoanAmount.Location = new System.Drawing.Point(347, 79);
            this.lblLoanAmount.Name = "lblLoanAmount";
            this.lblLoanAmount.Size = new System.Drawing.Size(82, 15);
            this.lblLoanAmount.TabIndex = 15;
            this.lblLoanAmount.Text = "貸款總金額";
            // 
            // lblMonthlyPayment
            // 
            this.lblMonthlyPayment.AutoSize = true;
            this.lblMonthlyPayment.Location = new System.Drawing.Point(347, 111);
            this.lblMonthlyPayment.Name = "lblMonthlyPayment";
            this.lblMonthlyPayment.Size = new System.Drawing.Size(97, 15);
            this.lblMonthlyPayment.TabIndex = 16;
            this.lblMonthlyPayment.Text = "每月應繳金額";
            // 
            // lblFirstInterest
            // 
            this.lblFirstInterest.AutoSize = true;
            this.lblFirstInterest.Location = new System.Drawing.Point(347, 142);
            this.lblFirstInterest.Name = "lblFirstInterest";
            this.lblFirstInterest.Size = new System.Drawing.Size(67, 15);
            this.lblFirstInterest.TabIndex = 17;
            this.lblFirstInterest.Text = "首期利息";
            // 
            // lblFirstPrincipal
            // 
            this.lblFirstPrincipal.AutoSize = true;
            this.lblFirstPrincipal.Location = new System.Drawing.Point(347, 174);
            this.lblFirstPrincipal.Name = "lblFirstPrincipal";
            this.lblFirstPrincipal.Size = new System.Drawing.Size(67, 15);
            this.lblFirstPrincipal.TabIndex = 18;
            this.lblFirstPrincipal.Text = "首期本金";
            // 
            // lblTotalInterest
            // 
            this.lblTotalInterest.AutoSize = true;
            this.lblTotalInterest.Location = new System.Drawing.Point(347, 205);
            this.lblTotalInterest.Name = "lblTotalInterest";
            this.lblTotalInterest.Size = new System.Drawing.Size(82, 15);
            this.lblTotalInterest.TabIndex = 19;
            this.lblTotalInterest.Text = "總利息支出";
            // 
            // lblTotalPayment
            // 
            this.lblTotalPayment.AutoSize = true;
            this.lblTotalPayment.Location = new System.Drawing.Point(347, 237);
            this.lblTotalPayment.Name = "lblTotalPayment";
            this.lblTotalPayment.Size = new System.Drawing.Size(82, 15);
            this.lblTotalPayment.TabIndex = 20;
            this.lblTotalPayment.Text = "總還款金額";
            // 
            // lblLoanAmountValue
            // 
            this.lblLoanAmountValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLoanAmountValue.Location = new System.Drawing.Point(462, 75);
            this.lblLoanAmountValue.Name = "lblLoanAmountValue";
            this.lblLoanAmountValue.Size = new System.Drawing.Size(151, 23);
            this.lblLoanAmountValue.TabIndex = 21;
            this.lblLoanAmountValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMonthlyPaymentValue
            // 
            this.lblMonthlyPaymentValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMonthlyPaymentValue.Location = new System.Drawing.Point(462, 107);
            this.lblMonthlyPaymentValue.Name = "lblMonthlyPaymentValue";
            this.lblMonthlyPaymentValue.Size = new System.Drawing.Size(151, 23);
            this.lblMonthlyPaymentValue.TabIndex = 22;
            this.lblMonthlyPaymentValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFirstInterestValue
            // 
            this.lblFirstInterestValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFirstInterestValue.Location = new System.Drawing.Point(462, 138);
            this.lblFirstInterestValue.Name = "lblFirstInterestValue";
            this.lblFirstInterestValue.Size = new System.Drawing.Size(151, 23);
            this.lblFirstInterestValue.TabIndex = 23;
            this.lblFirstInterestValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFirstPrincipalValue
            // 
            this.lblFirstPrincipalValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFirstPrincipalValue.Location = new System.Drawing.Point(462, 170);
            this.lblFirstPrincipalValue.Name = "lblFirstPrincipalValue";
            this.lblFirstPrincipalValue.Size = new System.Drawing.Size(151, 23);
            this.lblFirstPrincipalValue.TabIndex = 24;
            this.lblFirstPrincipalValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalInterestValue
            // 
            this.lblTotalInterestValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalInterestValue.Location = new System.Drawing.Point(462, 201);
            this.lblTotalInterestValue.Name = "lblTotalInterestValue";
            this.lblTotalInterestValue.Size = new System.Drawing.Size(151, 23);
            this.lblTotalInterestValue.TabIndex = 25;
            this.lblTotalInterestValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalPaymentValue
            // 
            this.lblTotalPaymentValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalPaymentValue.Location = new System.Drawing.Point(462, 233);
            this.lblTotalPaymentValue.Name = "lblTotalPaymentValue";
            this.lblTotalPaymentValue.Size = new System.Drawing.Size(151, 23);
            this.lblTotalPaymentValue.TabIndex = 26;
            this.lblTotalPaymentValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 339);
            this.Controls.Add(this.lblTotalPaymentValue);
            this.Controls.Add(this.lblTotalInterestValue);
            this.Controls.Add(this.lblFirstPrincipalValue);
            this.Controls.Add(this.lblFirstInterestValue);
            this.Controls.Add(this.lblMonthlyPaymentValue);
            this.Controls.Add(this.lblLoanAmountValue);
            this.Controls.Add(this.lblTotalPayment);
            this.Controls.Add(this.lblTotalInterest);
            this.Controls.Add(this.lblFirstPrincipal);
            this.Controls.Add(this.lblFirstInterest);
            this.Controls.Add(this.lblMonthlyPayment);
            this.Controls.Add(this.lblLoanAmount);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtGraceYears);
            this.Controls.Add(this.txtYears);
            this.Controls.Add(this.txtAnnualRate);
            this.Controls.Add(this.txtDownPaymentAmount);
            this.Controls.Add(this.txtDownPaymentPercent);
            this.Controls.Add(this.txtHousePrice);
            this.Controls.Add(this.lblGraceYears);
            this.Controls.Add(this.lblYears);
            this.Controls.Add(this.lblAnnualRate);
            this.Controls.Add(this.lblDownPaymentAmount);
            this.Controls.Add(this.lblDownPaymentPercent);
            this.Controls.Add(this.lblHousePrice);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "個人房貸試算器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblHousePrice;
        private System.Windows.Forms.Label lblDownPaymentPercent;
        private System.Windows.Forms.Label lblDownPaymentAmount;
        private System.Windows.Forms.Label lblAnnualRate;
        private System.Windows.Forms.Label lblYears;
        private System.Windows.Forms.Label lblGraceYears;
        private System.Windows.Forms.TextBox txtHousePrice;
        private System.Windows.Forms.TextBox txtDownPaymentPercent;
        private System.Windows.Forms.TextBox txtDownPaymentAmount;
        private System.Windows.Forms.TextBox txtAnnualRate;
        private System.Windows.Forms.TextBox txtYears;
        private System.Windows.Forms.TextBox txtGraceYears;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblLoanAmount;
        private System.Windows.Forms.Label lblMonthlyPayment;
        private System.Windows.Forms.Label lblFirstInterest;
        private System.Windows.Forms.Label lblFirstPrincipal;
        private System.Windows.Forms.Label lblTotalInterest;
        private System.Windows.Forms.Label lblTotalPayment;
        private System.Windows.Forms.Label lblLoanAmountValue;
        private System.Windows.Forms.Label lblMonthlyPaymentValue;
        private System.Windows.Forms.Label lblFirstInterestValue;
        private System.Windows.Forms.Label lblFirstPrincipalValue;
        private System.Windows.Forms.Label lblTotalInterestValue;
        private System.Windows.Forms.Label lblTotalPaymentValue;
    }
}