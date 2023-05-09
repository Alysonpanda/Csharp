using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homewrok
{
    public partial class DoForWhile0712 : Form
    {
        public DoForWhile0712()
        {
            InitializeComponent();
        }

        private void btn_Tree_Click(object sender, EventArgs e)
        {
            bool A = int.TryParse(txt_Row.Text, out i);

            if (A)
            {
                int row = int.Parse(txt_Row.Text);
                string result = "";

                for (int i = 1; i <= row; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        result += "*";
                    }
                    result += "\n";
                }
                lab_Result.Text = result;
            }
            else
            {
                MessageBox.Show("請輸入數值");
            }

        }


        private void btn_Lottery_Click(object sender, EventArgs e)
        {
            int[] arr = new int[6];
            Random r = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(1, 49);

                for (int j = 0; j < i; j++)
                {
                    while (arr[j] == arr[i])
                    {
                        j = 0;
                        arr[i] = r.Next(1, 49);
                    }
                }

                lab_Result.Text = ("樂透號碼\n " +
                                               arr[0].ToString() + "、" +
                                               arr[1].ToString() + "、" +
                                               arr[2].ToString() + "、" +
                                               arr[3].ToString() + "、" +
                                               arr[4].ToString() + "、" +
                                               arr[5].ToString());
            }


            {
                //arr[i] = r.Next(1, 49);
                //for (int j = 0; j < i; j++)
                //{
                //    while (arr[j] == arr[i])
                //    {
                //        j = 0;
                //        arr[i] = r.Next(1, 49);

                //    }
                //}

            }
        }

        private void btn_99_Click(object sender, EventArgs e)
        {
            string result = "";
            for (int i = 2; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    result = result + $"{i}x{j} ={i * j}\t       ";
                }
                result = result + "\r\n";
            }
            lab_Result.Text = result;
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            lab_Result.Text = "結果";
        }



        private void btn_ArrayMin_Click(object sender, EventArgs e)
        {
            int[] arr = new int[10] { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
            int max = arr[0];
            int min = arr[0];
            int sum = 0;

            foreach (int i in arr)
            {
                if (i > max)
                {
                    max = i;
                }

                if (i < min)
                {
                    min = i;
                }
                sum = sum + i;
            }

            lab_Result.Text = "int陣列arr0711[ 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 ]" + "\n" + "最小值為" + min;

        }

        private void btn_ArrayMax_Click(object sender, EventArgs e)
        {
            int[] arr = new int[10] { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
            int max = arr[0];
            int min = arr[0];
            int sum = 0;

            foreach (int i in arr)
            {
                if (i > max)
                {
                    max = i;
                }

                if (i < min)
                {
                    min = i;
                }
                sum = sum + i;
            }

            lab_Result.Text = "int陣列arr0711[ 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 ]" + "\n" + "最小值為" + max;
        }






        private void btn_ArraySum_Click(object sender, EventArgs e)
        {
            int[] arr = new int[10] { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
            int max = arr[0];
            int min = arr[0];
            int sum = 0;

            foreach (int i in arr)
            {
                if (i > max)
                {
                    max = i;
                }

                if (i < min)
                {
                    min = i;
                }
                sum = sum + i;
            }

            lab_Result.Text = "int陣列arr0711[ 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 ]" + "\n" + "加總為" + sum;
        }

        private void btn_ArrayMaxMin(object sender, EventArgs e)
        {
            int[] arr = new int[10] { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
            int max = arr[0];
            int min = arr[0];
            int sum = 0;

            foreach (int i in arr)
            {
                if (i > max)
                {
                    max = i;
                }

                if (i < min)
                {
                    min = i;
                }
                sum = sum + i;
            }

            lab_Result.Text = "int陣列arr0711[ 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 ]" + "\n" + "最大值為" + max + "\n" + "最小值為" + min;
        }

        private void btn_Odd_Click(object sender, EventArgs e)
        {
            int[] arr = new int[10] { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
            int i;
            int odd = 0, even = 0;

            for (i = 0; i < arr.Length; i++)
            {
                if ((arr[i] % 2) == 0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
                lab_Result.Text = "int陣列arr0711[ 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 ]" + "\n" +
                       "奇數共" + odd + "\n" + "偶數共" + even;
            }

        }
        //int i = int.Parse(txt_Num.Text);
        int i;
        string result = "";
        private void btn_OddOrEven_Click(object sender, EventArgs e)
        {
            bool A = int.TryParse(txt_Num.Text, out i);
            if (A)
            {
                int odd = 0, even = 0;
                string result;

                if ((i % 2) == 0)
                {
                    i = even;
                    result = "偶數";
                }
                else
                {
                    i = odd;
                    result = "奇數";
                }
                lab_Result.Text = "輸入的數" + txt_Num.Text + "為" + result + "。";
            }
            else
            {
                MessageBox.Show("請輸入數值");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[,] array = new int[10, 10];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (i == 0 || i == array.GetLength(0) - 1 || j == 0 || j == array.GetLength(1) - 1) 
                    {
                        array[i, j] = 1;
                    }
                    else 
                    {
                        array[i, j] = 0;
                    }
                }
            }

            string labelText = "";

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    labelText += array[i, j].ToString();
                }
                labelText += "\n";
            }
            lab_Result.Text = labelText; 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[,] array = new int[10, 10];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (i == 0 || i == array.GetLength(0) - 1 || j == 0 || j == array.GetLength(1) - 1)
                    {
                        array[i, j] = 0;
                    }
                    else
                    {
                        array[i, j] = 1;
                    }
                }
            }

            string labelText = "";

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    labelText += array[i, j].ToString();
                }
                labelText += "\n";
            }
            lab_Result.Text = labelText; 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string[] name = new string[] { "mother張", "emma", "迪克蕭", "J40", "Candy", "Cindy", "Coconut", "MotherFacker" };
            int count = 0;
            foreach (string str in name)
            {
                if (str.ToLower().Contains("c"))
                {
                    count++;
                }
            }
            lab_Result.Text = "arr0711_Str陣列:mother張   emma  迪克蕭  J40  Candy  Cindy  Coconut  MotherFacker" + "\n"
                + "有C及c的名字共有" + count.ToString() + "個";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string[] name = new string[] { "mother張", "emma", "迪克蕭", "J40" };
            string longestName = "";

            foreach (string str in name)
            {
                if (str.Length > longestName.Length)
                {
                    longestName = str;
                }
            }

            lab_Result.Text = "arr0711_Str陣列  [mother張   emma  迪克蕭  J40  ]" + "\n"
                + "最長的名字為" + longestName;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int[,] arr = new int[10, 10];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = ((i + j) % 2);
                }
            }

            string labelText = "";

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    labelText += arr[i, j].ToString();
                }
                labelText += "\n";
            }

            lab_Result.Text = labelText;
        }


        void Swap(ref int A , ref int B)
        { 
           int T = A;
            A = B;
            B = T;            
        }
      
        private void btn_Swap_Click(object sender, EventArgs e)
        {
            int a = 100, b = 200;
            lab_Result.Text = ($"換位前n1={a} , n2={b}" + "\n");

            Swap(ref a, ref b); 
            lab_Result.Text += ($"換位後n1={a} , n2={b}");
        }

        private void btn_100_Click(object sender, EventArgs e)
        {                 
            string binary =Convert.ToString( 100, 2);
            lab_Result.Text =binary;
        }
    }
    }
    
    


    

      
  
        
    


        
    

