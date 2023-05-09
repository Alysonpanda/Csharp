using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homewrok
{
    public partial class Notepad0718 : Form
    {
        public Notepad0718()
        {
            InitializeComponent();
        }

        private void 開啟OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Title = "開啟";
            OFD.InitialDirectory = @"C:\Users\hp\Desktop";
            OFD.Multiselect = true;
            OFD.Filter = @"C:\Users\Desktop(*.txt)|txt|文字文件(*.*)|*.*";
            //OFD.Filter = "文件|*.txt|所有檔案|*.*";
            OFD.ShowDialog();

            StreamReader strRead = new StreamReader(@"C:\Users\User\Desktop\1.txt", Encoding.UTF8);
            richTextBox1.Text = strRead.ReadToEnd();
            strRead.Close();
        }

        private void 開啟OToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Title = "開啟";
            OFD.InitialDirectory = @"C:\\Users\\Desktop";
            OFD.Multiselect = true;
            OFD.Filter = @"C:\Users\hp\Desktop(*.txt)|txt|文字文件(*.*)|*.*";
            //OFD.Filter = "文件|*.txt|所有檔案|*.*";
            OFD.ShowDialog();

            StreamReader strRead = new StreamReader(@"C:\Users\User\Desktop\1.txt", Encoding.UTF8);
            richTextBox1.Text = strRead.ReadToEnd();
            strRead.Close();
        }

        private void 結束XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Title = "結束";
            this.Close();
        }

        private void 剪下TToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }
  private void 剪下UToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }
        private void 複製CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void 複製CToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void 貼上PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void 貼上PToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void 全選AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void 顏色CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog CD = new ColorDialog();
            CD.ShowDialog();
            richTextBox1.ForeColor = CD.Color;
        }

        private void 字型VToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog FD = new FontDialog();
            FD.ShowDialog();
            richTextBox1.Font = FD.Font;
        }

        private void toUpperUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string str = richTextBox1.Text;
            string nstr = str.ToUpper();
            richTextBox1.Text = nstr;
        }

        private void toLowerLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string str = richTextBox1.Text;
            string nstr = str.ToLower();
            richTextBox1.Text = nstr;
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Red;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Green;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Blue;
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Black;
        }

        private void 關於AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 AB = new AboutBox1();
            AB.ShowDialog();
        }

        private void 說明LToolStripButton_Click(object sender, EventArgs e)
        {
            AboutBox1 AB = new AboutBox1();
            AB.ShowDialog();
        }

        private void Notepad0718_Load(object sender, EventArgs e)
        {
           timer1.Start();
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            lab_Time.Text = DateTime.Now.ToString("tt hh:mm:ss");
        }
    }
    }

