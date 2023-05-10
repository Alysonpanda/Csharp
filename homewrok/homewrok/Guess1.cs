using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace homewrok
{

    public partial class Guess1 : Form
    {

        public Guess1(Guess Parentform)
        {
            InitializeComponent();         
            this.Tag = Parentform;           
        }                

        int num, min, max;     
        Random r = new Random();

        private void btn_Enter_Click(object sender, EventArgs e)
        {
            //Guess gu= new Guess();
            if (num == 0)
            {
                //Random r = new Random();
                num = r.Next(1, 100);
                min = 1;
                max = 100;
            }

            //int guess = int.Parse(txt_Num.Text);
            //int guess = 0;
            //bool A = int.TryParse(txt_Num.Text, out guess);

            try
            {
                int guess = int.Parse(txt_Num.Text);
                if (guess == num)
                {
                    MessageBox.Show ($"Congradulations!!! you got {num}!!!");
                    //num = 0;
                }
                else if (guess > num)
                {
                    max = guess;
                    ((Guess)this.Tag).label1.Text = ($"Too big!!! \nbetween {min} and {max}");
                }
                else if (guess < num)
                {
                    min = guess;
                    ((Guess)this.Tag).label1.Text = ($"Too small!!! \n between {min} and {max}");
                }
                else
                {
                    MessageBox.Show($"請輸入{min}~{max}之間的數字。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show($"請輸入{min}~{max}之間的數字。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            //if (A)
            //{
            //    if (guess == num)
            //    {
            //        ((Guess)this.Tag).label1.Text = ($"Congradulations!!! you got {num}!!!");
            //        num = 0;
            //    }
            //    else if (guess > num)
            //    {
            //        max = guess;
            //        ((Guess)this.Tag).label1.Text = ($"Too big!!! \nbetween {min} and {max}");
            //    }
            //    else if (guess < num)
            //    {
            //        min = guess;
            //        ((Guess)this.Tag).label1.Text = ($"Too small!!! \n between {min} and {max}");
            //    }
            //    else
            //    {
            //        MessageBox.Show($"請輸入{min}~{max}之間的數字。","錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }            
        }
        private void btn_CXL_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

        

        //bool A = int.TryParse(txt_Num.Text, out keyin);

        //if (A)
        //{
        //    //Random r = new Random();
        //    //int guess = r.Next(1, 100);
        //    //min = 1;
        //    //max = 100;
        //    //count = 0;
        //    //keyin = 0;

        //    //Random r = new Random();
        //    //num = r.Next(1, 100);

        //    //int i, keyin ,num, min, max;
        //    Random r = new Random();
        //    num = r.Next(1, 100);

        //    for (; ; )
        //    {
        //        int keyin = int.Parse(txt_Num.Text);

        //        if (keyin == num)
        //        {
        //            MessageBox.Show("Congradulations!!!" + "You got" + num + "!!!");
        //        }

        //        else if (i < num)
        //        {
        //            keyin = i;
        //            MessageBox.Show("Too Small!!" + "\nBetween" + int.Parse(txt_Num.Text) + "and" + keyin);
        //        }

        //        else if (i > num)
        //        {
        //            keyin = i;
        //            MessageBox.Show("Too Large!!" + "\nBetween" + int.Parse(txt_Num.Text) + "and" + keyin);
        //        }

        //        return;
        //    }
        //}
    }

    

           

       
    
            
    



