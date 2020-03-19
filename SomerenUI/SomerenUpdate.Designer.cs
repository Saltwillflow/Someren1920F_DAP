namespace SomerenUI
{
    partial class SomerenUpdate
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
            this.lbl_Id = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.lbl_Stock = new System.Windows.Forms.Label();
            this.lbl_Alcoholic = new System.Windows.Forms.Label();
            this.lbl_TotalSold = new System.Windows.Forms.Label();
            this.lbl_Revenue = new System.Windows.Forms.Label();
            this.lbl_TotalTax = new System.Windows.Forms.Label();
            this.rdb_AlcoholicTrue = new System.Windows.Forms.RadioButton();
            this.rdb_AlcoholicFalse = new System.Windows.Forms.RadioButton();
            this.btn_Update = new System.Windows.Forms.Button();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.txt_TotalTax = new System.Windows.Forms.TextBox();
            this.txt_Revenue = new System.Windows.Forms.TextBox();
            this.txt_TotalSold = new System.Windows.Forms.TextBox();
            this.txt_Stock = new System.Windows.Forms.TextBox();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Location = new System.Drawing.Point(75, 43);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(19, 13);
            this.lbl_Id.TabIndex = 0;
            this.lbl_Id.Text = "Id:";
            this.lbl_Id.Click += new System.EventHandler(this.lbl_Id_Click);
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(75, 137);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(38, 13);
            this.lbl_Name.TabIndex = 1;
            this.lbl_Name.Text = "Name:";
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Location = new System.Drawing.Point(75, 239);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(34, 13);
            this.lbl_Price.TabIndex = 2;
            this.lbl_Price.Text = "Price:";
            // 
            // lbl_Stock
            // 
            this.lbl_Stock.AutoSize = true;
            this.lbl_Stock.Location = new System.Drawing.Point(75, 357);
            this.lbl_Stock.Name = "lbl_Stock";
            this.lbl_Stock.Size = new System.Drawing.Size(38, 13);
            this.lbl_Stock.TabIndex = 3;
            this.lbl_Stock.Text = "Stock:";
            this.lbl_Stock.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbl_Alcoholic
            // 
            this.lbl_Alcoholic.AutoSize = true;
            this.lbl_Alcoholic.Location = new System.Drawing.Point(376, 43);
            this.lbl_Alcoholic.Name = "lbl_Alcoholic";
            this.lbl_Alcoholic.Size = new System.Drawing.Size(53, 13);
            this.lbl_Alcoholic.TabIndex = 4;
            this.lbl_Alcoholic.Text = "Alcoholic:";
            // 
            // lbl_TotalSold
            // 
            this.lbl_TotalSold.AutoSize = true;
            this.lbl_TotalSold.Location = new System.Drawing.Point(376, 137);
            this.lbl_TotalSold.Name = "lbl_TotalSold";
            this.lbl_TotalSold.Size = new System.Drawing.Size(58, 13);
            this.lbl_TotalSold.TabIndex = 5;
            this.lbl_TotalSold.Text = "Total Sold:";
            // 
            // lbl_Revenue
            // 
            this.lbl_Revenue.AutoSize = true;
            this.lbl_Revenue.Location = new System.Drawing.Point(376, 239);
            this.lbl_Revenue.Name = "lbl_Revenue";
            this.lbl_Revenue.Size = new System.Drawing.Size(54, 13);
            this.lbl_Revenue.TabIndex = 6;
            this.lbl_Revenue.Text = "Revenue:";
            this.lbl_Revenue.Click += new System.EventHandler(this.label7_Click);
            // 
            // lbl_TotalTax
            // 
            this.lbl_TotalTax.AutoSize = true;
            this.lbl_TotalTax.Location = new System.Drawing.Point(376, 357);
            this.lbl_TotalTax.Name = "lbl_TotalTax";
            this.lbl_TotalTax.Size = new System.Drawing.Size(55, 13);
            this.lbl_TotalTax.TabIndex = 7;
            this.lbl_TotalTax.Text = "Total Tax:";
            this.lbl_TotalTax.Click += new System.EventHandler(this.label8_Click);
            // 
            // rdb_AlcoholicTrue
            // 
            this.rdb_AlcoholicTrue.AutoSize = true;
            this.rdb_AlcoholicTrue.Location = new System.Drawing.Point(491, 41);
            this.rdb_AlcoholicTrue.Name = "rdb_AlcoholicTrue";
            this.rdb_AlcoholicTrue.Size = new System.Drawing.Size(47, 17);
            this.rdb_AlcoholicTrue.TabIndex = 8;
            this.rdb_AlcoholicTrue.TabStop = true;
            this.rdb_AlcoholicTrue.Text = "True";
            this.rdb_AlcoholicTrue.UseVisualStyleBackColor = true;
            this.rdb_AlcoholicTrue.CheckedChanged += new System.EventHandler(this.rdb_AlcoholicTrue_CheckedChanged);
            // 
            // rdb_AlcoholicFalse
            // 
            this.rdb_AlcoholicFalse.AutoSize = true;
            this.rdb_AlcoholicFalse.Location = new System.Drawing.Point(491, 80);
            this.rdb_AlcoholicFalse.Name = "rdb_AlcoholicFalse";
            this.rdb_AlcoholicFalse.Size = new System.Drawing.Size(50, 17);
            this.rdb_AlcoholicFalse.TabIndex = 9;
            this.rdb_AlcoholicFalse.TabStop = true;
            this.rdb_AlcoholicFalse.Text = "False";
            this.rdb_AlcoholicFalse.UseVisualStyleBackColor = true;
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(208, 398);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(407, 23);
            this.btn_Update.TabIndex = 10;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // txt_Id
            // 
            this.txt_Id.Location = new System.Drawing.Point(170, 43);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(100, 20);
            this.txt_Id.TabIndex = 11;
            // 
            // txt_TotalTax
            // 
            this.txt_TotalTax.Location = new System.Drawing.Point(491, 352);
            this.txt_TotalTax.Name = "txt_TotalTax";
            this.txt_TotalTax.Size = new System.Drawing.Size(100, 20);
            this.txt_TotalTax.TabIndex = 12;
            // 
            // txt_Revenue
            // 
            this.txt_Revenue.Location = new System.Drawing.Point(491, 238);
            this.txt_Revenue.Name = "txt_Revenue";
            this.txt_Revenue.Size = new System.Drawing.Size(100, 20);
            this.txt_Revenue.TabIndex = 13;
            // 
            // txt_TotalSold
            // 
            this.txt_TotalSold.Location = new System.Drawing.Point(491, 136);
            this.txt_TotalSold.Name = "txt_TotalSold";
            this.txt_TotalSold.Size = new System.Drawing.Size(100, 20);
            this.txt_TotalSold.TabIndex = 14;
            // 
            // txt_Stock
            // 
            this.txt_Stock.Location = new System.Drawing.Point(170, 350);
            this.txt_Stock.Name = "txt_Stock";
            this.txt_Stock.Size = new System.Drawing.Size(100, 20);
            this.txt_Stock.TabIndex = 15;
            // 
            // txt_Price
            // 
            this.txt_Price.Location = new System.Drawing.Point(170, 232);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(100, 20);
            this.txt_Price.TabIndex = 16;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(170, 137);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(100, 20);
            this.txt_Name.TabIndex = 17;
            // 
            // SomerenUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.txt_Price);
            this.Controls.Add(this.txt_Stock);
            this.Controls.Add(this.txt_TotalSold);
            this.Controls.Add(this.txt_Revenue);
            this.Controls.Add(this.txt_TotalTax);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.rdb_AlcoholicFalse);
            this.Controls.Add(this.rdb_AlcoholicTrue);
            this.Controls.Add(this.lbl_TotalTax);
            this.Controls.Add(this.lbl_Revenue);
            this.Controls.Add(this.lbl_TotalSold);
            this.Controls.Add(this.lbl_Alcoholic);
            this.Controls.Add(this.lbl_Stock);
            this.Controls.Add(this.lbl_Price);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_Id);
            this.Name = "SomerenUpdate";
            this.Text = "SomerenUpdate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.Label lbl_Stock;
        private System.Windows.Forms.Label lbl_Alcoholic;
        private System.Windows.Forms.Label lbl_TotalSold;
        private System.Windows.Forms.Label lbl_Revenue;
        private System.Windows.Forms.Label lbl_TotalTax;
        private System.Windows.Forms.RadioButton rdb_AlcoholicTrue;
        private System.Windows.Forms.RadioButton rdb_AlcoholicFalse;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.TextBox txt_TotalTax;
        private System.Windows.Forms.TextBox txt_Revenue;
        private System.Windows.Forms.TextBox txt_TotalSold;
        private System.Windows.Forms.TextBox txt_Stock;
        private System.Windows.Forms.TextBox txt_Price;
        private System.Windows.Forms.TextBox txt_Name;
    }
}