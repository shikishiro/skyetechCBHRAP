namespace skyetechCBHRAP
{
    partial class databasemanager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(databasemanager));
            this.panel_sidenav = new System.Windows.Forms.Panel();
            this.txt_barangay = new System.Windows.Forms.TextBox();
            this.panel_nav = new System.Windows.Forms.Panel();
            this.lbl_mainnav = new System.Windows.Forms.Label();
            this.btn_initiatedata = new System.Windows.Forms.Button();
            this.dropdown_barangaylist = new System.Windows.Forms.ComboBox();
            this.panel_editbarangay = new System.Windows.Forms.Panel();
            this.display_barangayname = new System.Windows.Forms.Label();
            this.lbl_brgy = new System.Windows.Forms.Label();
            this.grp_population = new System.Windows.Forms.GroupBox();
            this.lbl_female = new System.Windows.Forms.Label();
            this.lbl_male = new System.Windows.Forms.Label();
            this.lbl_seniorcitizen = new System.Windows.Forms.Label();
            this.lbl_adult = new System.Windows.Forms.Label();
            this.lbl_infant = new System.Windows.Forms.Label();
            this.input_infant = new System.Windows.Forms.TextBox();
            this.input_adult = new System.Windows.Forms.TextBox();
            this.input_seniorcitizen = new System.Windows.Forms.TextBox();
            this.input_male = new System.Windows.Forms.TextBox();
            this.input_female = new System.Windows.Forms.TextBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.panel_sidenav.SuspendLayout();
            this.panel_nav.SuspendLayout();
            this.panel_editbarangay.SuspendLayout();
            this.grp_population.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_sidenav
            // 
            this.panel_sidenav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panel_sidenav.Controls.Add(this.txt_barangay);
            this.panel_sidenav.Controls.Add(this.panel_nav);
            this.panel_sidenav.Controls.Add(this.btn_initiatedata);
            this.panel_sidenav.Controls.Add(this.dropdown_barangaylist);
            this.panel_sidenav.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_sidenav.Location = new System.Drawing.Point(0, 0);
            this.panel_sidenav.Name = "panel_sidenav";
            this.panel_sidenav.Size = new System.Drawing.Size(332, 1024);
            this.panel_sidenav.TabIndex = 1;
            // 
            // txt_barangay
            // 
            this.txt_barangay.Location = new System.Drawing.Point(12, 302);
            this.txt_barangay.Name = "txt_barangay";
            this.txt_barangay.Size = new System.Drawing.Size(302, 20);
            this.txt_barangay.TabIndex = 3;
            this.txt_barangay.Visible = false;
            // 
            // panel_nav
            // 
            this.panel_nav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.panel_nav.Controls.Add(this.lbl_mainnav);
            this.panel_nav.Location = new System.Drawing.Point(0, 168);
            this.panel_nav.Name = "panel_nav";
            this.panel_nav.Size = new System.Drawing.Size(332, 44);
            this.panel_nav.TabIndex = 3;
            // 
            // lbl_mainnav
            // 
            this.lbl_mainnav.AutoSize = true;
            this.lbl_mainnav.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mainnav.Location = new System.Drawing.Point(24, 14);
            this.lbl_mainnav.Name = "lbl_mainnav";
            this.lbl_mainnav.Size = new System.Drawing.Size(73, 17);
            this.lbl_mainnav.TabIndex = 0;
            this.lbl_mainnav.Text = "Select Data";
            // 
            // btn_initiatedata
            // 
            this.btn_initiatedata.FlatAppearance.BorderSize = 0;
            this.btn_initiatedata.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btn_initiatedata.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_initiatedata.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_initiatedata.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_initiatedata.Image = ((System.Drawing.Image)(resources.GetObject("btn_initiatedata.Image")));
            this.btn_initiatedata.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_initiatedata.Location = new System.Drawing.Point(81, 256);
            this.btn_initiatedata.Name = "btn_initiatedata";
            this.btn_initiatedata.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btn_initiatedata.Size = new System.Drawing.Size(251, 40);
            this.btn_initiatedata.TabIndex = 2;
            this.btn_initiatedata.Text = "Initiate Data";
            this.btn_initiatedata.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_initiatedata.UseVisualStyleBackColor = true;
            this.btn_initiatedata.Click += new System.EventHandler(this.btn_initiatedata_Click);
            // 
            // dropdown_barangaylist
            // 
            this.dropdown_barangaylist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.dropdown_barangaylist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropdown_barangaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dropdown_barangaylist.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropdown_barangaylist.ForeColor = System.Drawing.SystemColors.Control;
            this.dropdown_barangaylist.FormattingEnabled = true;
            this.dropdown_barangaylist.Items.AddRange(new object[] {
            "Angeles",
            "Balubad",
            "Balugohin",
            "Buhangin",
            "Caridad Ibaba",
            "Caridad Ilaya",
            "Habingan",
            "Inaclagan",
            "Inalig",
            "Kilait",
            "Kulawit",
            "Lakip",
            "Lubi",
            "Lumutan",
            "Magsaysay",
            "Malinao Ibaba",
            "Malinao Ilaya",
            "Malusak",
            "Manggalayan Bundok",
            "Manggalayan Labak",
            "Matanag",
            "Montes Balaon",
            "Montes Kallagan",
            "Ponon",
            "Rizal",
            "San Andres Bundok",
            "San Andres Labak",
            "San Isidro",
            "San Jose Balatok",
            "San Rafael",
            "Sta. Catalina",
            "Sapaan",
            "Sokol",
            "Tagbakin",
            "Talaba",
            "Tinandog",
            "Zone I Poblacion",
            "Zone II Poblacion",
            "Zone III Poblacion",
            "Zone IV Poblacion",
            "Villa Ibaba",
            "Villa Ilaya"});
            this.dropdown_barangaylist.Location = new System.Drawing.Point(12, 218);
            this.dropdown_barangaylist.Name = "dropdown_barangaylist";
            this.dropdown_barangaylist.Size = new System.Drawing.Size(302, 21);
            this.dropdown_barangaylist.TabIndex = 1;
            this.dropdown_barangaylist.SelectedIndexChanged += new System.EventHandler(this.dropdown_barangaylist_SelectedIndexChanged);
            // 
            // panel_editbarangay
            // 
            this.panel_editbarangay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panel_editbarangay.Controls.Add(this.grp_population);
            this.panel_editbarangay.Controls.Add(this.display_barangayname);
            this.panel_editbarangay.Controls.Add(this.lbl_brgy);
            this.panel_editbarangay.Location = new System.Drawing.Point(332, 0);
            this.panel_editbarangay.Name = "panel_editbarangay";
            this.panel_editbarangay.Size = new System.Drawing.Size(1326, 1024);
            this.panel_editbarangay.TabIndex = 2;
            // 
            // display_barangayname
            // 
            this.display_barangayname.AutoSize = true;
            this.display_barangayname.Font = new System.Drawing.Font("FuturaBT-BoldCondensed", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display_barangayname.ForeColor = System.Drawing.SystemColors.Control;
            this.display_barangayname.Location = new System.Drawing.Point(138, 9);
            this.display_barangayname.Name = "display_barangayname";
            this.display_barangayname.Size = new System.Drawing.Size(229, 77);
            this.display_barangayname.TabIndex = 2;
            this.display_barangayname.Text = "####";
            // 
            // lbl_brgy
            // 
            this.lbl_brgy.AutoSize = true;
            this.lbl_brgy.Font = new System.Drawing.Font("FuturaBT-BoldCondensed", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_brgy.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_brgy.Location = new System.Drawing.Point(6, 9);
            this.lbl_brgy.Name = "lbl_brgy";
            this.lbl_brgy.Size = new System.Drawing.Size(149, 77);
            this.lbl_brgy.TabIndex = 1;
            this.lbl_brgy.Text = "Brgy.";
            // 
            // grp_population
            // 
            this.grp_population.Controls.Add(this.btn_update);
            this.grp_population.Controls.Add(this.input_female);
            this.grp_population.Controls.Add(this.input_male);
            this.grp_population.Controls.Add(this.input_seniorcitizen);
            this.grp_population.Controls.Add(this.input_adult);
            this.grp_population.Controls.Add(this.input_infant);
            this.grp_population.Controls.Add(this.lbl_female);
            this.grp_population.Controls.Add(this.lbl_male);
            this.grp_population.Controls.Add(this.lbl_seniorcitizen);
            this.grp_population.Controls.Add(this.lbl_adult);
            this.grp_population.Controls.Add(this.lbl_infant);
            this.grp_population.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grp_population.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_population.ForeColor = System.Drawing.SystemColors.Control;
            this.grp_population.Location = new System.Drawing.Point(151, 168);
            this.grp_population.Name = "grp_population";
            this.grp_population.Size = new System.Drawing.Size(450, 290);
            this.grp_population.TabIndex = 3;
            this.grp_population.TabStop = false;
            this.grp_population.Text = "Total baranggay population";
            // 
            // lbl_female
            // 
            this.lbl_female.AutoSize = true;
            this.lbl_female.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_female.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_female.Location = new System.Drawing.Point(20, 221);
            this.lbl_female.Name = "lbl_female";
            this.lbl_female.Size = new System.Drawing.Size(69, 21);
            this.lbl_female.TabIndex = 19;
            this.lbl_female.Text = "Female:";
            // 
            // lbl_male
            // 
            this.lbl_male.AutoSize = true;
            this.lbl_male.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_male.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_male.Location = new System.Drawing.Point(20, 172);
            this.lbl_male.Name = "lbl_male";
            this.lbl_male.Size = new System.Drawing.Size(52, 21);
            this.lbl_male.TabIndex = 17;
            this.lbl_male.Text = "Male:";
            // 
            // lbl_seniorcitizen
            // 
            this.lbl_seniorcitizen.AutoSize = true;
            this.lbl_seniorcitizen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_seniorcitizen.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_seniorcitizen.Location = new System.Drawing.Point(20, 123);
            this.lbl_seniorcitizen.Name = "lbl_seniorcitizen";
            this.lbl_seniorcitizen.Size = new System.Drawing.Size(120, 21);
            this.lbl_seniorcitizen.TabIndex = 15;
            this.lbl_seniorcitizen.Text = "Senior Citizen:";
            // 
            // lbl_adult
            // 
            this.lbl_adult.AutoSize = true;
            this.lbl_adult.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_adult.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_adult.Location = new System.Drawing.Point(20, 74);
            this.lbl_adult.Name = "lbl_adult";
            this.lbl_adult.Size = new System.Drawing.Size(56, 21);
            this.lbl_adult.TabIndex = 13;
            this.lbl_adult.Text = "Adult:";
            // 
            // lbl_infant
            // 
            this.lbl_infant.AutoSize = true;
            this.lbl_infant.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_infant.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_infant.Location = new System.Drawing.Point(20, 25);
            this.lbl_infant.Name = "lbl_infant";
            this.lbl_infant.Size = new System.Drawing.Size(60, 21);
            this.lbl_infant.TabIndex = 11;
            this.lbl_infant.Text = "Infant:";
            // 
            // input_infant
            // 
            this.input_infant.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.input_infant.Location = new System.Drawing.Point(24, 49);
            this.input_infant.Name = "input_infant";
            this.input_infant.Size = new System.Drawing.Size(136, 22);
            this.input_infant.TabIndex = 4;
            this.input_infant.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // input_adult
            // 
            this.input_adult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.input_adult.Location = new System.Drawing.Point(24, 98);
            this.input_adult.Name = "input_adult";
            this.input_adult.Size = new System.Drawing.Size(136, 22);
            this.input_adult.TabIndex = 5;
            this.input_adult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // input_seniorcitizen
            // 
            this.input_seniorcitizen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.input_seniorcitizen.Location = new System.Drawing.Point(24, 147);
            this.input_seniorcitizen.Name = "input_seniorcitizen";
            this.input_seniorcitizen.Size = new System.Drawing.Size(136, 22);
            this.input_seniorcitizen.TabIndex = 6;
            this.input_seniorcitizen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // input_male
            // 
            this.input_male.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.input_male.Location = new System.Drawing.Point(24, 196);
            this.input_male.Name = "input_male";
            this.input_male.Size = new System.Drawing.Size(136, 22);
            this.input_male.TabIndex = 7;
            this.input_male.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // input_female
            // 
            this.input_female.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.input_female.Location = new System.Drawing.Point(24, 245);
            this.input_female.Name = "input_female";
            this.input_female.Size = new System.Drawing.Size(136, 22);
            this.input_female.TabIndex = 8;
            this.input_female.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_update
            // 
            this.btn_update.Enabled = false;
            this.btn_update.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_update.Image = ((System.Drawing.Image)(resources.GetObject("btn_update.Image")));
            this.btn_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_update.Location = new System.Drawing.Point(199, 237);
            this.btn_update.Name = "btn_update";
            this.btn_update.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btn_update.Size = new System.Drawing.Size(251, 40);
            this.btn_update.TabIndex = 9;
            this.btn_update.Text = "Update";
            this.btn_update.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // databasemanager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1657, 1024);
            this.Controls.Add(this.panel_editbarangay);
            this.Controls.Add(this.panel_sidenav);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "databasemanager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "databasemanager";
            this.panel_sidenav.ResumeLayout(false);
            this.panel_sidenav.PerformLayout();
            this.panel_nav.ResumeLayout(false);
            this.panel_nav.PerformLayout();
            this.panel_editbarangay.ResumeLayout(false);
            this.panel_editbarangay.PerformLayout();
            this.grp_population.ResumeLayout(false);
            this.grp_population.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_sidenav;
        private System.Windows.Forms.TextBox txt_barangay;
        private System.Windows.Forms.Panel panel_nav;
        private System.Windows.Forms.Label lbl_mainnav;
        private System.Windows.Forms.Button btn_initiatedata;
        private System.Windows.Forms.ComboBox dropdown_barangaylist;
        private System.Windows.Forms.Panel panel_editbarangay;
        private System.Windows.Forms.Label display_barangayname;
        private System.Windows.Forms.Label lbl_brgy;
        private System.Windows.Forms.GroupBox grp_population;
        private System.Windows.Forms.Label lbl_female;
        private System.Windows.Forms.Label lbl_male;
        private System.Windows.Forms.Label lbl_seniorcitizen;
        private System.Windows.Forms.Label lbl_adult;
        private System.Windows.Forms.Label lbl_infant;
        private System.Windows.Forms.TextBox input_female;
        private System.Windows.Forms.TextBox input_male;
        private System.Windows.Forms.TextBox input_seniorcitizen;
        private System.Windows.Forms.TextBox input_adult;
        private System.Windows.Forms.TextBox input_infant;
        private System.Windows.Forms.Button btn_update;
    }
}