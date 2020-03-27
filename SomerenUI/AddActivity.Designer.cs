namespace SomerenUI
{
    partial class AddActivity
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
            this.btn_UpdateAct = new System.Windows.Forms.Button();
            this.txtb_Description = new System.Windows.Forms.TextBox();
            this.txtb_StudentsAmmount = new System.Windows.Forms.TextBox();
            this.txtb_GuidanceAmmount = new System.Windows.Forms.TextBox();
            this.lbl_GuidanceAmmount = new System.Windows.Forms.Label();
            this.lbl_StudentAmmount = new System.Windows.Forms.Label();
            this.lbl_Description = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_UpdateAct
            // 
            this.btn_UpdateAct.Location = new System.Drawing.Point(178, 324);
            this.btn_UpdateAct.Name = "btn_UpdateAct";
            this.btn_UpdateAct.Size = new System.Drawing.Size(240, 30);
            this.btn_UpdateAct.TabIndex = 17;
            this.btn_UpdateAct.Text = "Add Activity";
            this.btn_UpdateAct.UseVisualStyleBackColor = true;
            this.btn_UpdateAct.Click += new System.EventHandler(this.btn_UpdateAct_Click);
            // 
            // txtb_Description
            // 
            this.txtb_Description.Location = new System.Drawing.Point(233, 37);
            this.txtb_Description.Name = "txtb_Description";
            this.txtb_Description.Size = new System.Drawing.Size(139, 20);
            this.txtb_Description.TabIndex = 16;
            // 
            // txtb_StudentsAmmount
            // 
            this.txtb_StudentsAmmount.Location = new System.Drawing.Point(235, 117);
            this.txtb_StudentsAmmount.Name = "txtb_StudentsAmmount";
            this.txtb_StudentsAmmount.Size = new System.Drawing.Size(137, 20);
            this.txtb_StudentsAmmount.TabIndex = 15;
            // 
            // txtb_GuidanceAmmount
            // 
            this.txtb_GuidanceAmmount.Location = new System.Drawing.Point(233, 202);
            this.txtb_GuidanceAmmount.Name = "txtb_GuidanceAmmount";
            this.txtb_GuidanceAmmount.Size = new System.Drawing.Size(137, 20);
            this.txtb_GuidanceAmmount.TabIndex = 14;
            // 
            // lbl_GuidanceAmmount
            // 
            this.lbl_GuidanceAmmount.AutoSize = true;
            this.lbl_GuidanceAmmount.Location = new System.Drawing.Point(119, 207);
            this.lbl_GuidanceAmmount.Name = "lbl_GuidanceAmmount";
            this.lbl_GuidanceAmmount.Size = new System.Drawing.Size(115, 13);
            this.lbl_GuidanceAmmount.TabIndex = 12;
            this.lbl_GuidanceAmmount.Text = "Ammount of Guidance:";
            // 
            // lbl_StudentAmmount
            // 
            this.lbl_StudentAmmount.AutoSize = true;
            this.lbl_StudentAmmount.Location = new System.Drawing.Point(121, 120);
            this.lbl_StudentAmmount.Name = "lbl_StudentAmmount";
            this.lbl_StudentAmmount.Size = new System.Drawing.Size(111, 13);
            this.lbl_StudentAmmount.TabIndex = 11;
            this.lbl_StudentAmmount.Text = "Ammount of Students:";
            // 
            // lbl_Description
            // 
            this.lbl_Description.AutoSize = true;
            this.lbl_Description.Location = new System.Drawing.Point(148, 42);
            this.lbl_Description.Name = "lbl_Description";
            this.lbl_Description.Size = new System.Drawing.Size(63, 13);
            this.lbl_Description.TabIndex = 10;
            this.lbl_Description.Text = "Description:";
            // 
            // AddActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 402);
            this.Controls.Add(this.btn_UpdateAct);
            this.Controls.Add(this.txtb_Description);
            this.Controls.Add(this.txtb_StudentsAmmount);
            this.Controls.Add(this.txtb_GuidanceAmmount);
            this.Controls.Add(this.lbl_GuidanceAmmount);
            this.Controls.Add(this.lbl_StudentAmmount);
            this.Controls.Add(this.lbl_Description);
            this.Name = "AddActivity";
            this.Text = "AddActivity";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_UpdateAct;
        private System.Windows.Forms.TextBox txtb_Description;
        private System.Windows.Forms.TextBox txtb_StudentsAmmount;
        private System.Windows.Forms.TextBox txtb_GuidanceAmmount;
        private System.Windows.Forms.Label lbl_GuidanceAmmount;
        private System.Windows.Forms.Label lbl_StudentAmmount;
        private System.Windows.Forms.Label lbl_Description;
    }
}