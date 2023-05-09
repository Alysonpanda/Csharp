using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.InteropServices.ComTypes;

namespace homewrok
{

    public partial class DrawPaint : Form
    {
        Graphics G;
        Pen pen;
        bool isMouseDown = false;       
        List<Point> points = new List<Point>();

        public DrawPaint()
        {
            InitializeComponent();
            G = this.CreateGraphics();
            pen = new Pen(Color.Black, 1);
        }

        private void btn_color_Click(object sender, EventArgs e)
        {
            ColorDialog CD = new ColorDialog();
            CD.Color = panel1.BackColor;
            if (CD.ShowDialog() == DialogResult.OK)
            panel1.BackColor = CD.Color;
            pen.Color = CD.Color;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int Value = trackBar1.Value;
            label1.Text = Convert.ToString(Value);
        }               

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            int trackBarValue = trackBar1.Value;
            pen.Width = trackBarValue;
        }

        private void DrawPaint_MouseDown_1(object sender, MouseEventArgs e)
        {
            isMouseDown = true; 
            points.Add(e.Location); 
        }

        private void DrawPaint_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown) 
            {
                points.Add(e.Location);
                G.DrawLine(pen, points[points.Count - 2], points[points.Count - 1]);
            }
        }

        private void DrawPaint_MouseUp(object sender, MouseEventArgs e)
        {
            points.Add(new Point(-1, -1));
            isMouseDown = false; 
        }

        private void btn__Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void DrawPaint_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Black;
        }
    }
    

}
    


