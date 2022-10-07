namespace skyetechCBHRAP
{
    partial class maindashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(maindashboard));
            this.panel_sidemenu = new System.Windows.Forms.Panel();
            this.lbl_copyright = new System.Windows.Forms.Label();
            this.lbl_datetime = new System.Windows.Forms.Label();
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.panel_nav = new System.Windows.Forms.Panel();
            this.lbl_mainnav = new System.Windows.Forms.Label();
            this.btn_databasemanager = new System.Windows.Forms.Button();
            this.btn_barangaylist = new System.Windows.Forms.Button();
            this.btn_dashboard = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.panel_top = new System.Windows.Forms.Panel();
            this.panel_mainpanel = new System.Windows.Forms.Panel();
            this.timer_datetime = new System.Windows.Forms.Timer(this.components);
            this.panel_sidemenu.SuspendLayout();
            this.panel_nav.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_sidemenu
            // 
            this.panel_sidemenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panel_sidemenu.Controls.Add(this.lbl_copyright);
            this.panel_sidemenu.Controls.Add(this.lbl_datetime);
            this.panel_sidemenu.Controls.Add(this.lbl_welcome);
            this.panel_sidemenu.Controls.Add(this.panel_nav);
            this.panel_sidemenu.Controls.Add(this.btn_databasemanager);
            this.panel_sidemenu.Controls.Add(this.btn_barangaylist);
            this.panel_sidemenu.Controls.Add(this.btn_dashboard);
            this.panel_sidemenu.Controls.Add(this.btn_logout);
            this.panel_sidemenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_sidemenu.Location = new System.Drawing.Point(0, 0);
            this.panel_sidemenu.Name = "panel_sidemenu";
            this.panel_sidemenu.Size = new System.Drawing.Size(263, 1080);
            this.panel_sidemenu.TabIndex = 0;
            // 
            // lbl_copyright
            // 
            this.lbl_copyright.AutoSize = true;
            this.lbl_copyright.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_copyright.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_copyright.Location = new System.Drawing.Point(9, 1056);
            this.lbl_copyright.Name = "lbl_copyright";
            this.lbl_copyright.Size = new System.Drawing.Size(244, 15);
            this.lbl_copyright.TabIndex = 7;
            this.lbl_copyright.Text = "© 2022 - 2022 Skyetech - All Rights Reserved.";
            // 
            // lbl_datetime
            // 
            this.lbl_datetime.AutoSize = true;
            this.lbl_datetime.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_datetime.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_datetime.Location = new System.Drawing.Point(3, 204);
            this.lbl_datetime.Name = "lbl_datetime";
            this.lbl_datetime.Size = new System.Drawing.Size(144, 17);
            this.lbl_datetime.TabIndex = 6;
            this.lbl_datetime.Text = "MM/dd/yyyy HH:mm:ss";
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.Font = new System.Drawing.Font("FuturaBT-BoldCondensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcome.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_welcome.Location = new System.Drawing.Point(52, 83);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(211, 32);
            this.lbl_welcome.TabIndex = 5;
            this.lbl_welcome.Text = "Welcome to CBHRAP";
            // 
            // panel_nav
            // 
            this.panel_nav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.panel_nav.Controls.Add(this.lbl_mainnav);
            this.panel_nav.Location = new System.Drawing.Point(-12, 224);
            this.panel_nav.Name = "panel_nav";
            this.panel_nav.Size = new System.Drawing.Size(275, 44);
            this.panel_nav.TabIndex = 2;
            // 
            // lbl_mainnav
            // 
            this.lbl_mainnav.AutoSize = true;
            this.lbl_mainnav.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mainnav.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_mainnav.Location = new System.Drawing.Point(24, 14);
            this.lbl_mainnav.Name = "lbl_mainnav";
            this.lbl_mainnav.Size = new System.Drawing.Size(111, 17);
            this.lbl_mainnav.TabIndex = 0;
            this.lbl_mainnav.Text = "Main Navigation";
            // 
            // btn_databasemanager
            // 
            this.btn_databasemanager.FlatAppearance.BorderSize = 0;
            this.btn_databasemanager.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btn_databasemanager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_databasemanager.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_databasemanager.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_databasemanager.Image = ((System.Drawing.Image)(resources.GetObject("btn_databasemanager.Image")));
            this.btn_databasemanager.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_databasemanager.Location = new System.Drawing.Point(12, 370);
            this.btn_databasemanager.Name = "btn_databasemanager";
            this.btn_databasemanager.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btn_databasemanager.Size = new System.Drawing.Size(251, 40);
            this.btn_databasemanager.TabIndex = 3;
            this.btn_databasemanager.Text = "Database Manager";
            this.btn_databasemanager.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_databasemanager.UseVisualStyleBackColor = true;
            this.btn_databasemanager.Click += new System.EventHandler(this.btn_databasemanager_Click);
            // 
            // btn_barangaylist
            // 
            this.btn_barangaylist.FlatAppearance.BorderSize = 0;
            this.btn_barangaylist.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btn_barangaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_barangaylist.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_barangaylist.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_barangaylist.Image = ((System.Drawing.Image)(resources.GetObject("btn_barangaylist.Image")));
            this.btn_barangaylist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_barangaylist.Location = new System.Drawing.Point(12, 324);
            this.btn_barangaylist.Name = "btn_barangaylist";
            this.btn_barangaylist.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btn_barangaylist.Size = new System.Drawing.Size(251, 40);
            this.btn_barangaylist.TabIndex = 2;
            this.btn_barangaylist.Text = "Barangay List";
            this.btn_barangaylist.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_barangaylist.UseVisualStyleBackColor = true;
            this.btn_barangaylist.Click += new System.EventHandler(this.btn_barangaylist_Click);
            // 
            // btn_dashboard
            // 
            this.btn_dashboard.FlatAppearance.BorderSize = 0;
            this.btn_dashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btn_dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dashboard.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dashboard.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_dashboard.Image = ((System.Drawing.Image)(resources.GetObject("btn_dashboard.Image")));
            this.btn_dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dashboard.Location = new System.Drawing.Point(12, 278);
            this.btn_dashboard.Name = "btn_dashboard";
            this.btn_dashboard.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btn_dashboard.Size = new System.Drawing.Size(251, 40);
            this.btn_dashboard.TabIndex = 1;
            this.btn_dashboard.Text = "Dashboard";
            this.btn_dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_dashboard.UseVisualStyleBackColor = true;
            this.btn_dashboard.Click += new System.EventHandler(this.btn_dashboard_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.FlatAppearance.BorderSize = 0;
            this.btn_logout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_logout.Image = ((System.Drawing.Image)(resources.GetObject("btn_logout.Image")));
            this.btn_logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logout.Location = new System.Drawing.Point(12, 999);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btn_logout.Size = new System.Drawing.Size(251, 40);
            this.btn_logout.TabIndex = 0;
            this.btn_logout.Text = "Logout";
            this.btn_logout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(263, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(1657, 56);
            this.panel_top.TabIndex = 1;
            // 
            // panel_mainpanel
            // 
            this.panel_mainpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.panel_mainpanel.Location = new System.Drawing.Point(263, 56);
            this.panel_mainpanel.Name = "panel_mainpanel";
            this.panel_mainpanel.Size = new System.Drawing.Size(1657, 1024);
            this.panel_mainpanel.TabIndex = 2;
            // 
            // timer_datetime
            // 
            this.timer_datetime.Tick += new System.EventHandler(this.timer_datetime_Tick);
            // 
            // maindashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.panel_top);
            this.Controls.Add(this.panel_sidemenu);
            this.Controls.Add(this.panel_mainpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "maindashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "maindashboard";
            this.panel_sidemenu.ResumeLayout(false);
            this.panel_sidemenu.PerformLayout();
            this.panel_nav.ResumeLayout(false);
            this.panel_nav.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_sidemenu;
        private System.Windows.Forms.Button btn_databasemanager;
        private System.Windows.Forms.Button btn_barangaylist;
        private System.Windows.Forms.Button btn_dashboard;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.Panel panel_nav;
        private System.Windows.Forms.Label lbl_mainnav;
        private System.Windows.Forms.Label lbl_datetime;
        private System.Windows.Forms.Label lbl_copyright;
        private System.Windows.Forms.Panel panel_mainpanel;
        private System.Windows.Forms.Timer timer_datetime;
    }
}