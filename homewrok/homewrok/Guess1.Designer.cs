namespace homewrok
{
    partial class Guess1
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
            this.lab_Input = new System.Windows.Forms.Label();
            this.btn_CXL = new System.Windows.Forms.Button();
            this.btn_Enter = new System.Windows.Forms.Button();
            this.txt_Num = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lab_Input
            // 
            this.lab_Input.AutoSize = true;
            this.lab_Input.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Input.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.lab_Input.Location = new System.Drawing.Point(78, 60);
            this.lab_Input.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_Input.Name = "lab_Input";
            this.lab_Input.Size = new System.Drawing.Size(436, 56);
            this.lab_Input.TabIndex = 0;
            this.lab_Input.Text = "Please input a number.";
            // 
            // btn_CXL
            // 
            this.btn_CXL.BackColor = System.Drawing.Color.Pink;
            this.btn_CXL.Font = new System.Drawing.Font("Comic Sans MS", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CXL.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.btn_CXL.Location = new System.Drawing.Point(548, 159);
            this.btn_CXL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_CXL.Name = "btn_CXL";
            this.btn_CXL.Size = new System.Drawing.Size(244, 76);
            this.btn_CXL.TabIndex = 1;
            this.btn_CXL.Text = "Cancel";
            this.btn_CXL.UseVisualStyleBackColor = false;
            this.btn_CXL.Click += new System.EventHandler(this.btn_CXL_Click);
            // 
            // btn_Enter
            // 
            this.btn_Enter.BackColor = System.Drawing.Color.Pink;
            this.btn_Enter.Font = new System.Drawing.Font("Comic Sans MS", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Enter.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Enter.Location = new System.Drawing.Point(548, 60);
            this.btn_Enter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Enter.Name = "btn_Enter";
            this.btn_Enter.Size = new System.Drawing.Size(244, 76);
            this.btn_Enter.TabIndex = 2;
            this.btn_Enter.Text = "Enter";
            this.btn_Enter.UseVisualStyleBackColor = false;
            this.btn_Enter.Click += new System.EventHandler(this.btn_Enter_Click);
            // 
            // txt_Num
            // 
            this.txt_Num.BackColor = System.Drawing.Color.Pink;
            this.txt_Num.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Num.Font = new System.Drawing.Font("Comic Sans MS", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Num.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.txt_Num.Location = new System.Drawing.Point(126, 159);
            this.txt_Num.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Num.Name = "txt_Num";
            this.txt_Num.Size = new System.Drawing.Size(374, 62);
            this.txt_Num.TabIndex = 3;
            // 
            // Guess1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(834, 298);
            this.Controls.Add(this.txt_Num);
            this.Controls.Add(this.btn_Enter);
            this.Controls.Add(this.btn_CXL);
            this.Controls.Add(this.lab_Input);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Guess1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Guess";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_Input;
        private System.Windows.Forms.Button btn_CXL;
        private System.Windows.Forms.Button btn_Enter;
        private System.Windows.Forms.TextBox txt_Num;
    }
}