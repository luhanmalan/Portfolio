namespace QRCodeGenerator
{
    partial class Form1
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
            this.GenerateBtn1 = new System.Windows.Forms.Button();
            this.txtQR = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textLbl1 = new System.Windows.Forms.Label();
            this.txtBar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GenerateBtn2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GenerateBtn1
            // 
            this.GenerateBtn1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateBtn1.Location = new System.Drawing.Point(427, 340);
            this.GenerateBtn1.Name = "GenerateBtn1";
            this.GenerateBtn1.Size = new System.Drawing.Size(96, 26);
            this.GenerateBtn1.TabIndex = 0;
            this.GenerateBtn1.Text = "Generate QR";
            this.GenerateBtn1.UseVisualStyleBackColor = true;
            this.GenerateBtn1.Click += new System.EventHandler(this.GenerateBtn1_Click);
            // 
            // txtQR
            // 
            this.txtQR.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQR.Location = new System.Drawing.Point(99, 340);
            this.txtQR.Name = "txtQR";
            this.txtQR.Size = new System.Drawing.Size(313, 26);
            this.txtQR.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(36, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(393, 285);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // textLbl1
            // 
            this.textLbl1.AutoSize = true;
            this.textLbl1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLbl1.ForeColor = System.Drawing.Color.White;
            this.textLbl1.Location = new System.Drawing.Point(32, 343);
            this.textLbl1.Name = "textLbl1";
            this.textLbl1.Size = new System.Drawing.Size(61, 20);
            this.textLbl1.TabIndex = 3;
            this.textLbl1.Text = "QR Text:";
            // 
            // txtBar
            // 
            this.txtBar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBar.Location = new System.Drawing.Point(99, 384);
            this.txtBar.Name = "txtBar";
            this.txtBar.Size = new System.Drawing.Size(313, 26);
            this.txtBar.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 387);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bar Text:";
            // 
            // GenerateBtn2
            // 
            this.GenerateBtn2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateBtn2.Location = new System.Drawing.Point(427, 384);
            this.GenerateBtn2.Name = "GenerateBtn2";
            this.GenerateBtn2.Size = new System.Drawing.Size(96, 26);
            this.GenerateBtn2.TabIndex = 6;
            this.GenerateBtn2.Text = "Generate Bar";
            this.GenerateBtn2.UseVisualStyleBackColor = true;
            this.GenerateBtn2.Click += new System.EventHandler(this.GenerateBtn2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(695, 475);
            this.Controls.Add(this.GenerateBtn2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBar);
            this.Controls.Add(this.textLbl1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtQR);
            this.Controls.Add(this.GenerateBtn1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GenerateBtn1;
        private System.Windows.Forms.TextBox txtQR;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label textLbl1;
        private System.Windows.Forms.TextBox txtBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GenerateBtn2;
    }
}

