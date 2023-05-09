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
    public partial class PictureViewer : Form
    {
        public PictureViewer()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form form = new Form();
            form.FormBorderStyle = FormBorderStyle.Sizable;
            form.Size = new Size(600, 400);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MaximizeBox = false;
            form.MinimizeBox = false;

            PictureBox pictureBox = new PictureBox();
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.Image = pictureBox1.Image;
                       
            form.Controls.Add(pictureBox);

            form.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form form2 = new Form();
            form2.FormBorderStyle = FormBorderStyle.Sizable;
            form2.Size = new Size(600, 400);
            form2.StartPosition = FormStartPosition.CenterScreen;
            form2.MaximizeBox = false;
            form2.MinimizeBox = false;

            PictureBox pictureBox = new PictureBox();
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.Image = pictureBox2.Image;

            form2.Controls.Add(pictureBox);

            form2.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form form3 = new Form();
            form3.FormBorderStyle = FormBorderStyle.Sizable;
            form3.Size = new Size(600, 400);
            form3.StartPosition = FormStartPosition.CenterScreen;
            form3.MaximizeBox = false;
            form3.MinimizeBox = false;

            PictureBox pictureBox = new PictureBox();
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.Image = pictureBox3.Image;

            form3.Controls.Add(pictureBox);

            form3.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form form4 = new Form();
            form4.FormBorderStyle = FormBorderStyle.Sizable;
            form4.Size = new Size(600, 400);
            form4.StartPosition = FormStartPosition.CenterScreen;
            form4.MaximizeBox = false;
            form4.MinimizeBox = false;

            PictureBox pictureBox = new PictureBox();
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.Image = pictureBox4.Image;

            form4.Controls.Add(pictureBox);

            form4.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form form5 = new Form();
            form5.FormBorderStyle = FormBorderStyle.Sizable;
            form5.Size = new Size(600, 400);
            form5.StartPosition = FormStartPosition.CenterScreen;
            form5.MaximizeBox = false;
            form5.MinimizeBox = false;

            PictureBox pictureBox = new PictureBox();
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.Image = pictureBox5.Image;

            form5.Controls.Add(pictureBox);

            form5.Show();
        }
    }
}
