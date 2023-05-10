namespace homewrok
{
    partial class Alarm
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
            this.components = new System.ComponentModel.Container();
            this.gB_Select = new System.Windows.Forms.GroupBox();
            this.lab_S = new System.Windows.Forms.Label();
            this.lab_M = new System.Windows.Forms.Label();
            this.lab_H = new System.Windows.Forms.Label();
            this.txt_S = new System.Windows.Forms.TextBox();
            this.txt_M = new System.Windows.Forms.TextBox();
            this.txt_H = new System.Windows.Forms.TextBox();
            this.cB_Set = new System.Windows.Forms.CheckBox();
            this.lab_Alarm1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.gB_Select.SuspendLayout();
            this.SuspendLayout();
            // 
            // gB_Select
            // 
            this.gB_Select.BackColor = System.Drawing.Color.Transparent;
            this.gB_Select.Controls.Add(this.lab_S);
            this.gB_Select.Controls.Add(this.lab_M);
            this.gB_Select.Controls.Add(this.lab_H);
            this.gB_Select.Controls.Add(this.txt_S);
            this.gB_Select.Controls.Add(this.txt_M);
            this.gB_Select.Controls.Add(this.txt_H);
            this.gB_Select.Controls.Add(this.cB_Set);
            this.gB_Select.Controls.Add(this.lab_Alarm1);
            this.gB_Select.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gB_Select.ForeColor = System.Drawing.Color.Tomato;
            this.gB_Select.Location = new System.Drawing.Point(34, 229);
            this.gB_Select.Name = "gB_Select";
            this.gB_Select.Size = new System.Drawing.Size(556, 227);
            this.gB_Select.TabIndex = 0;
            this.gB_Select.TabStop = false;
            this.gB_Select.Text = "Select Time";
            // 
            // lab_S
            // 
            this.lab_S.AutoSize = true;
            this.lab_S.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_S.Location = new System.Drawing.Point(422, 81);
            this.lab_S.Name = "lab_S";
            this.lab_S.Size = new System.Drawing.Size(33, 27);
            this.lab_S.TabIndex = 9;
            this.lab_S.Text = "秒";
            // 
            // lab_M
            // 
            this.lab_M.AutoSize = true;
            this.lab_M.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_M.Location = new System.Drawing.Point(327, 81);
            this.lab_M.Name = "lab_M";
            this.lab_M.Size = new System.Drawing.Size(33, 27);
            this.lab_M.TabIndex = 8;
            this.lab_M.Text = "分";
            // 
            // lab_H
            // 
            this.lab_H.AutoSize = true;
            this.lab_H.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_H.Location = new System.Drawing.Point(232, 81);
            this.lab_H.Name = "lab_H";
            this.lab_H.Size = new System.Drawing.Size(33, 27);
            this.lab_H.TabIndex = 7;
            this.lab_H.Text = "時";
            // 
            // txt_S
            // 
            this.txt_S.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.txt_S.Location = new System.Drawing.Point(366, 64);
            this.txt_S.Name = "txt_S";
            this.txt_S.Size = new System.Drawing.Size(50, 46);
            this.txt_S.TabIndex = 6;
            this.txt_S.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_M
            // 
            this.txt_M.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.txt_M.Location = new System.Drawing.Point(271, 64);
            this.txt_M.Name = "txt_M";
            this.txt_M.Size = new System.Drawing.Size(50, 46);
            this.txt_M.TabIndex = 5;
            this.txt_M.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_H
            // 
            this.txt_H.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.txt_H.Location = new System.Drawing.Point(176, 64);
            this.txt_H.Name = "txt_H";
            this.txt_H.Size = new System.Drawing.Size(50, 46);
            this.txt_H.TabIndex = 4;
            this.txt_H.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cB_Set
            // 
            this.cB_Set.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cB_Set.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.cB_Set.Location = new System.Drawing.Point(107, 129);
            this.cB_Set.Name = "cB_Set";
            this.cB_Set.Size = new System.Drawing.Size(167, 49);
            this.cB_Set.TabIndex = 3;
            this.cB_Set.Text = "Set Alarm";
            this.cB_Set.UseVisualStyleBackColor = true;
            // 
            // lab_Alarm1
            // 
            this.lab_Alarm1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_Alarm1.Location = new System.Drawing.Point(28, 78);
            this.lab_Alarm1.Name = "lab_Alarm1";
            this.lab_Alarm1.Size = new System.Drawing.Size(162, 38);
            this.lab_Alarm1.TabIndex = 1;
            this.lab_Alarm1.Text = "Alarm Time";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.label1.Location = new System.Drawing.Point(36, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 89);
            this.label1.TabIndex = 1;
            // 
            // Alarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::homewrok.Properties.Resources.RPANDA;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(899, 468);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gB_Select);
            this.Name = "Alarm";
            this.Text = "Form Alarm";
            this.Load += new System.EventHandler(this.Alarm_Load);
            this.gB_Select.ResumeLayout(false);
            this.gB_Select.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gB_Select;
        private System.Windows.Forms.CheckBox cB_Set;
        private System.Windows.Forms.Label lab_Alarm1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_S;
        private System.Windows.Forms.TextBox txt_M;
        private System.Windows.Forms.TextBox txt_H;
        private System.Windows.Forms.Label lab_S;
        private System.Windows.Forms.Label lab_M;
        private System.Windows.Forms.Label lab_H;
    }
}