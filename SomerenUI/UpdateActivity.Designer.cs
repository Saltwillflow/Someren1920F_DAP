namespace SomerenUI
{
    partial class UpdateActivity
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
            this.lbl_Description = new System.Windows.Forms.Label();
            this.lbl_StudentAmmount = new System.Windows.Forms.Label();
            this.lbl_GuidanceAmmount = new System.Windows.Forms.Label();
            this.txtb_Id = new System.Windows.Forms.TextBox();
            this.txtb_GuidanceAmmount = new System.Windows.Forms.TextBox();
            this.txtb_StudentsAmmount = new System.Windows.Forms.TextBox();
            this.txtb_Description = new System.Windows.Forms.TextBox();
            this.btn_UpdateAct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Location = new System.Drawing.Point(36, 54);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(56, 13);
            this.lbl_Id.TabIndex = 0;
            this.lbl_Id.Text = "Activity Id:";
            this.lbl_Id.Click += new System.EventHandler(this.lbl_Id_Click);
            // 
            // lbl_Description
            // 
            this.lbl_Description.AutoSize = true;
            this.lbl_Description.Location = new System.Drawing.Point(36, 203);
            this.lbl_Description.Name = "lbl_Description";
            this.lbl_Description.Size = new System.Drawing.Size(63, 13);
            this.lbl_Description.TabIndex = 1;
            this.lbl_Description.Text = "Description:";
            this.lbl_Description.Click += new System.EventHandler(this.lbl_Description_Click);
            // 
            // lbl_StudentAmmount
            // 
            this.lbl_StudentAmmount.AutoSize = true;
            this.lbl_StudentAmmount.Location = new System.Drawing.Point(283, 50);
            this.lbl_StudentAmmount.Name = "lbl_StudentAmmount";
            this.lbl_StudentAmmount.Size = new System.Drawing.Size(111, 13);
            this.lbl_StudentAmmount.TabIndex = 2;
            this.lbl_StudentAmmount.Text = "Ammount of Students:";
            this.lbl_StudentAmmount.Click += new System.EventHandler(this.lbl_StudentAmmount_Click);
            // 
            // lbl_GuidanceAmmount
            // 
            this.lbl_GuidanceAmmount.AutoSize = true;
            this.lbl_GuidanceAmmount.Location = new System.Drawing.Point(283, 203);
            this.lbl_GuidanceAmmount.Name = "lbl_GuidanceAmmount";
            this.lbl_GuidanceAmmount.Size = new System.Drawing.Size(115, 13);
            this.lbl_GuidanceAmmount.TabIndex = 3;
            this.lbl_GuidanceAmmount.Text = "Ammount of Guidance:";
            this.lbl_GuidanceAmmount.Click += new System.EventHandler(this.lbl_GuidanceAmmount_Click);
            // 
            // txtb_Id
            // 
            this.txtb_Id.Location = new System.Drawing.Point(121, 50);
            this.txtb_Id.Name = "txtb_Id";
            this.txtb_Id.Size = new System.Drawing.Size(135, 20);
            this.txtb_Id.TabIndex = 4;
            this.txtb_Id.TextChanged += new System.EventHandler(this.txtb_Id_TextChanged);
            // 
            // txtb_GuidanceAmmount
            // 
            this.txtb_GuidanceAmmount.Location = new System.Drawing.Point(397, 198);
            this.txtb_GuidanceAmmount.Name = "txtb_GuidanceAmmount";
            this.txtb_GuidanceAmmount.Size = new System.Drawing.Size(137, 20);
            this.txtb_GuidanceAmmount.TabIndex = 5;
            this.txtb_GuidanceAmmount.TextChanged += new System.EventHandler(this.txtb_GuidanceAmmount_TextChanged);
            // 
            // txtb_StudentsAmmount
            // 
            this.txtb_StudentsAmmount.Location = new System.Drawing.Point(397, 47);
            this.txtb_StudentsAmmount.Name = "txtb_StudentsAmmount";
            this.txtb_StudentsAmmount.Size = new System.Drawing.Size(137, 20);
            this.txtb_StudentsAmmount.TabIndex = 6;
            this.txtb_StudentsAmmount.TextChanged += new System.EventHandler(this.txtb_StudentsAmmount_TextChanged);
            // 
            // txtb_Description
            // 
            this.txtb_Description.Location = new System.Drawing.Point(121, 198);
            this.txtb_Description.Name = "txtb_Description";
            this.txtb_Description.Size = new System.Drawing.Size(135, 20);
            this.txtb_Description.TabIndex = 7;
            this.txtb_Description.TextChanged += new System.EventHandler(this.txtb_Description_TextChanged);
            // 
            // btn_UpdateAct
            // 
            this.btn_UpdateAct.Location = new System.Drawing.Point(191, 333);
            this.btn_UpdateAct.Name = "btn_UpdateAct";
            this.btn_UpdateAct.Size = new System.Drawing.Size(240, 30);
            this.btn_UpdateAct.TabIndex = 8;
            this.btn_UpdateAct.Text = "Update Activity";
            this.btn_UpdateAct.UseVisualStyleBackColor = true;
            this.btn_UpdateAct.Click += new System.EventHandler(this.btn_AddAct_Click);
            // 
            // UpdateActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 420);
            this.Controls.Add(this.btn_UpdateAct);
            this.Controls.Add(this.txtb_Description);
            this.Controls.Add(this.txtb_StudentsAmmount);
            this.Controls.Add(this.txtb_GuidanceAmmount);
            this.Controls.Add(this.txtb_Id);
            this.Controls.Add(this.lbl_GuidanceAmmount);
            this.Controls.Add(this.lbl_StudentAmmount);
            this.Controls.Add(this.lbl_Description);
            this.Controls.Add(this.lbl_Id);
            this.Name = "UpdateActivity";
            this.Text = "UpdateActivity";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.Label lbl_Description;
        private System.Windows.Forms.Label lbl_StudentAmmount;
        private System.Windows.Forms.Label lbl_GuidanceAmmount;
        private System.Windows.Forms.TextBox txtb_Id;
        private System.Windows.Forms.TextBox txtb_GuidanceAmmount;
        private System.Windows.Forms.TextBox txtb_StudentsAmmount;
        private System.Windows.Forms.TextBox txtb_Description;
        private System.Windows.Forms.Button btn_UpdateAct;
    }
}