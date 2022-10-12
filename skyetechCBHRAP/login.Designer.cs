namespace skyetechCBHRAP
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.panel_login = new System.Windows.Forms.Panel();
            this.lbl_copyright = new System.Windows.Forms.Label();
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.input_password = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.input_user = new System.Windows.Forms.TextBox();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_program = new System.Windows.Forms.Label();
            this.lbl_company = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.panel_login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_login
            // 
            this.panel_login.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panel_login.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_login.Controls.Add(this.lbl_copyright);
            this.panel_login.Controls.Add(this.pic_logo);
            this.panel_login.Controls.Add(this.btn_login);
            this.panel_login.Controls.Add(this.input_password);
            this.panel_login.Controls.Add(this.lbl_password);
            this.panel_login.Controls.Add(this.input_user);
            this.panel_login.Controls.Add(this.lbl_username);
            this.panel_login.Controls.Add(this.lbl_program);
            this.panel_login.Controls.Add(this.lbl_company);
            this.panel_login.Location = new System.Drawing.Point(621, 341);
            this.panel_login.Name = "panel_login";
            this.panel_login.Size = new System.Drawing.Size(668, 365);
            this.panel_login.TabIndex = 0;
            // 
            // lbl_copyright
            // 
            this.lbl_copyright.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_copyright.AutoSize = true;
            this.lbl_copyright.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_copyright.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_copyright.Location = new System.Drawing.Point(217, 348);
            this.lbl_copyright.Name = "lbl_copyright";
            this.lbl_copyright.Size = new System.Drawing.Size(244, 15);
            this.lbl_copyright.TabIndex = 8;
            this.lbl_copyright.Text = "© 2022 - 2022 Skyetech - All Rights Reserved.";
            this.lbl_copyright.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pic_logo
            // 
            this.pic_logo.Image = ((System.Drawing.Image)(resources.GetObject("pic_logo.Image")));
            this.pic_logo.Location = new System.Drawing.Point(61, 129);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Size = new System.Drawing.Size(96, 96);
            this.pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_logo.TabIndex = 7;
            this.pic_logo.TabStop = false;
            // 
            // btn_login
            // 
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_login.Image = ((System.Drawing.Image)(resources.GetObject("btn_login.Image")));
            this.btn_login.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_login.Location = new System.Drawing.Point(436, 278);
            this.btn_login.Name = "btn_login";
            this.btn_login.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btn_login.Size = new System.Drawing.Size(232, 48);
            this.btn_login.TabIndex = 3;
            this.btn_login.Text = "Login";
            this.btn_login.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // input_password
            // 
            this.input_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.input_password.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_password.Location = new System.Drawing.Point(260, 238);
            this.input_password.Name = "input_password";
            this.input_password.PasswordChar = '●';
            this.input_password.Size = new System.Drawing.Size(268, 22);
            this.input_password.TabIndex = 2;
            this.input_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_password.Location = new System.Drawing.Point(256, 213);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(79, 21);
            this.lbl_password.TabIndex = 4;
            this.lbl_password.Text = "Password:";
            // 
            // input_user
            // 
            this.input_user.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.input_user.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_user.Location = new System.Drawing.Point(260, 188);
            this.input_user.Name = "input_user";
            this.input_user.Size = new System.Drawing.Size(268, 22);
            this.input_user.TabIndex = 1;
            this.input_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_username.Location = new System.Drawing.Point(256, 163);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(84, 21);
            this.lbl_username.TabIndex = 2;
            this.lbl_username.Text = "Username:";
            // 
            // lbl_program
            // 
            this.lbl_program.AutoSize = true;
            this.lbl_program.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_program.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_program.Location = new System.Drawing.Point(253, 103);
            this.lbl_program.Name = "lbl_program";
            this.lbl_program.Size = new System.Drawing.Size(287, 13);
            this.lbl_program.TabIndex = 1;
            this.lbl_program.Text = "Community Based Hazard Assessment  Profiling System";
            // 
            // lbl_company
            // 
            this.lbl_company.AutoSize = true;
            this.lbl_company.Font = new System.Drawing.Font("FuturaBT-BoldCondensed", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_company.ForeColor = System.Drawing.Color.Snow;
            this.lbl_company.Location = new System.Drawing.Point(243, 26);
            this.lbl_company.Name = "lbl_company";
            this.lbl_company.Size = new System.Drawing.Size(228, 77);
            this.lbl_company.TabIndex = 0;
            this.lbl_company.Text = "Skyetech";
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.Location = new System.Drawing.Point(1870, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(50, 47);
            this.btn_close.TabIndex = 1;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // login
            // 
            this.AcceptButton = this.btn_login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.panel_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.panel_login.ResumeLayout(false);
            this.panel_login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_login;
        private System.Windows.Forms.Label lbl_program;
        private System.Windows.Forms.Label lbl_company;
        private System.Windows.Forms.TextBox input_password;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox input_user;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.PictureBox pic_logo;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label lbl_copyright;
    }
}