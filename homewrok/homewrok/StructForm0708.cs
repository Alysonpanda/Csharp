using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Schema;
using static homewrok.Program;

namespace homewrok
{
    public partial class StructForm0708 : Form
    {
        public StructForm0708()
        {
            InitializeComponent();
        }

        //int Chi, Eng, Math, Max, Min;

        private void btn_Save_Click(object sender, EventArgs e)
        {
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            Score sc = new Score();
            //Name = "txt.Name";
            //Chi = int.Parse(txt_Chi.Text);
            //Eng = int.Parse(txt_Eng.Text);
            //Math = int.Parse(txt_Math.Text);
            //lab_Score1.Text= "姓名：" + (txt_Name.Text) +
            //    "\n國文：" + (txt_Chi.Text) + "分" +
            //    "\n英文：" + (txt_Eng.Text) + "分" +
            //    "\n數學：" + (txt_Math.Text) + "分";
            this.btn_ShowSave.Click += new System.EventHandler(this.btn_ShowSave_Click);
        }

        private void btn_ShowSave_Click(object sender, EventArgs e)
        {
         //this.btn_ShowSave.Click += new System.EventHandler(this.btn_ShowSave_Click);
            this.btn_ShowSave.Click -= new System.EventHandler(this.btn_ShowSave_Click);
            lab_Score1.Text = "姓名：" + (txt_Name.Text) +
                "\n國文：" + (txt_Chi.Text) + "分" +
                "\n英文：" + (txt_Eng.Text) + "分" +
                "\n數學：" + (txt_Math.Text) + "分";
            
        }
      
        private void btn_Score_Click(object sender, EventArgs e)
        {
          
            int Chi = int.Parse(txt_Chi.Text);
            int Eng = int.Parse(txt_Eng.Text);
            int Math = int.Parse(txt_Math.Text);

            int[] score = new int[] { Chi, Eng, Math };
            string[] subject = new string[] { "國文", "英文", "數學" };
            string maxname = subject[0];
            string minname = subject[0];

            int Max = score[0];
            int Min = score[0];

            for (int i = 1; i < score.Length; i++)
            {
                if (score[i] > Max)
                {
                    Max = score[i];
                    maxname = subject[i];
                }

                if (score[i] < Min)
                {
                    Min = score[i];
                    minname = subject[i];
                }

                lab_Score2.Text = "最高科目成績為" + maxname + Max + "分" +
             "\n最低科目成績為" + minname + Min + "分";


            }



            //Chi=int.Parse(txt_Chi.Text);
            //Eng = int.Parse(txt_Eng.Text); 
            //Math = int.Parse(txt_Math.Text);

            //Max=Chi > Eng ? (Chi > Math ? Chi : Math) : (Eng > Math ? Eng : Math);
            //Min = Chi < Eng ? (Chi < Math ? Chi : Math) : (Eng < Math ? Eng : Math);

            //Max = Chi > Eng ? Chi : Eng;
            //Max= Eng > Math ? Eng : Math;
            //Max= Math > Chi ? Math : Chi;

            //Min = Chi > Eng ? Eng : Chi;
            //Min= Eng > Math ? Math :Eng;
            //Min = Math > Chi ? Chi : Math;

            //lab_Score2.Text = "最高科目成績為"+ Max + "分"+
            //"\n最低科目成績為" + Min + "分";

        }



    }



}        



        
    





