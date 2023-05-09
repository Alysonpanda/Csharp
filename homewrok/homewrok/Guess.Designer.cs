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
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(637, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please Select A Number Between 1 to 100!";
            // 
            // btn_Guess
            // 
            this.btn_Guess.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Guess.Location = new System.Drawing.Point(146, 197);
            this.btn_Guess.Name = "btn_Guess";
            this.btn_Guess.Size = new System.Drawing.Size(147, 59);
            this.btn_Guess.TabIndex = 1;
            this.btn_Guess.Text = "Guess";
            this.btn_Guess.UseVisualStyleBackColor = true;
            this.btn_Guess.Click += new System.EventHandler(this.btn_Guess_Click);
            // 
            // btn_Ans
            // 
            this.btn_Ans.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Ans.Location = new System.Drawing.Point(336, 197);
            this.btn_Ans.Name = "btn_Ans";
            this.btn_Ans.Size = new System.Drawing.Size(236, 59);
            this.btn_Ans.TabIndex = 2;
            this.btn_Ans.Text = "Show Answer";
            this.btn_Ans.UseVisualStyleBackColor = true;
            this.btn_Ans.Click += new System.EventHandler(this.btn_Ans_Click);
            // 
            // Guess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 343);
            this.Controls.Add(this.btn_Ans);
            this.Controls.Add(this.btn_Guess);
            this.Controls.Add(this.label1);
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