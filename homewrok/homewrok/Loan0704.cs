using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homewrok
{
    public partial class Loan0704 : Form
    {
        public Loan0704()
        {
            InitializeComponent();
        }

        private void btn_PMT_Click(object sender, EventArgs e)
        {
                  
            int LoanPrice = Convert.ToInt32(txt_LoanPrice.Text);
            int Period = Convert.ToInt32(txt_Period.Text);
            float Rate = Convert.ToSingle(txt_Rate.Text)/1200;
            int FirstPay = Convert.ToInt32(txt_FirstPay.Text);
            float Percentage = 1 + Rate;
            float RateDividend = (float)(Math.Pow(Percentage, Period * 12)) *Rate;
            float RatedDivisor = (float)(Math.Pow(Percentage, Period * 12)) -1;
            float MonthRate = RateDividend / RatedDivisor;
            int PMT = Convert.ToInt32((LoanPrice - FirstPay) * MonthRate);
            int Total = PMT * Period * 12;

            MessageBox.Show("月付額:" + PMT + "元");        

}

        private void btn_Payment_Click(object sender, EventArgs e)
        {
            int LoanPrice = Convert.ToInt32(txt_LoanPrice.Text);
            int Period = Convert.ToInt32(txt_Period.Text);
            float Rate = Convert.ToSingle(txt_Rate.Text) / 1200;
            int FirstPay = Convert.ToInt32(txt_FirstPay.Text);
            float Percentage = 1 + Rate;
            float RateDividend = (float)(Math.Pow(Percentage, Period * 12)) * Rate;
            float RatedDivisor = (float)(Math.Pow(Percentage, Period * 12)) - 1;
            float MonthRate = RateDividend / RatedDivisor;
            int PMT = Convert.ToInt32((LoanPrice - FirstPay) * MonthRate);
            int Total = PMT * Period * 12;

            MessageBox.Show("總付款:" + Total + "元");
        }

        private void btn_Report_Click(object sender, EventArgs e)
        {
            Loan0704_Report email= new Loan0704_Report();
            email.Show();
            email.txt_LoanPrice2.Text=txt_LoanPrice.Text;
            email.txt_Period2.Text=txt_Period.Text;
            email.txt_Rate2.Text=txt_Rate.Text;

            int LoanPrice = Convert.ToInt32(txt_LoanPrice.Text);
            int Period = Convert.ToInt32(txt_Period.Text);
            float Rate = Convert.ToSingle(txt_Rate.Text) / 1200;
            int FirstPay = Convert.ToInt32(txt_FirstPay.Text);
            float Percentage = 1 + Rate;
            float RateDividend = (float)(Math.Pow(Percentage, Period * 12)) * Rate;
            float RatedDivisor = (float)(Math.Pow(Percentage, Period * 12)) - 1;
            float MonthRate = RateDividend / RatedDivisor;
            int PMT = Convert.ToInt32((LoanPrice - FirstPay) * MonthRate);
            int Total = PMT * Period * 12;

            email.txt_PMT.Text =Convert.ToString(PMT);
            email.txt_Payment.Text =Convert.ToString(Total);


        }


        private void txt_LoanPrice_Click(object sender, EventArgs e)
        {
            
        }
    }

  
	
}
