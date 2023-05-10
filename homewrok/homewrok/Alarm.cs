using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace homewrok
{
    public partial class Alarm : Form
    {
      
        public Alarm()
        {
            InitializeComponent();
        }

        private void Alarm_Load(object sender, EventArgs e)
        {            
            timer1.Start();

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            int h, m, s;
            int.TryParse(txt_H.Text, out h);
            int.TryParse(txt_M.Text, out m);
            int.TryParse(txt_S.Text, out s);

            DateTime time = DateTime.Now;
            label1.Text = DateTime.Now.ToString("HH:mm:ss");

            if (time.Hour == h && time.Minute == m && time.Second == s&&cB_Set.Checked)
            {
                //cB_Set.Checked = false;               
                //MessageBox.Show("時辰到惹！");
                cB_Set.Checked = false;
                DialogResult result = MessageBox.Show("時辰到惹！", "", MessageBoxButtons.OK);
                
                if (result == DialogResult.OK)
                {
                    this.BackgroundImage = Properties.Resources.朴寶劍2;
                    //    this.BackgroundImage = Properties.Resources.朴寶劍8;
                    /*Image.FromFile("C:\\Users\\User\\Desktop\\1朴寶劍.jpg");*/
                }


            }
        }
    }
    }

