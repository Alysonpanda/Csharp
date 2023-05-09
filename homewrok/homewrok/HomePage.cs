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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }
               
        private void button1_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Hello0703 hello=new Hello0703();
            hello.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(hello);
            hello.Show();              
        }

        private void btn_Loan_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Loan0704 loan = new Loan0704();
            loan.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(loan);
            loan.Show();

           
        }

        private void btn_POS_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            POS0705 pos = new POS0705();
            pos.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(pos);
            pos.Show();
        }

        private void btn_Student_Struct_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            StructForm0708 structform = new StructForm0708();
            structform.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(structform);
            structform.Show();
        }

        private void btn_MyCalc_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            MyCalc0711 cal = new MyCalc0711();
            cal.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(cal);
            cal.Show();
        }

        private void btn_For_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            ForDoWhile0712 fordo = new ForDoWhile0712();
            fordo.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(fordo);
            fordo.Show();
        }

        private void btn_Xo_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            XOGame0716 xo = new XOGame0716();
            xo.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(xo);
            xo.Show();
        }

        private void btn_Note_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Notepad0718 note = new Notepad0718();
            note.TopLevel = true;
            //splitContainer2.Panel2.Controls.Add(note);
            note.Show();
        }

        private void btn_Pic_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            PictureViewer pic = new PictureViewer();
            pic.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(pic);
            pic.Show();
        }

        private void btn_Draw_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            DrawPaint draw = new DrawPaint();
            draw.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(draw);
            draw.Show();
        }

        private void btn_Alarm_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Alarm alarm = new Alarm();
            alarm.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(alarm);
            alarm.Show();
        }

        private void btn_Screen_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            ScreenSaver screen = new ScreenSaver();
            screen.TopLevel =true;           
            screen.Show();
        }

        private void btn_Guess_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Guess guess = new Guess();
            guess.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(guess);
            guess.Show();
        }
    }
}
