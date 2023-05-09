namespace homewrok
{
    partial class StudentGrade0709
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
            this.txt_Chi = new System.Windows.Forms.TextBox();
            this.txt_Eng = new System.Windows.Forms.TextBox();
            this.txt_Math = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.lab_Chinese = new System.Windows.Forms.Label();
            this.lab_English = new System.Windows.Forms.Label();
            this.lab_Math = new System.Windows.Forms.Label();
            this.lab_Name = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Total = new System.Windows.Forms.Button();
            this.btn_Random20 = new System.Windows.Forms.Button();
            this.btn_Renew = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.c_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.c_Chi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.c_Eng = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.c_Math = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.c_TotalScore = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.c_Ave = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.c_Min = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.c_Max = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lab_Show = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_Chi
            // 
            this.txt_Chi.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_Chi.Location = new System.Drawing.Point(89, 72);
            this.txt_Chi.Name = "txt_Chi";
            this.txt_Chi.Size = new System.Drawing.Size(100, 33);
            this.txt_Chi.TabIndex = 15;
            // 
            // txt_Eng
            // 
            this.txt_Eng.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_Eng.Location = new System.Drawing.Point(89, 122);
            this.txt_Eng.Name = "txt_Eng";
            this.txt_Eng.Size = new System.Drawing.Size(100, 33);
            this.txt_Eng.TabIndex = 14;
            // 
            // txt_Math
            // 
            this.txt_Math.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_Math.Location = new System.Drawing.Point(89, 174);
            this.txt_Math.Name = "txt_Math";
            this.txt_Math.Size = new System.Drawing.Size(100, 33);
            this.txt_Math.TabIndex = 13;
            // 
            // txt_Name
            // 
            this.txt_Name.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_Name.Location = new System.Drawing.Point(89, 25);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(100, 33);
            this.txt_Name.TabIndex = 12;
            // 
            // lab_Chinese
            // 
            this.lab_Chinese.AutoSize = true;
            this.lab_Chinese.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_Chinese.Location = new System.Drawing.Point(31, 81);
            this.lab_Chinese.Name = "lab_Chinese";
            this.lab_Chinese.Size = new System.Drawing.Size(52, 24);
            this.lab_Chinese.TabIndex = 11;
            this.lab_Chinese.Text = "國文:";
            // 
            // lab_English
            // 
            this.lab_English.AutoSize = true;
            this.lab_English.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_English.Location = new System.Drawing.Point(31, 131);
            this.lab_English.Name = "lab_English";
            this.lab_English.Size = new System.Drawing.Size(52, 24);
            this.lab_English.TabIndex = 10;
            this.lab_English.Text = "英文:";
            // 
            // lab_Math
            // 
            this.lab_Math.AutoSize = true;
            this.lab_Math.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_Math.Location = new System.Drawing.Point(31, 177);
            this.lab_Math.Name = "lab_Math";
            this.lab_Math.Size = new System.Drawing.Size(52, 24);
            this.lab_Math.TabIndex = 9;
            this.lab_Math.Text = "數學:";
            // 
            // lab_Name
            // 
            this.lab_Name.AutoSize = true;
            this.lab_Name.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_Name.Location = new System.Drawing.Point(31, 34);
            this.lab_Name.Name = "lab_Name";
            this.lab_Name.Size = new System.Drawing.Size(52, 24);
            this.lab_Name.TabIndex = 8;
            this.lab_Name.Text = "姓名:";
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Add.Location = new System.Drawing.Point(44, 213);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(163, 34);
            this.btn_Add.TabIndex = 16;
            this.btn_Add.Text = "加入學生資料";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Save.Location = new System.Drawing.Point(44, 253);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(163, 38);
            this.btn_Save.TabIndex = 17;
            this.btn_Save.Text = "隨機儲存資料";
            this.btn_Save.UseVisualStyleBackColor = true;
            // 
            // btn_Total
            // 
            this.btn_Total.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Total.Location = new System.Drawing.Point(44, 297);
            this.btn_Total.Name = "btn_Total";
            this.btn_Total.Size = new System.Drawing.Size(163, 38);
            this.btn_Total.TabIndex = 18;
            this.btn_Total.Text = "各科統計";
            this.btn_Total.UseVisualStyleBackColor = true;
            // 
            // btn_Random20
            // 
            this.btn_Random20.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Random20.Location = new System.Drawing.Point(44, 385);
            this.btn_Random20.Name = "btn_Random20";
            this.btn_Random20.Size = new System.Drawing.Size(163, 38);
            this.btn_Random20.TabIndex = 21;
            this.btn_Random20.Text = "隨機加入20筆";
            this.btn_Random20.UseVisualStyleBackColor = true;
            // 
            // btn_Renew
            // 
            this.btn_Renew.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Renew.Location = new System.Drawing.Point(44, 341);
            this.btn_Renew.Name = "btn_Renew";
            this.btn_Renew.Size = new System.Drawing.Size(163, 38);
            this.btn_Renew.TabIndex = 20;
            this.btn_Renew.Text = "重設所有資料";
            this.btn_Renew.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.Menu;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.c_Name,
            this.c_Chi,
            this.c_Eng,
            this.c_Math,
            this.c_TotalScore,
            this.c_Ave,
            this.c_Min,
            this.c_Max});
            this.listView1.Font = new System.Drawing.Font("標楷體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listView1.GridLines = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(274, 25);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(485, 233);
            this.listView1.TabIndex = 22;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // c_Name
            // 
            this.c_Name.Text = "姓名";
            // 
            // c_Chi
            // 
            this.c_Chi.Text = "國文";
            // 
            // c_Eng
            // 
            this.c_Eng.Text = "英文";
            // 
            // c_Math
            // 
            this.c_Math.Text = "數學";
            // 
            // c_TotalScore
            // 
            this.c_TotalScore.Text = "總分";
            // 
            // c_Ave
            // 
            this.c_Ave.Text = "平均";
            // 
            // c_Min
            // 
            this.c_Min.Text = "最低";
            // 
            // c_Max
            // 
            this.c_Max.Text = "最高";
            // 
            // lab_Show
            // 
            this.lab_Show.Font = new System.Drawing.Font("標楷體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_Show.Location = new System.Drawing.Point(283, 57);
            this.lab_Show.Name = "lab_Show";
            this.lab_Show.Size = new System.Drawing.Size(467, 48);
            this.lab_Show.TabIndex = 23;
            // 
            // StudentGrade0709
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lab_Show);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btn_Random20);
            this.Controls.Add(this.btn_Renew);
            this.Controls.Add(this.btn_Total);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.txt_Chi);
            this.Controls.Add(this.txt_Eng);
            this.Controls.Add(this.txt_Math);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.lab_Chinese);
            this.Controls.Add(this.lab_English);
            this.Controls.Add(this.lab_Math);
            this.Controls.Add(this.lab_Name);
            this.Name = "StudentGrade0709";
            this.Text = "StudentGrade0709";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Chi;
        private System.Windows.Forms.TextBox txt_Eng;
        private System.Windows.Forms.TextBox txt_Math;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label lab_Chinese;
        private System.Windows.Forms.Label lab_English;
        private System.Windows.Forms.Label lab_Math;
        private System.Windows.Forms.Label lab_Name;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Total;
        private System.Windows.Forms.Button btn_Random20;
        private System.Windows.Forms.Button btn_Renew;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader c_Name;
        private System.Windows.Forms.ColumnHeader c_Chi;
        private System.Windows.Forms.ColumnHeader c_Eng;
        private System.Windows.Forms.ColumnHeader c_Math;
        private System.Windows.Forms.ColumnHeader c_TotalScore;
        private System.Windows.Forms.ColumnHeader c_Ave;
        private System.Windows.Forms.ColumnHeader c_Min;
        private System.Windows.Forms.ColumnHeader c_Max;
        private System.Windows.Forms.Label lab_Show;
    }
}