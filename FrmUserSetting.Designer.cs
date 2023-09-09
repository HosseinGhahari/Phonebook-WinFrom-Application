namespace MyContacts
{
    partial class FrmUserSetting
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
            this.DgUsers = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnRemoveUsers = new System.Windows.Forms.Button();
            this.BtnUpdateUsers = new System.Windows.Forms.Button();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgUsers)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgUsers
            // 
            this.DgUsers.AllowUserToAddRows = false;
            this.DgUsers.AllowUserToDeleteRows = false;
            this.DgUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgUsers.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DgUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserId,
            this.UserName,
            this.Password});
            this.DgUsers.Location = new System.Drawing.Point(31, 163);
            this.DgUsers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DgUsers.Name = "DgUsers";
            this.DgUsers.ReadOnly = true;
            this.DgUsers.RowHeadersWidth = 51;
            this.DgUsers.RowTemplate.Height = 24;
            this.DgUsers.Size = new System.Drawing.Size(660, 320);
            this.DgUsers.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnRemoveUsers);
            this.groupBox1.Controls.Add(this.BtnUpdateUsers);
            this.groupBox1.Location = new System.Drawing.Point(31, 32);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(660, 103);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Management";
            // 
            // BtnRemoveUsers
            // 
            this.BtnRemoveUsers.Location = new System.Drawing.Point(177, 35);
            this.BtnRemoveUsers.Name = "BtnRemoveUsers";
            this.BtnRemoveUsers.Size = new System.Drawing.Size(127, 49);
            this.BtnRemoveUsers.TabIndex = 1;
            this.BtnRemoveUsers.Text = "Delete";
            this.BtnRemoveUsers.UseVisualStyleBackColor = true;
            this.BtnRemoveUsers.Click += new System.EventHandler(this.BtnRemoveUsers_Click);
            // 
            // BtnUpdateUsers
            // 
            this.BtnUpdateUsers.Location = new System.Drawing.Point(349, 33);
            this.BtnUpdateUsers.Name = "BtnUpdateUsers";
            this.BtnUpdateUsers.Size = new System.Drawing.Size(127, 49);
            this.BtnUpdateUsers.TabIndex = 0;
            this.BtnUpdateUsers.Text = "Edit";
            this.BtnUpdateUsers.UseVisualStyleBackColor = true;
            this.BtnUpdateUsers.Click += new System.EventHandler(this.BtnUpdateUsers_Click);
            // 
            // UserId
            // 
            this.UserId.DataPropertyName = "UserId";
            this.UserId.HeaderText = "آی دی";
            this.UserId.MinimumWidth = 6;
            this.UserId.Name = "UserId";
            this.UserId.ReadOnly = true;
            this.UserId.Visible = false;
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "User Name";
            this.UserName.MinimumWidth = 6;
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            // 
            // Password
            // 
            this.Password.DataPropertyName = "Password";
            this.Password.HeaderText = "Password";
            this.Password.MinimumWidth = 6;
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            // 
            // FrmUserSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(717, 508);
            this.Controls.Add(this.DgUsers);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("IRANSans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmUserSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Management";
            this.Load += new System.EventHandler(this.FrmUserSetting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgUsers)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnRemoveUsers;
        private System.Windows.Forms.Button BtnUpdateUsers;
        public System.Windows.Forms.DataGridView DgUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
    }
}