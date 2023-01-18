namespace InventoryManager
{
    partial class InventoryManagementStudio
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
            this.priceTxt = new System.Windows.Forms.TextBox();
            this.inventoryGridView = new System.Windows.Forms.DataGridView();
            this.newBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.descriptionTxt = new System.Windows.Forms.TextBox();
            this.quantityTxt = new System.Windows.Forms.TextBox();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.skuTxt = new System.Windows.Forms.TextBox();
            this.categoryBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1126, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventory Managment";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // priceTxt
            // 
            this.priceTxt.Location = new System.Drawing.Point(12, 150);
            this.priceTxt.Name = "priceTxt";
            this.priceTxt.Size = new System.Drawing.Size(323, 20);
            this.priceTxt.TabIndex = 1;
            // 
            // inventoryGridView
            // 
            this.inventoryGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.inventoryGridView.BackgroundColor = System.Drawing.Color.White;
            this.inventoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventoryGridView.Location = new System.Drawing.Point(12, 229);
            this.inventoryGridView.Name = "inventoryGridView";
            this.inventoryGridView.Size = new System.Drawing.Size(1126, 427);
            this.inventoryGridView.TabIndex = 2;
            this.inventoryGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.inventoryGridView_CellDoubleClick);
            // 
            // newBtn
            // 
            this.newBtn.BackColor = System.Drawing.Color.White;
            this.newBtn.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newBtn.Location = new System.Drawing.Point(12, 176);
            this.newBtn.Name = "newBtn";
            this.newBtn.Size = new System.Drawing.Size(323, 47);
            this.newBtn.TabIndex = 3;
            this.newBtn.Text = "New";
            this.newBtn.UseVisualStyleBackColor = false;
            this.newBtn.Click += new System.EventHandler(this.newBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.White;
            this.deleteBtn.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(815, 176);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(323, 47);
            this.deleteBtn.TabIndex = 4;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.White;
            this.saveBtn.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(412, 176);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(323, 47);
            this.saveBtn.TabIndex = 5;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // descriptionTxt
            // 
            this.descriptionTxt.Location = new System.Drawing.Point(412, 150);
            this.descriptionTxt.Name = "descriptionTxt";
            this.descriptionTxt.Size = new System.Drawing.Size(323, 20);
            this.descriptionTxt.TabIndex = 6;
            // 
            // quantityTxt
            // 
            this.quantityTxt.Location = new System.Drawing.Point(815, 150);
            this.quantityTxt.Name = "quantityTxt";
            this.quantityTxt.Size = new System.Drawing.Size(323, 20);
            this.quantityTxt.TabIndex = 7;
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(412, 112);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(323, 20);
            this.nameTxt.TabIndex = 9;
            // 
            // skuTxt
            // 
            this.skuTxt.Location = new System.Drawing.Point(12, 113);
            this.skuTxt.Name = "skuTxt";
            this.skuTxt.Size = new System.Drawing.Size(323, 20);
            this.skuTxt.TabIndex = 10;
            // 
            // categoryBox
            // 
            this.categoryBox.FormattingEnabled = true;
            this.categoryBox.Items.AddRange(new object[] {
            "Automotive",
            "Hardware",
            "Grocery",
            "Pharmacy"});
            this.categoryBox.Location = new System.Drawing.Point(815, 112);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Size = new System.Drawing.Size(323, 21);
            this.categoryBox.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(322, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "SKU:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(413, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(322, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Name:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(322, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Price:";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(413, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(322, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Description:";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(816, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(322, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Quantity:";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(816, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(322, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Category:";
            // 
            // InventoryManagementStudio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(1150, 668);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.categoryBox);
            this.Controls.Add(this.skuTxt);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.quantityTxt);
            this.Controls.Add(this.descriptionTxt);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.newBtn);
            this.Controls.Add(this.inventoryGridView);
            this.Controls.Add(this.priceTxt);
            this.Controls.Add(this.label1);
            this.Name = "InventoryManagementStudio";
            this.Text = "Inventory Management Studio";
            this.Load += new System.EventHandler(this.InventoryManagementStudio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox priceTxt;
        private System.Windows.Forms.DataGridView inventoryGridView;
        private System.Windows.Forms.Button newBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.TextBox descriptionTxt;
        private System.Windows.Forms.TextBox quantityTxt;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.TextBox skuTxt;
        private System.Windows.Forms.ComboBox categoryBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

