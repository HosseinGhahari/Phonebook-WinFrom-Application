namespace MyContacts
{
    partial class FrmAddOrUpdate
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.TxtAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Txtphone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtAge = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtFamily = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAge)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnExit);
            this.groupBox1.Controls.Add(this.BtnSubmit);
            this.groupBox1.Controls.Add(this.TxtAddress);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Txtphone);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtEmail);
            this.groupBox1.Controls.Add(this.TxtAge);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtFamily);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtName);
            this.groupBox1.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(30, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(644, 490);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Info";
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(170, 399);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(152, 50);
            this.BtnExit.TabIndex = 15;
            this.BtnExit.Text = "Cancel";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.Location = new System.Drawing.Point(365, 399);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(152, 50);
            this.BtnSubmit.TabIndex = 14;
            this.BtnSubmit.Text = "Login";
            this.BtnSubmit.UseVisualStyleBackColor = true;
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // TxtAddress
            // 
            this.TxtAddress.Location = new System.Drawing.Point(108, 253);
            this.TxtAddress.Multiline = true;
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(480, 102);
            this.TxtAddress.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 30);
            this.label6.TabIndex = 12;
            this.label6.Text = "Address";
            // 
            // Txtphone
            // 
            this.Txtphone.CausesValidation = false;
            this.Txtphone.Location = new System.Drawing.Point(431, 122);
            this.Txtphone.Name = "Txtphone";
            this.Txtphone.Size = new System.Drawing.Size(173, 33);
            this.Txtphone.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(339, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 30);
            this.label5.TabIndex = 10;
            this.label5.Text = "Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 30);
            this.label4.TabIndex = 9;
            this.label4.Text = "Email ";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(108, 190);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(496, 33);
            this.TxtEmail.TabIndex = 8;
            // 
            // TxtAge
            // 
            this.TxtAge.Location = new System.Drawing.Point(108, 120);
            this.TxtAge.Name = "TxtAge";
            this.TxtAge.Size = new System.Drawing.Size(173, 33);
            this.TxtAge.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "Age";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "Last Name";
            // 
            // TxtFamily
            // 
            this.TxtFamily.Location = new System.Drawing.Point(431, 65);
            this.TxtFamily.Name = "TxtFamily";
            this.TxtFamily.Size = new System.Drawing.Size(173, 33);
            this.TxtFamily.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(108, 65);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(173, 33);
            this.TxtName.TabIndex = 0;
            // 
            // FrmAddOrUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 531);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("IRANSans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmAddOrUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmAddOrUpdate";
            this.Load += new System.EventHandler(this.FrmAddOrUpdate_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAge)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnSubmit;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox TxtFamily;
        public System.Windows.Forms.TextBox TxtName;
        public System.Windows.Forms.TextBox Txtphone;
        public System.Windows.Forms.TextBox TxtEmail;
        public System.Windows.Forms.NumericUpDown TxtAge;
        public System.Windows.Forms.TextBox TxtAddress;
    }
}