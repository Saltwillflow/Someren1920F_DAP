namespace SomerenUI
{
    partial class DeleteActivity
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
            this.txtb_Id = new System.Windows.Forms.TextBox();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_UpdateAct
            // 
            this.btn_UpdateAct.Location = new System.Drawing.Point(12, 75);
            this.btn_UpdateAct.Name = "btn_UpdateAct";
            this.btn_UpdateAct.Size = new System.Drawing.Size(240, 30);
            this.btn_UpdateAct.TabIndex = 17;
            this.btn_UpdateAct.Text = "Delete Activity";
            this.btn_UpdateAct.UseVisualStyleBackColor = true;
            this.btn_UpdateAct.Click += new System.EventHandler(this.btn_UpdateAct_Click);
            // 
            // txtb_Id
            // 
            this.txtb_Id.Location = new System.Drawing.Point(104, 23);
            this.txtb_Id.Name = "txtb_Id";
            this.txtb_Id.Size = new System.Drawing.Size(135, 20);
            this.txtb_Id.TabIndex = 13;
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Location = new System.Drawing.Point(19, 26);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(56, 13);
            this.lbl_Id.TabIndex = 9;
            this.lbl_Id.Text = "Activity Id:";
            // 
            // DeleteActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 138);
            this.Controls.Add(this.btn_UpdateAct);
            this.Controls.Add(this.txtb_Id);
            this.Controls.Add(this.lbl_Id);
            this.Name = "DeleteActivity";
            this.Text = "DeleteActivity";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_UpdateAct;
        private System.Windows.Forms.TextBox txtb_Id;
        private System.Windows.Forms.Label lbl_Id;
    }
}