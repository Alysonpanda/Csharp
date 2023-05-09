using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace homewrok
{
    public partial class MyCalc0711 : Form
    {
        public MyCalc0711()
        {
            InitializeComponent();
        }


        double Num1, Num2;
        private void btn_Add_Click(object sender, EventArgs e)
        {
            bool A = double.TryParse(txt_Num1.Text, out Num1);
            bool B = double.TryParse(txt_Num2.Text, out Num2);

            if (A&&B)
            {
                double Num1 = Convert.ToDouble(txt_Num1.Text);
                double Num2 = Convert.ToDouble(txt_Num2.Text);
                txt_Ans.Text = (Num1 + Num2).ToString();
            }
            else
            {
                MessageBox.Show("請輸入數值。");
            }   

        }
            
        private void btn_Sub_Click(object sender, EventArgs e)
        {
            bool A = double.TryParse(txt_Num1.Text, out Num1);
            bool B = double.TryParse(txt_Num2.Text, out Num2);

            if (A && B)
            {
                double Num1 = Convert.ToDouble(txt_Num1.Text);
                double Num2 = Convert.ToDouble(txt_Num2.Text);
                txt_Ans.Text = (Num1 - Num2).ToString();
            }
            else
            {
                MessageBox.Show("請輸入數值。");
            }
        }

        private void btn_Mul_Click(object sender, EventArgs e)
        {
            bool A = double.TryParse(txt_Num1.Text, out Num1);
            bool B = double.TryParse(txt_Num2.Text, out Num2);

            if (A && B)
            {
                double Num1 = Convert.ToDouble(txt_Num1.Text);
                double Num2 = Convert.ToDouble(txt_Num2.Text);
                txt_Ans.Text = (Num1 * Num2).ToString();
            }
            else
            {
                MessageBox.Show("請輸入數值。");
            }
        }

        private void btn_Div_Click(object sender, EventArgs e)
        {
            bool A = double.TryParse(txt_Num1.Text, out Num1);
            bool B = double.TryParse(txt_Num2.Text, out Num2);

            if (A && B)
            {
                double Num1 = Convert.ToDouble(txt_Num1.Text);
                double Num2 = Convert.ToDouble(txt_Num2.Text);
                txt_Ans.Text = (Num1 / Num2).ToString();
            }
            else
            {
                MessageBox.Show("請輸入數值。");
            }
        }
    }
}
