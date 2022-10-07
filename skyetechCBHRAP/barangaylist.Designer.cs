namespace skyetechCBHRAP
{
    partial class barangaylist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(barangaylist));
            this.panel_sidenav = new System.Windows.Forms.Panel();
            this.panel_nav = new System.Windows.Forms.Panel();
            this.lbl_mainnav = new System.Windows.Forms.Label();
            this.btn_initiatedata = new System.Windows.Forms.Button();
            this.dropdown_barangaylist = new System.Windows.Forms.ComboBox();
            this.panel_barangayinformation = new System.Windows.Forms.Panel();
            this.display_barangayname = new System.Windows.Forms.Label();
            this.lbl_brgy = new System.Windows.Forms.Label();
            this.panel_population = new System.Windows.Forms.Panel();
            this.display_totalpopulation = new System.Windows.Forms.Label();
            this.display_female = new System.Windows.Forms.Label();
            this.lbl_female = new System.Windows.Forms.Label();
            this.display_male = new System.Windows.Forms.Label();
            this.lbl_male = new System.Windows.Forms.Label();
            this.display_seniorcitizen = new System.Windows.Forms.Label();
            this.lbl_seniorcitizen = new System.Windows.Forms.Label();
            this.display_adult = new System.Windows.Forms.Label();
            this.lbl_adult = new System.Windows.Forms.Label();
            this.display_infant = new System.Windows.Forms.Label();
            this.lbl_infant = new System.Windows.Forms.Label();
            this.panel_populationtitle = new System.Windows.Forms.Panel();
            this.lbl_population = new System.Windows.Forms.Label();
            this.txt_barangay = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_sidenav.SuspendLayout();
            this.panel_nav.SuspendLayout();
            this.panel_barangayinformation.SuspendLayout();
            this.panel_population.SuspendLayout();
            this.panel_populationtitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.panel_sidenav.TabIndex = 0;
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
            // panel_barangayinformation
            // 
            this.panel_barangayinformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panel_barangayinformation.Controls.Add(this.display_barangayname);
            this.panel_barangayinformation.Controls.Add(this.lbl_brgy);
            this.panel_barangayinformation.Controls.Add(this.panel_population);
            this.panel_barangayinformation.Location = new System.Drawing.Point(332, 0);
            this.panel_barangayinformation.Name = "panel_barangayinformation";
            this.panel_barangayinformation.Size = new System.Drawing.Size(1326, 1024);
            this.panel_barangayinformation.TabIndex = 1;
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
            // panel_population
            // 
            this.panel_population.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panel_population.Controls.Add(this.pictureBox1);
            this.panel_population.Controls.Add(this.display_totalpopulation);
            this.panel_population.Controls.Add(this.display_female);
            this.panel_population.Controls.Add(this.lbl_female);
            this.panel_population.Controls.Add(this.display_male);
            this.panel_population.Controls.Add(this.lbl_male);
            this.panel_population.Controls.Add(this.display_seniorcitizen);
            this.panel_population.Controls.Add(this.lbl_seniorcitizen);
            this.panel_population.Controls.Add(this.display_adult);
            this.panel_population.Controls.Add(this.lbl_adult);
            this.panel_population.Controls.Add(this.display_infant);
            this.panel_population.Controls.Add(this.lbl_infant);
            this.panel_population.Controls.Add(this.panel_populationtitle);
            this.panel_population.Location = new System.Drawing.Point(160, 168);
            this.panel_population.Name = "panel_population";
            this.panel_population.Size = new System.Drawing.Size(450, 290);
            this.panel_population.TabIndex = 0;
            // 
            // display_totalpopulation
            // 
            this.display_totalpopulation.AutoSize = true;
            this.display_totalpopulation.Dock = System.Windows.Forms.DockStyle.Right;
            this.display_totalpopulation.Font = new System.Drawing.Font("FuturaBT-BoldCondensed", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display_totalpopulation.ForeColor = System.Drawing.SystemColors.Control;
            this.display_totalpopulation.Location = new System.Drawing.Point(221, 0);
            this.display_totalpopulation.Name = "display_totalpopulation";
            this.display_totalpopulation.Size = new System.Drawing.Size(229, 77);
            this.display_totalpopulation.TabIndex = 11;
            this.display_totalpopulation.Text = "####";
            // 
            // display_female
            // 
            this.display_female.AutoSize = true;
            this.display_female.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display_female.ForeColor = System.Drawing.SystemColors.Control;
            this.display_female.Location = new System.Drawing.Point(94, 185);
            this.display_female.Name = "display_female";
            this.display_female.Size = new System.Drawing.Size(46, 21);
            this.display_female.TabIndex = 10;
            this.display_female.Text = "####";
            // 
            // lbl_female
            // 
            this.lbl_female.AutoSize = true;
            this.lbl_female.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_female.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_female.Location = new System.Drawing.Point(19, 185);
            this.lbl_female.Name = "lbl_female";
            this.lbl_female.Size = new System.Drawing.Size(69, 21);
            this.lbl_female.TabIndex = 9;
            this.lbl_female.Text = "Female:";
            // 
            // display_male
            // 
            this.display_male.AutoSize = true;
            this.display_male.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display_male.ForeColor = System.Drawing.SystemColors.Control;
            this.display_male.Location = new System.Drawing.Point(77, 146);
            this.display_male.Name = "display_male";
            this.display_male.Size = new System.Drawing.Size(46, 21);
            this.display_male.TabIndex = 8;
            this.display_male.Text = "####";
            // 
            // lbl_male
            // 
            this.lbl_male.AutoSize = true;
            this.lbl_male.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_male.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_male.Location = new System.Drawing.Point(19, 146);
            this.lbl_male.Name = "lbl_male";
            this.lbl_male.Size = new System.Drawing.Size(52, 21);
            this.lbl_male.TabIndex = 7;
            this.lbl_male.Text = "Male:";
            // 
            // display_seniorcitizen
            // 
            this.display_seniorcitizen.AutoSize = true;
            this.display_seniorcitizen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display_seniorcitizen.ForeColor = System.Drawing.SystemColors.Control;
            this.display_seniorcitizen.Location = new System.Drawing.Point(145, 109);
            this.display_seniorcitizen.Name = "display_seniorcitizen";
            this.display_seniorcitizen.Size = new System.Drawing.Size(46, 21);
            this.display_seniorcitizen.TabIndex = 6;
            this.display_seniorcitizen.Text = "####";
            // 
            // lbl_seniorcitizen
            // 
            this.lbl_seniorcitizen.AutoSize = true;
            this.lbl_seniorcitizen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_seniorcitizen.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_seniorcitizen.Location = new System.Drawing.Point(19, 109);
            this.lbl_seniorcitizen.Name = "lbl_seniorcitizen";
            this.lbl_seniorcitizen.Size = new System.Drawing.Size(120, 21);
            this.lbl_seniorcitizen.TabIndex = 5;
            this.lbl_seniorcitizen.Text = "Senior Citizen:";
            // 
            // display_adult
            // 
            this.display_adult.AutoSize = true;
            this.display_adult.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display_adult.ForeColor = System.Drawing.SystemColors.Control;
            this.display_adult.Location = new System.Drawing.Point(81, 72);
            this.display_adult.Name = "display_adult";
            this.display_adult.Size = new System.Drawing.Size(46, 21);
            this.display_adult.TabIndex = 4;
            this.display_adult.Text = "####";
            // 
            // lbl_adult
            // 
            this.lbl_adult.AutoSize = true;
            this.lbl_adult.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_adult.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_adult.Location = new System.Drawing.Point(19, 72);
            this.lbl_adult.Name = "lbl_adult";
            this.lbl_adult.Size = new System.Drawing.Size(56, 21);
            this.lbl_adult.TabIndex = 3;
            this.lbl_adult.Text = "Adult:";
            // 
            // display_infant
            // 
            this.display_infant.AutoSize = true;
            this.display_infant.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display_infant.ForeColor = System.Drawing.SystemColors.Control;
            this.display_infant.Location = new System.Drawing.Point(85, 33);
            this.display_infant.Name = "display_infant";
            this.display_infant.Size = new System.Drawing.Size(46, 21);
            this.display_infant.TabIndex = 2;
            this.display_infant.Text = "####";
            // 
            // lbl_infant
            // 
            this.lbl_infant.AutoSize = true;
            this.lbl_infant.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_infant.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_infant.Location = new System.Drawing.Point(19, 33);
            this.lbl_infant.Name = "lbl_infant";
            this.lbl_infant.Size = new System.Drawing.Size(60, 21);
            this.lbl_infant.TabIndex = 1;
            this.lbl_infant.Text = "Infant:";
            // 
            // panel_populationtitle
            // 
            this.panel_populationtitle.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel_populationtitle.Controls.Add(this.lbl_population);
            this.panel_populationtitle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_populationtitle.Location = new System.Drawing.Point(0, 245);
            this.panel_populationtitle.Name = "panel_populationtitle";
            this.panel_populationtitle.Size = new System.Drawing.Size(450, 45);
            this.panel_populationtitle.TabIndex = 0;
            // 
            // lbl_population
            // 
            this.lbl_population.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_population.AutoSize = true;
            this.lbl_population.Font = new System.Drawing.Font("FuturaBT-BoldCondensed", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_population.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_population.Location = new System.Drawing.Point(153, 3);
            this.lbl_population.Name = "lbl_population";
            this.lbl_population.Size = new System.Drawing.Size(154, 42);
            this.lbl_population.TabIndex = 0;
            this.lbl_population.Text = "Population";
            this.lbl_population.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_barangay
            // 
            this.txt_barangay.Location = new System.Drawing.Point(12, 302);
            this.txt_barangay.Name = "txt_barangay";
            this.txt_barangay.Size = new System.Drawing.Size(302, 20);
            this.txt_barangay.TabIndex = 4;
            this.txt_barangay.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(354, 146);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // barangaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1657, 1024);
            this.Controls.Add(this.panel_barangayinformation);
            this.Controls.Add(this.panel_sidenav);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "barangaylist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "+-";
            this.panel_sidenav.ResumeLayout(false);
            this.panel_sidenav.PerformLayout();
            this.panel_nav.ResumeLayout(false);
            this.panel_nav.PerformLayout();
            this.panel_barangayinformation.ResumeLayout(false);
            this.panel_barangayinformation.PerformLayout();
            this.panel_population.ResumeLayout(false);
            this.panel_population.PerformLayout();
            this.panel_populationtitle.ResumeLayout(false);
            this.panel_populationtitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_sidenav;
        private System.Windows.Forms.ComboBox dropdown_barangaylist;
        private System.Windows.Forms.Button btn_initiatedata;
        private System.Windows.Forms.Panel panel_nav;
        private System.Windows.Forms.Label lbl_mainnav;
        private System.Windows.Forms.Panel panel_barangayinformation;
        private System.Windows.Forms.Panel panel_population;
        private System.Windows.Forms.Panel panel_populationtitle;
        private System.Windows.Forms.Label lbl_population;
        private System.Windows.Forms.Label display_seniorcitizen;
        private System.Windows.Forms.Label lbl_seniorcitizen;
        private System.Windows.Forms.Label display_adult;
        private System.Windows.Forms.Label lbl_adult;
        private System.Windows.Forms.Label display_infant;
        private System.Windows.Forms.Label lbl_infant;
        private System.Windows.Forms.Label display_female;
        private System.Windows.Forms.Label lbl_female;
        private System.Windows.Forms.Label display_male;
        private System.Windows.Forms.Label lbl_male;
        private System.Windows.Forms.Label display_totalpopulation;
        private System.Windows.Forms.Label lbl_brgy;
        private System.Windows.Forms.Label display_barangayname;
        private System.Windows.Forms.TextBox txt_barangay;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}