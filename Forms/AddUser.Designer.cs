namespace MyContacts
{
    partial class FrmAddUser
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
            this.AddTxtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddTxtUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.AddTxtRepeatPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddTxtPassword
            // 
            this.AddTxtPassword.Location = new System.Drawing.Point(117, 210);
            this.AddTxtPassword.Multiline = true;
            this.AddTxtPassword.Name = "AddTxtPassword";
            this.AddTxtPassword.PasswordChar = '*';
            this.AddTxtPassword.Size = new System.Drawing.Size(246, 45);
            this.AddTxtPassword.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 30);
            this.label2.TabIndex = 10;
            this.label2.Text = "Password :";
            // 
            // AddTxtUser
            // 
            this.AddTxtUser.Location = new System.Drawing.Point(117, 104);
            this.AddTxtUser.Multiline = true;
            this.AddTxtUser.Name = "AddTxtUser";
            this.AddTxtUser.Size = new System.Drawing.Size(246, 45);
            this.AddTxtUser.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 30);
            this.label1.TabIndex = 8;
            this.label1.Text = "User Name :";
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(126, 414);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(104, 51);
            this.BtnExit.TabIndex = 7;
            this.BtnExit.Text = "Cancel";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(249, 414);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(104, 51);
            this.BtnAdd.TabIndex = 6;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // AddTxtRepeatPass
            // 
            this.AddTxtRepeatPass.Location = new System.Drawing.Point(117, 317);
            this.AddTxtRepeatPass.Multiline = true;
            this.AddTxtRepeatPass.Name = "AddTxtRepeatPass";
            this.AddTxtRepeatPass.PasswordChar = '*';
            this.AddTxtRepeatPass.Size = new System.Drawing.Size(246, 45);
            this.AddTxtRepeatPass.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 30);
            this.label3.TabIndex = 12;
            this.label3.Text = "Repeat Password :";
            // 
            // FrmAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 543);
            this.Controls.Add(this.AddTxtRepeatPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AddTxtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddTxtUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnAdd);
            this.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "FrmAddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox AddTxtPassword;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox AddTxtUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnExit;
        public System.Windows.Forms.TextBox AddTxtRepeatPass;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button BtnAdd;
    }
}