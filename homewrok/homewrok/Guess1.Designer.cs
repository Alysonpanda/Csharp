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
            this.lab_Input.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_Input.Location = new System.Drawing.Point(52, 61);
            this.lab_Input.Name = "lab_Input";
            this.lab_Input.Size = new System.Drawing.Size(272, 30);
            this.lab_Input.TabIndex = 0;
            this.lab_Input.Text = "Please input a number.";
            // 
            // btn_CXL
            // 
            this.btn_CXL.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_CXL.Location = new System.Drawing.Point(365, 106);
            this.btn_CXL.Name = "btn_CXL";
            this.btn_CXL.Size = new System.Drawing.Size(163, 51);
            this.btn_CXL.TabIndex = 1;
            this.btn_CXL.Text = "Cancel";
            this.btn_CXL.UseVisualStyleBackColor = true;
            this.btn_CXL.Click += new System.EventHandler(this.btn_CXL_Click);
            // 
            // btn_Enter
            // 
            this.btn_Enter.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Enter.Location = new System.Drawing.Point(365, 40);
            this.btn_Enter.Name = "btn_Enter";
            this.btn_Enter.Size = new System.Drawing.Size(163, 51);
            this.btn_Enter.TabIndex = 2;
            this.btn_Enter.Text = "Enter";
            this.btn_Enter.UseVisualStyleBackColor = true;
            this.btn_Enter.Click += new System.EventHandler(this.btn_Enter_Click);
            // 
            // txt_Num
            // 
            this.txt_Num.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_Num.Location = new System.Drawing.Point(73, 118);
            this.txt_Num.Name = "txt_Num";
            this.txt_Num.Size = new System.Drawing.Size(251, 39);
            this.txt_Num.TabIndex = 3;
            // 
            // Guess1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 199);
            this.Controls.Add(this.txt_Num);
            this.Controls.Add(this.btn_Enter);
            this.Controls.Add(this.btn_CXL);
            this.Controls.Add(this.lab_Input);
            this.Name = "Guess1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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