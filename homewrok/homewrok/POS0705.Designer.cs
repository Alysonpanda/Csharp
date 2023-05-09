namespace homewrok
{
    partial class POS0705
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(POS0705));
            this.gB_Menu = new System.Windows.Forms.GroupBox();
            this.btn_Whisky = new System.Windows.Forms.Button();
            this.btn_Beer = new System.Windows.Forms.Button();
            this.btn_Tequila = new System.Windows.Forms.Button();
            this.btn_Wine = new System.Windows.Forms.Button();
            this.gB_TotalPrice = new System.Windows.Forms.GroupBox();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.gB_Pay = new System.Windows.Forms.GroupBox();
            this.lab_Card = new System.Windows.Forms.Label();
            this.btn_Card = new System.Windows.Forms.Button();
            this.btn_Cash = new System.Windows.Forms.Button();
            this.gB_List = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btn_Cxl = new System.Windows.Forms.Button();
            this.gB_Menu.SuspendLayout();
            this.gB_TotalPrice.SuspendLayout();
            this.gB_Pay.SuspendLayout();
            this.gB_List.SuspendLayout();
            this.SuspendLayout();
            // 
            // gB_Menu
            // 
            this.gB_Menu.BackColor = System.Drawing.Color.Transparent;
            this.gB_Menu.Controls.Add(this.btn_Whisky);
            this.gB_Menu.Controls.Add(this.btn_Beer);
            this.gB_Menu.Controls.Add(this.btn_Tequila);
            this.gB_Menu.Controls.Add(this.btn_Wine);
            this.gB_Menu.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gB_Menu.ForeColor = System.Drawing.Color.IndianRed;
            this.gB_Menu.Location = new System.Drawing.Point(43, 32);
            this.gB_Menu.Name = "gB_Menu";
            this.gB_Menu.Size = new System.Drawing.Size(281, 412);
            this.gB_Menu.TabIndex = 0;
            this.gB_Menu.TabStop = false;
            this.gB_Menu.Text = "菜單Menu";
            // 
            // btn_Whisky
            // 
            this.btn_Whisky.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Whisky.ForeColor = System.Drawing.Color.SeaShell;
            this.btn_Whisky.Image = ((System.Drawing.Image)(resources.GetObject("btn_Whisky.Image")));
            this.btn_Whisky.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_Whisky.Location = new System.Drawing.Point(19, 218);
            this.btn_Whisky.Name = "btn_Whisky";
            this.btn_Whisky.Size = new System.Drawing.Size(109, 170);
            this.btn_Whisky.TabIndex = 1;
            this.btn_Whisky.Text = "威士忌Whisky$350";
            this.btn_Whisky.UseVisualStyleBackColor = true;
            this.btn_Whisky.Click += new System.EventHandler(this.btn_Whisky_Click);
            // 
            // btn_Beer
            // 
            this.btn_Beer.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Beer.ForeColor = System.Drawing.Color.OrangeRed;
            this.btn_Beer.Image = global::homewrok.Properties.Resources.beer;
            this.btn_Beer.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Beer.Location = new System.Drawing.Point(19, 43);
            this.btn_Beer.Name = "btn_Beer";
            this.btn_Beer.Size = new System.Drawing.Size(109, 175);
            this.btn_Beer.TabIndex = 2;
            this.btn_Beer.Text = "啤酒Beer$120";
            this.btn_Beer.UseVisualStyleBackColor = true;
            this.btn_Beer.Click += new System.EventHandler(this.btn_Beer_Click);
            // 
            // btn_Tequila
            // 
            this.btn_Tequila.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Tequila.ForeColor = System.Drawing.Color.OrangeRed;
            this.btn_Tequila.Image = global::homewrok.Properties.Resources.TEQUILA0;
            this.btn_Tequila.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Tequila.Location = new System.Drawing.Point(147, 235);
            this.btn_Tequila.Name = "btn_Tequila";
            this.btn_Tequila.Size = new System.Drawing.Size(109, 153);
            this.btn_Tequila.TabIndex = 3;
            this.btn_Tequila.Text = "龍舌蘭Tequila$180";
            this.btn_Tequila.UseVisualStyleBackColor = true;
            this.btn_Tequila.Click += new System.EventHandler(this.btn_Tequila_Click);
            // 
            // btn_Wine
            // 
            this.btn_Wine.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Wine.ForeColor = System.Drawing.Color.OrangeRed;
            this.btn_Wine.Image = global::homewrok.Properties.Resources.RED_WINE0;
            this.btn_Wine.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Wine.Location = new System.Drawing.Point(134, 97);
            this.btn_Wine.Name = "btn_Wine";
            this.btn_Wine.Size = new System.Drawing.Size(141, 115);
            this.btn_Wine.TabIndex = 4;
            this.btn_Wine.Text = "紅酒Wine$320";
            this.btn_Wine.UseVisualStyleBackColor = true;
            this.btn_Wine.Click += new System.EventHandler(this.btn_Wine_Click);
            // 
            // gB_TotalPrice
            // 
            this.gB_TotalPrice.BackColor = System.Drawing.Color.Transparent;
            this.gB_TotalPrice.Controls.Add(this.txt_Price);
            this.gB_TotalPrice.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gB_TotalPrice.ForeColor = System.Drawing.Color.IndianRed;
            this.gB_TotalPrice.Location = new System.Drawing.Point(351, 75);
            this.gB_TotalPrice.Name = "gB_TotalPrice";
            this.gB_TotalPrice.Size = new System.Drawing.Size(237, 100);
            this.gB_TotalPrice.TabIndex = 5;
            this.gB_TotalPrice.TabStop = false;
            this.gB_TotalPrice.Text = "總金額Total Price";
            // 
            // txt_Price
            // 
            this.txt_Price.BackColor = System.Drawing.Color.MistyRose;
            this.txt_Price.ForeColor = System.Drawing.Color.Tomato;
            this.txt_Price.Location = new System.Drawing.Point(66, 51);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(171, 39);
            this.txt_Price.TabIndex = 1;
            this.txt_Price.Text = "NT$";
            this.txt_Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // gB_Pay
            // 
            this.gB_Pay.BackColor = System.Drawing.Color.Transparent;
            this.gB_Pay.Controls.Add(this.lab_Card);
            this.gB_Pay.Controls.Add(this.btn_Card);
            this.gB_Pay.Controls.Add(this.btn_Cash);
            this.gB_Pay.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gB_Pay.ForeColor = System.Drawing.Color.IndianRed;
            this.gB_Pay.Location = new System.Drawing.Point(351, 181);
            this.gB_Pay.Name = "gB_Pay";
            this.gB_Pay.Size = new System.Drawing.Size(237, 122);
            this.gB_Pay.TabIndex = 6;
            this.gB_Pay.TabStop = false;
            this.gB_Pay.Text = "付款方式";
            // 
            // lab_Card
            // 
            this.lab_Card.AutoSize = true;
            this.lab_Card.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_Card.ForeColor = System.Drawing.Color.Tomato;
            this.lab_Card.Location = new System.Drawing.Point(133, 81);
            this.lab_Card.Name = "lab_Card";
            this.lab_Card.Size = new System.Drawing.Size(104, 19);
            this.lab_Card.TabIndex = 2;
            this.lab_Card.Text = "信用卡享九折!";
            // 
            // btn_Card
            // 
            this.btn_Card.BackColor = System.Drawing.Color.MistyRose;
            this.btn_Card.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Card.ForeColor = System.Drawing.Color.Tomato;
            this.btn_Card.Location = new System.Drawing.Point(156, 38);
            this.btn_Card.Name = "btn_Card";
            this.btn_Card.Size = new System.Drawing.Size(75, 40);
            this.btn_Card.TabIndex = 1;
            this.btn_Card.Text = "信用卡";
            this.btn_Card.UseVisualStyleBackColor = false;
            this.btn_Card.Click += new System.EventHandler(this.btn_Card_Click);
            // 
            // btn_Cash
            // 
            this.btn_Cash.BackColor = System.Drawing.Color.MistyRose;
            this.btn_Cash.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Cash.ForeColor = System.Drawing.Color.Tomato;
            this.btn_Cash.Location = new System.Drawing.Point(66, 38);
            this.btn_Cash.Name = "btn_Cash";
            this.btn_Cash.Size = new System.Drawing.Size(75, 40);
            this.btn_Cash.TabIndex = 0;
            this.btn_Cash.Text = "現金";
            this.btn_Cash.UseVisualStyleBackColor = false;
            this.btn_Cash.Click += new System.EventHandler(this.btn_Cash_Click);
            // 
            // gB_List
            // 
            this.gB_List.BackColor = System.Drawing.Color.Transparent;
            this.gB_List.Controls.Add(this.richTextBox1);
            this.gB_List.Controls.Add(this.btn_Cxl);
            this.gB_List.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gB_List.ForeColor = System.Drawing.Color.IndianRed;
            this.gB_List.Location = new System.Drawing.Point(618, 105);
            this.gB_List.Name = "gB_List";
            this.gB_List.Size = new System.Drawing.Size(256, 283);
            this.gB_List.TabIndex = 7;
            this.gB_List.TabStop = false;
            this.gB_List.Text = "購物清單List";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.MistyRose;
            this.richTextBox1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.richTextBox1.ForeColor = System.Drawing.Color.Tomato;
            this.richTextBox1.Location = new System.Drawing.Point(20, 35);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.richTextBox1.Size = new System.Drawing.Size(220, 190);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "尚未點餐";
            // 
            // btn_Cxl
            // 
            this.btn_Cxl.BackColor = System.Drawing.Color.MistyRose;
            this.btn_Cxl.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Cxl.ForeColor = System.Drawing.Color.Tomato;
            this.btn_Cxl.Location = new System.Drawing.Point(139, 231);
            this.btn_Cxl.Name = "btn_Cxl";
            this.btn_Cxl.Size = new System.Drawing.Size(101, 36);
            this.btn_Cxl.TabIndex = 0;
            this.btn_Cxl.Text = "清除清單";
            this.btn_Cxl.UseVisualStyleBackColor = false;
            this.btn_Cxl.Click += new System.EventHandler(this.btn_Cxl_Click);
            // 
            // POS0705
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::homewrok.Properties.Resources.RPMT0;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(919, 480);
            this.Controls.Add(this.gB_List);
            this.Controls.Add(this.gB_Pay);
            this.Controls.Add(this.gB_TotalPrice);
            this.Controls.Add(this.gB_Menu);
            this.Name = "POS0705";
            this.Text = "Bar POS";
            this.Load += new System.EventHandler(this.POS0705_Load);
            this.gB_Menu.ResumeLayout(false);
            this.gB_TotalPrice.ResumeLayout(false);
            this.gB_TotalPrice.PerformLayout();
            this.gB_Pay.ResumeLayout(false);
            this.gB_Pay.PerformLayout();
            this.gB_List.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gB_Menu;
        private System.Windows.Forms.Button btn_Whisky;
        private System.Windows.Forms.Button btn_Beer;
        private System.Windows.Forms.Button btn_Tequila;
        private System.Windows.Forms.Button btn_Wine;
        private System.Windows.Forms.GroupBox gB_TotalPrice;
        private System.Windows.Forms.GroupBox gB_Pay;
        private System.Windows.Forms.Label lab_Card;
        private System.Windows.Forms.Button btn_Card;
        private System.Windows.Forms.Button btn_Cash;
        private System.Windows.Forms.GroupBox gB_List;
        private System.Windows.Forms.Button btn_Cxl;
        private System.Windows.Forms.TextBox txt_Price;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}