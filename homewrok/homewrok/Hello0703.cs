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
    public partial class Hello0703 : Form
    {
        public Hello0703()
        {
            InitializeComponent();
        }

        private void btn_SayHello_Click(object sender, EventArgs e)
        {
            string Name= txt_Name.Text;
            string EngName= txt_EngName.Text;
            string Sex = txt_Sex.Text;
            string Const= txt_Const.Text;
            MessageBox.Show("Hello,"+ Environment.NewLine +
                "我是" + Name+ Environment.NewLine+
                "英文名字是" + EngName+ Environment.NewLine+
                "性別是" + Sex+ Environment.NewLine+
                "星座是"  + Const+ Environment.NewLine+
                "很高興認識你。");
        }

        private void btn_SayHI_Click(object sender, EventArgs e)
        {
            string Name = txt_Name.Text;
            string EngName = txt_EngName.Text;
            string Sex = txt_Sex.Text;
            string Const = txt_Const.Text;
            MessageBox.Show("Hi," + Environment.NewLine +
                "我是" + Name + Environment.NewLine +
                "英文名字是" + EngName + Environment.NewLine +
                "性別是" + Sex + Environment.NewLine +
                "星座是" + Const + Environment.NewLine +
                "很高興認識你。");
        }
    }
}
