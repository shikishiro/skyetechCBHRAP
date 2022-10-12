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
    public partial class login : Form
    {
        //DECLARING FORM NAMES
        maindashboard mainform = new maindashboard();
        public login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            //CHECKING LOGIN INFORMATION
            if (input_user.Text == "admin" && input_password.Text == "10121")
            {
                MessageBox.Show("Login successful", "Skyetech: CBHRAP", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mainform.Show();
                this.Hide();
            }
            else
            {
                //ERROR CHECKING
                MessageBox.Show("Username or password is incorrect.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Controls.Clear();
                this.InitializeComponent();
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            //COMPLETE APPLICATION SHUTDOWN
            Application.Exit();
        }
    }
}
