using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace homewrok
{
    public partial class XOGame0716 : Form
    {
        bool turn = true;
        int click = 0;


        public XOGame0716()
        {
            InitializeComponent();
        }



        //bool isX = true;
        //private void Win()
        //{
        //        if (btn1.Text == "X" && btn2.Text == "X" && btn3.Text == "X") MessageBox.Show("X手獲勝!", "完局!");
        //        if (btn4.Text == "X" && btn5.Text == "X" && btn6.Text == "X") MessageBox.Show("X手獲勝!", "完局!");
        //        if (btn7.Text == "X" && btn8.Text == "X" && btn9.Text == "X") MessageBox.Show("X手獲勝!", "完局!");
        //        if (btn1.Text == "X" && btn5.Text == "X" && btn9.Text == "X") MessageBox.Show("X手獲勝!", "完局!");
        //        if (btn3.Text == "X" && btn5.Text == "X" && btn7.Text == "X") MessageBox.Show("X手獲勝!", "完局!");
        //        if (btn1.Text == "X" && btn4.Text == "X" && btn7.Text == "X") MessageBox.Show("X手獲勝!", "完局!");
        //        if (btn2.Text == "X" && btn5.Text == "X" && btn8.Text == "X") MessageBox.Show("X手獲勝!", "完局!");
        //        if (btn3.Text == "X" && btn6.Text == "X" && btn9.Text == "X") MessageBox.Show("X手獲勝!", "完局!");

        //        if (btn1.Text == "O" && btn2.Text == "O" && btn3.Text == "O") MessageBox.Show("O手獲勝!", "完局!");
        //        if (btn4.Text == "O" && btn5.Text == "O" && btn6.Text == "O") MessageBox.Show("O手獲勝!", "完局!");
        //        if (btn7.Text == "O" && btn8.Text == "O" && btn9.Text == "O") MessageBox.Show("O手獲勝!", "完局!");
        //        if (btn1.Text == "O" && btn5.Text == "O" && btn9.Text == "O") MessageBox.Show("O手獲勝!", "完局!");
        //        if (btn3.Text == "O" && btn5.Text == "O" && btn7.Text == "O") MessageBox.Show("O手獲勝!", "完局!");
        //        if (btn1.Text == "O" && btn4.Text == "O" && btn7.Text == "O") MessageBox.Show("O手獲勝!", "完局!");
        //        if (btn2.Text == "O" && btn5.Text == "O" && btn8.Text == "O") MessageBox.Show("O手獲勝!", "完局!");
        //        if (btn3.Text == "O" && btn6.Text == "O" && btn9.Text == "O") MessageBox.Show("O手獲勝!", "完局!");

        //}



        //private void btn1_Click(object sender, EventArgs e)
        //{
        //    if (isX == true)
        //    {
        //        btn1.Text = "X";
        //        isX = false;
        //    }
        //    else
        //    {
        //        btn1.Text = "O";
        //        isX = true;
        //    }
        //    Win(); 

        //}


        //private void btn2_Click(object sender, EventArgs e)
        //{
        //    if (isX == true)
        //    {
        //        btn2.Text = "X";
        //        isX = false;
        //    }
        //    else
        //    {
        //        btn2.Text = "O";
        //        isX = true;
        //    }
        //    Win();

        //}

        //private void btn3_Click(object sender, EventArgs e)
        //{
        //    if (isX == true)
        //    {
        //        btn3.Text = "X";
        //        isX = false;
        //    }
        //    else
        //    {
        //        btn3.Text = "O";
        //        isX = true;
        //    }
        //    Win();

        //}

        //private void btn4_Click(object sender, EventArgs e)
        //{
        //    if (isX == true)
        //    {
        //        btn4.Text = "X";
        //        isX = false;
        //    }
        //    else
        //    {
        //        btn4.Text = "O";
        //        isX = true;
        //    }
        //    Win();


        //}

        //private void btn5_Click(object sender, EventArgs e)
        //{
        //    if (isX == true)
        //    {
        //        btn5.Text = "X";
        //        isX = false;
        //    }
        //    else
        //    {
        //        btn5.Text = "O";
        //        isX = true;
        //    }
        //    Win();

        //}


        private void btn_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            if (turn)
                B.Text = "X";
            else
                B.Text = "O";

            turn = !turn;
            B.Enabled = false;
            click++;
            Winwin();
        }

        private void Winwin()
        {
            bool winner = false;

            if ((btn1.Text == btn2.Text) && (btn2.Text == btn3.Text) && (!btn1.Enabled))
                winner = true;
            else if ((btn4.Text == btn5.Text) && (btn5.Text == btn6.Text) && (!btn4.Enabled))
                winner = true;
            else if ((btn7.Text == btn8.Text) && (btn8.Text == btn9.Text) && (!btn7.Enabled))
                winner = true;

            else if ((btn1.Text == btn4.Text) && (btn4.Text == btn7.Text) && (!btn1.Enabled))
                winner = true;
            else if ((btn2.Text == btn5.Text) && (btn5.Text == btn8.Text) && (!btn2.Enabled))
                winner = true;
            else if ((btn3.Text == btn6.Text) && (btn6.Text == btn9.Text) && (!btn3.Enabled))
                winner = true;

            else if ((btn1.Text == btn5.Text) && (btn5.Text == btn9.Text) && (!btn1.Enabled))
                winner = true;
            else if ((btn3.Text == btn5.Text) && (btn5.Text == btn7.Text) && (!btn3.Enabled))
                winner = true;


            if (winner)
            {

                string w = "";
                if (turn)
                    w = "O";
                else
                    w = "X";
                MessageBox.Show(w + "手獲勝!", "完局!");
                Reset();
            }

            else
            {
                if (click == 9)
                    MessageBox.Show("平手!按下確定重新開始", "完局!");
                if (click == 9)
                    Reset();
            }

        }
        private void DisableButtons()
        {
            try
            {
                foreach (Control C in Controls)
                {
                    Button B = (Button)C;
                    B.Enabled = false;
                }
            }
            catch { }

        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            turn = true;
            click = 0;
            try
            {
                foreach (Control C in Controls)
                {
                    Button B = (Button)C;
                    B.Enabled = true;
                    btn1.Text = "";
                    btn2.Text = "";
                    btn3.Text = "";
                    btn4.Text = "";
                    btn5.Text = "";
                    btn6.Text = "";
                    btn7.Text = "";
                    btn8.Text = "";
                    btn9.Text = "";
                }
            }
            catch { }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Reset()
        {
            turn = true;
            click = 0;
          
                    //Button B = (Button)C;
                    //B.Enabled = true;
                    btn1.Enabled = true;
                    btn2.Enabled = true;
                    btn3.Enabled = true;
                    btn4.Enabled = true;
                    btn5.Enabled = true;
                    btn6.Enabled = true;
                    btn7.Enabled = true;
                    btn8.Enabled = true;
                    btn9.Enabled = true;
                    btn1.Text = "";
                    btn2.Text = "";
                    btn3.Text = "";
                    btn4.Text = "";
                    btn5.Text = "";
                    btn6.Text = "";
                    btn7.Text = "";
                    btn8.Text = "";
                    btn9.Text = "";
               
        }

        private void XOGame0716_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape) 
            {
            this.btn_Exit_Click(sender, e);
            }
            if(e.KeyCode == Keys.R)
            {
            this.btn_Reset_Click(sender, e);
            }
        }
    }
}

    


