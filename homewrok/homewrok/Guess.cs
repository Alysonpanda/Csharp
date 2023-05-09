using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace homewrok
{
    public partial class Guess : Form
    {
        public Guess()
        {
            InitializeComponent();
        }

        private void btn_Guess_Click(object sender, EventArgs e)
        {
            Guess1 gu = new Guess1();
            gu.ShowDialog();
            
            this.label1.Text = $"Please Select A Number Between {min} To {max}!";
        }

        
        private void btn_Ans_Click(object sender, EventArgs e)
        {
            Random r=new Random();
            int ranNum =r.Next(1,100);
            MessageBox.Show("Answer: " + ranNum);
        }


    }
}
