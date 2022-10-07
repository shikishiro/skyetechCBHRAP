using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace skyetechCBHRAP
{
    public partial class maindashboard : Form
    {
        //Declaration of forms
        barangaylist brgylist = new barangaylist(); //Barangay List Form
        databasemanager dbmanager = new databasemanager(); //Database Manager Form
        public maindashboard()
        {
            InitializeComponent();
            timer_datetime.Start();
        }

        private void timer_datetime_Tick(object sender, EventArgs e)
        {
            lbl_datetime.Text = DateTime.Now.ToString("ddd-MMMM/dd/yyyy HH:mm:ss");
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            brgylist.Hide();
            dbmanager.Hide();
        }

        private void btn_barangaylist_Click(object sender, EventArgs e)
        {
            brgylist.TopLevel = false;
            panel_mainpanel.Controls.Add(brgylist);
            brgylist.BringToFront();
            brgylist.Show();
        }

        private void btn_databasemanager_Click(object sender, EventArgs e)
        {
            dbmanager.TopLevel = false;
            panel_mainpanel.Controls.Add(dbmanager);
            dbmanager.BringToFront();
            dbmanager.Show();
        }
    }
}
