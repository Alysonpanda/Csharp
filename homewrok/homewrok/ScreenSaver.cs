using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homewrok
{
    public partial class ScreenSaver : Form
    {
        private int xSpeed =2;
        private int ySpeed =2;
        private const int TIMER_INTERVAL_MS = 2;      

        public ScreenSaver()
        {
            InitializeComponent();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();
            timer1.Interval = TIMER_INTERVAL_MS;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int newX = pictureBox1.Location.X + xSpeed;
            int newY = pictureBox1.Location.Y + ySpeed;
            
            if (newX <= 0 || newX + pictureBox1.Width >= ClientRectangle.Width)
            {
                xSpeed = -xSpeed;
            }
           
            if (newY <= 0 || newY + pictureBox1.Height >= ClientRectangle.Height)
            {
                ySpeed = -ySpeed;
            }
         
            pictureBox1.Location = new Point(newX, newY);
        }

        private void ScreenSaver_KeyDown(object sender, KeyEventArgs e)
        {
            Close();
        }
    }


}




