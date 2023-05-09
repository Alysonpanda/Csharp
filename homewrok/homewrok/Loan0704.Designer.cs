namespace homewrok
{
    partial class Loan0704
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
            this.lab_LoanPrice = new System.Windows.Forms.Label();
            this.lab_Period = new System.Windows.Forms.Label();
            this.lab_Rate = new System.Windows.Forms.Label();
            this.lab_FirstPay = new System.Windows.Forms.Label();
            this.txt_Rate = new System.Windows.Forms.TextBox();
            this.txt_Period = new System.Windows.Forms.TextBox();
            this.txt_FirstPay = new System.Windows.Forms.TextBox();
            this.txt_LoanPrice = new System.Windows.Forms.TextBox();
            this.btn_PMT = new System.Windows.Forms.Button();
            this.btn_Payment = new System.Windows.Forms.Button();
            this.btn_Report = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lab_LoanPrice
            // 
            this.lab_LoanPrice.AutoSize = true;
            this.lab_LoanPrice.BackColor = System.Drawing.Color.Transparent;
            this.lab_LoanPrice.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_LoanPrice.ForeColor = System.Drawing.Color.Salmon;
            this.lab_LoanPrice.Location = new System.Drawing.Point(87, 53);
            this.lab_LoanPrice.Name = "lab_LoanPrice";
            this.lab_LoanPrice.Size = new System.Drawing.Size(86, 24);
            this.lab_LoanPrice.TabIndex = 0;
            this.lab_LoanPrice.Text = "貸款金額";
            // 
            // lab_Period
            // 
            this.lab_Period.AutoSize = true;
            this.lab_Period.BackColor = System.Drawing.Color.Transparent;
            this.lab_Period.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_Period.ForeColor = System.Drawing.Color.Salmon;
            this.lab_Period.Location = new System.Drawing.Point(87, 111);
            this.lab_Period.Name = "lab_Period";
            this.lab_Period.Size = new System.Drawing.Size(79, 24);
            this.lab_Period.TabIndex = 1;
            this.lab_Period.Text = "期限(年)";
            // 
            // lab_Rate
            // 
            this.lab_Rate.AutoSize = true;
            this.lab_Rate.BackColor = System.Drawing.Color.Transparent;
            this.lab_Rate.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_Rate.ForeColor = System.Drawing.Color.Salmon;
            this.lab_Rate.Location = new System.Drawing.Point(90, 165);
            this.lab_Rate.Name = "lab_Rate";
            this.lab_Rate.Size = new System.Drawing.Size(65, 24);
            this.lab_Rate.TabIndex = 2;
            this.lab_Rate.Text = "利率%";
            // 
            // lab_FirstPay
            // 
            this.lab_FirstPay.AutoSize = true;
            this.lab_FirstPay.BackColor = System.Drawing.Color.Transparent;
            this.lab_FirstPay.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_FirstPay.ForeColor = System.Drawing.Color.Salmon;
            this.lab_FirstPay.Location = new System.Drawing.Point(87, 216);
            this.lab_FirstPay.Name = "lab_FirstPay";
            this.lab_FirstPay.Size = new System.Drawing.Size(67, 24);
            this.lab_FirstPay.TabIndex = 3;
            this.lab_FirstPay.Text = "頭期款";
            // 
            // txt_Rate
            // 
            this.txt_Rate.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_Rate.ForeColor = System.Drawing.Color.Tomato;
            this.txt_Rate.Location = new System.Drawing.Point(181, 159);
            this.txt_Rate.Name = "txt_Rate";
            this.txt_Rate.Size = new System.Drawing.Size(100, 32);
            this.txt_Rate.TabIndex = 4;
            this.txt_Rate.Text = "10";
            // 
            // txt_Period
            // 
            this.txt_Period.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_Period.ForeColor = System.Drawing.Color.Tomato;
            this.txt_Period.Location = new System.Drawing.Point(181, 105);
            this.txt_Period.Name = "txt_Period";
            this.txt_Period.Size = new System.Drawing.Size(100, 32);
            this.txt_Period.TabIndex = 5;
            this.txt_Period.Text = "2";
            // 
            // txt_FirstPay
            // 
            this.txt_FirstPay.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_FirstPay.ForeColor = System.Drawing.Color.Tomato;
            this.txt_FirstPay.Location = new System.Drawing.Point(181, 216);
            this.txt_FirstPay.Name = "txt_FirstPay";
            this.txt_FirstPay.Size = new System.Drawing.Size(100, 32);
            this.txt_FirstPay.TabIndex = 6;
            this.txt_FirstPay.Text = "0";
            // 
            // txt_LoanPrice
            // 
            this.txt_LoanPrice.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_LoanPrice.ForeColor = System.Drawing.Color.Tomato;
            this.txt_LoanPrice.Location = new System.Drawing.Point(181, 51);
            this.txt_LoanPrice.Name = "txt_LoanPrice";
            this.txt_LoanPrice.Size = new System.Drawing.Size(100, 32);
            this.txt_LoanPrice.TabIndex = 7;
            this.txt_LoanPrice.Text = "100000";
            this.txt_LoanPrice.Click += new System.EventHandler(this.txt_LoanPrice_Click);
            // 
            // btn_PMT
            // 
            this.btn_PMT.BackColor = System.Drawing.Color.Linen;
            this.btn_PMT.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_PMT.ForeColor = System.Drawing.Color.Salmon;
            this.btn_PMT.Location = new System.Drawing.Point(23, 269);
            this.btn_PMT.Name = "btn_PMT";
            this.btn_PMT.Size = new System.Drawing.Size(109, 41);
            this.btn_PMT.TabIndex = 8;
            this.btn_PMT.Text = "PMT(月付)";
            this.btn_PMT.UseVisualStyleBackColor = false;
            this.btn_PMT.Click += new System.EventHandler(this.btn_PMT_Click);
            // 
            // btn_Payment
            // 
            this.btn_Payment.BackColor = System.Drawing.Color.Linen;
            this.btn_Payment.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Payment.ForeColor = System.Drawing.Color.Salmon;
            this.btn_Payment.Location = new System.Drawing.Point(145, 269);
            this.btn_Payment.Name = "btn_Payment";
            this.btn_Payment.Size = new System.Drawing.Size(85, 41);
            this.btn_Payment.TabIndex = 9;
            this.btn_Payment.Text = "總付款";
            this.btn_Payment.UseVisualStyleBackColor = false;
            this.btn_Payment.Click += new System.EventHandler(this.btn_Payment_Click);
            // 
            // btn_Report
            // 
            this.btn_Report.BackColor = System.Drawing.Color.Linen;
            this.btn_Report.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Report.ForeColor = System.Drawing.Color.Salmon;
            this.btn_Report.Location = new System.Drawing.Point(244, 269);
            this.btn_Report.Name = "btn_Report";
            this.btn_Report.Size = new System.Drawing.Size(100, 41);
            this.btn_Report.TabIndex = 10;
            this.btn_Report.Text = "Report";
            this.btn_Report.UseVisualStyleBackColor = false;
            this.btn_Report.Click += new System.EventHandler(this.btn_Report_Click);
            // 
            // Loan0704
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::homewrok.Properties.Resources.pandamilktea;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(654, 375);
            this.Controls.Add(this.btn_Report);
            this.Controls.Add(this.btn_Payment);
            this.Controls.Add(this.btn_PMT);
            this.Controls.Add(this.txt_LoanPrice);
            this.Controls.Add(this.txt_FirstPay);
            this.Controls.Add(this.txt_Period);
            this.Controls.Add(this.txt_Rate);
            this.Controls.Add(this.lab_FirstPay);
            this.Controls.Add(this.lab_Rate);
            this.Controls.Add(this.lab_Period);
            this.Controls.Add(this.lab_LoanPrice);
            this.Name = "Loan0704";
            this.Text = "貸款金額計算";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_LoanPrice;
        private System.Windows.Forms.Label lab_Period;
        private System.Windows.Forms.Label lab_Rate;
        private System.Windows.Forms.Label lab_FirstPay;
        private System.Windows.Forms.TextBox txt_Rate;
        private System.Windows.Forms.TextBox txt_Period;
        private System.Windows.Forms.TextBox txt_FirstPay;
        private System.Windows.Forms.TextBox txt_LoanPrice;
        private System.Windows.Forms.Button btn_PMT;
        private System.Windows.Forms.Button btn_Payment;
        private System.Windows.Forms.Button btn_Report;
    }
}