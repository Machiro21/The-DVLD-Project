﻿namespace DVLD_My_Version__PresentationLayer.Forms
{
    partial class frmAddPerson
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
            this.ctrAddorUpdateUserInfo1 = new DVLD_My_Version__PresentationLayer.Controlers.ctrAddOrUpdateUserInfo();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(372, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add New Person";
            // 
            // ctrAddorUpdateUserInfo1
            // 
            this.ctrAddorUpdateUserInfo1.Location = new System.Drawing.Point(34, -1);
            this.ctrAddorUpdateUserInfo1.Name = "ctrAddorUpdateUserInfo1";
            this.ctrAddorUpdateUserInfo1.Size = new System.Drawing.Size(1018, 611);
            this.ctrAddorUpdateUserInfo1.TabIndex = 0;
            // 
            // frmAddPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 589);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrAddorUpdateUserInfo1);
            this.Name = "frmAddPerson";
            this.Text = "frmAddPerson";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controlers.ctrAddOrUpdateUserInfo ctrAddorUpdateUserInfo1;
        private System.Windows.Forms.Label label1;
    }
}