namespace MyContacts
{
    partial class FrmUpdateUser
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
            this.UpdateTxtPassRepeated = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.UpdateTxtPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.UpdateTxtUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnUserUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UpdateTxtPassRepeated
            // 
            this.UpdateTxtPassRepeated.AcceptsReturn = true;
            this.UpdateTxtPassRepeated.Location = new System.Drawing.Point(134, 319);
            this.UpdateTxtPassRepeated.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.UpdateTxtPassRepeated.Multiline = true;
            this.UpdateTxtPassRepeated.Name = "UpdateTxtPassRepeated";
            this.UpdateTxtPassRepeated.Size = new System.Drawing.Size(276, 45);
            this.UpdateTxtPassRepeated.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 26);
            this.label3.TabIndex = 20;
            this.label3.Text = "Repeat New Password :";
            // 
            // UpdateTxtPass
            // 
            this.UpdateTxtPass.Location = new System.Drawing.Point(134, 212);
            this.UpdateTxtPass.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.UpdateTxtPass.Multiline = true;
            this.UpdateTxtPass.Name = "UpdateTxtPass";
            this.UpdateTxtPass.Size = new System.Drawing.Size(276, 45);
            this.UpdateTxtPass.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 26);
            this.label2.TabIndex = 18;
            this.label2.Text = "New Password :";
            // 
            // UpdateTxtUser
            // 
            this.UpdateTxtUser.Location = new System.Drawing.Point(134, 109);
            this.UpdateTxtUser.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.UpdateTxtUser.Multiline = true;
            this.UpdateTxtUser.Name = "UpdateTxtUser";
            this.UpdateTxtUser.Size = new System.Drawing.Size(276, 45);
            this.UpdateTxtUser.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 26);
            this.label1.TabIndex = 16;
            this.label1.Text = "User Name :";
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(144, 441);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(117, 55);
            this.BtnExit.TabIndex = 15;
            this.BtnExit.Text = "Cancel";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnUserUpdate
            // 
            this.BtnUserUpdate.Location = new System.Drawing.Point(284, 441);
            this.BtnUserUpdate.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BtnUserUpdate.Name = "BtnUserUpdate";
            this.BtnUserUpdate.Size = new System.Drawing.Size(117, 55);
            this.BtnUserUpdate.TabIndex = 14;
            this.BtnUserUpdate.Text = "Update";
            this.BtnUserUpdate.UseVisualStyleBackColor = true;
            this.BtnUserUpdate.Click += new System.EventHandler(this.BtnUserUpdate_Click);
            // 
            // FrmUpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 594);
            this.Controls.Add(this.UpdateTxtPassRepeated);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UpdateTxtPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UpdateTxtUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnUserUpdate);
            this.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "FrmUpdateUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox UpdateTxtPassRepeated;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox UpdateTxtPass;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox UpdateTxtUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnUserUpdate;
    }
}