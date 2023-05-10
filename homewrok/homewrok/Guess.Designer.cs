namespace homewrok
{
    partial class Guess
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Guess = new System.Windows.Forms.Button();
            this.btn_Ans = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Pink;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.label1.Location = new System.Drawing.Point(13, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1048, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please Select A Number Between 1 to 100!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Guess
            // 
            this.btn_Guess.BackColor = System.Drawing.Color.Pink;
            this.btn_Guess.Font = new System.Drawing.Font("Comic Sans MS", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guess.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Guess.Location = new System.Drawing.Point(757, 363);
            this.btn_Guess.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Guess.Name = "btn_Guess";
            this.btn_Guess.Size = new System.Drawing.Size(198, 70);
            this.btn_Guess.TabIndex = 1;
            this.btn_Guess.Text = "Guess";
            this.btn_Guess.UseVisualStyleBackColor = false;
            this.btn_Guess.Click += new System.EventHandler(this.btn_Guess_Click);
            // 
            // btn_Ans
            // 
            this.btn_Ans.BackColor = System.Drawing.Color.Pink;
            this.btn_Ans.Font = new System.Drawing.Font("Comic Sans MS", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ans.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Ans.Location = new System.Drawing.Point(695, 454);
            this.btn_Ans.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Ans.Name = "btn_Ans";
            this.btn_Ans.Size = new System.Drawing.Size(354, 88);
            this.btn_Ans.TabIndex = 2;
            this.btn_Ans.Text = "Show Answer";
            this.btn_Ans.UseVisualStyleBackColor = false;
            this.btn_Ans.Click += new System.EventHandler(this.btn_Ans_Click);
            // 
            // Guess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::homewrok.Properties.Resources.RRTPANDA;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1076, 611);
            this.Controls.Add(this.btn_Ans);
            this.Controls.Add(this.btn_Guess);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Guess";
            this.Text = "Form Guess Number";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Guess;
        private System.Windows.Forms.Button btn_Ans;
    }
}