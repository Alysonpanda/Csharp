using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace homewrok
{
    public partial class POS0705 : Form
    {
        public POS0705()
        {
            InitializeComponent();
        }

        public static int StaticNum { get; private set; }

        int Price = 0;
        int Discount = 0;
        int Beer, Tequila, Whisky, Wine;
        string Show,SBeer, STequila, SWhisky, SWine;

        private void btn_Cxl_Click(object sender, EventArgs e)
        {
            richTextBox1.Text =Show= "尚未點餐";
            txt_Price.Text = "NT$";  
            Price = 0;
            Beer = 0;
            Tequila = 0;
            Whisky = 0;
            Wine= 0;
            Show = SBeer + STequila + SWhisky + SWine;
            SBeer = "";
            STequila = "";
            SWhisky = "";
            SWine = "";           
        }

        private void btn_Wine_Click(object sender, EventArgs e)
        {
            Price += 320;
            txt_Price.Text = "NT$" + Price;
            Wine += 1;
            SWine = "紅酒Wine x" + Wine + "共NT$" + Convert.ToString(320 * Wine) + "元\n";
            Show = SBeer + STequila + SWhisky + SWine;
            richTextBox1.Text = Show;
        }

        private void btn_Beer_Click(object sender, EventArgs e)
        {
            Price+=120;
            txt_Price.Text = "NT$" + Price;
            Beer += 1;
            SBeer="啤酒Beer x" + Beer + "共NT$" + Convert.ToString(120 * Beer) + "元\n";
            Show =SBeer+STequila+SWhisky+SWine;
            richTextBox1.Text = Show;
        }

        private void btn_Tequila_Click(object sender, EventArgs e)
        {
            Price+= 180;
            txt_Price.Text = "NT$" + Price;
            Tequila += 1;
            STequila = "龍舌蘭Tequila x" + Tequila + "共NT$" + Convert.ToString(180 * Tequila) + "元\n";
            Show = SBeer + STequila + SWhisky + SWine;
            richTextBox1.Text = Show;
        }

        private void btn_Whisky_Click(object sender, EventArgs e)
        {
            Price+= 350;
            txt_Price.Text = "NT$" + Price;
            Whisky += 1;
            SWhisky = "威士忌Whisky x" + Whisky + "共NT$" + Convert.ToString(350 * Whisky) + "元\n";
            Show=SBeer + STequila + SWhisky + SWine;
            richTextBox1.Text = Show;
        }

                private void btn_Cash_Click(object sender, EventArgs e)
        {
            if (Price > 0)
            {
                MessageBox.Show("總金額NT$:" + Price, "確認付款", MessageBoxButtons.OKCancel);
            }
            else
                MessageBox.Show("尚未點餐！", "確認付款", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
        }

        private void POS0705_Load(object sender, EventArgs e)
        {

        }
           
        private void btn_Card_Click(object sender, EventArgs e)
        {
            Discount = Convert.ToInt32(Price * 0.9);

            if (Price > 0)
            {
               MessageBox.Show("總金額NT$:"+Price+
                   Environment.NewLine+
                   "折扣後金額:NT$"+Discount,
                   "確認付款", MessageBoxButtons.OKCancel);
            }
            else
                MessageBox.Show("尚未點餐！", "確認付款", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }
    }
}
