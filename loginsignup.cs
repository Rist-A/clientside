using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace clientside
{
    public partial class loginsignup : Form
    {
        public loginsignup()
        {
            InitializeComponent();
        }

        private void showmepass_CheckedChanged(object sender, EventArgs e)
        {
            if (showmepass.Checked)
            {
                uppas.PasswordChar = '\0'; // Show password
            }
            else
            {
                uppas.PasswordChar = '*'; // Hide password
            }
        }



        private void clogcheck_CheckedChanged(object sender, EventArgs e)
        {
            if (clogcheck.Checked)
            {
                cllogpas.PasswordChar = '\0'; // Show password
            }
            else
            {
                cllogpas.PasswordChar = '*'; // Hide password
            }
        }

        private void signcomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (signcomboBox1.SelectedIndex == 0)
            {
                panel2.Visible = false; // Hide Panel 1
                panel3.Visible = true;  // Show Panel 2
                cpanel4.Visible = false;
            }
            else if (signcomboBox1.SelectedIndex == 1)
            {
                panel2.Visible = false; // Hide Panel 1
                cpanel4.Visible = true;  // Show Panel 2
                panel3.Visible = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                adloginpas.PasswordChar = '\0'; // Show password
            }
            else
            {
                adloginpas.PasswordChar = '*'; // Hide password
            }
        }

        private void signupbtn_Click(object sender, EventArgs e)
        {

        }

        private void adnoacc_Click(object sender, EventArgs e)
        {
            cpanel4.Visible = false; // Hide Panel 1
            panel2.Visible = true;  // Show Panel 2
            panel3.Visible = false;
        }

        private void adloginbtn_Click(object sender, EventArgs e)
        {

        }

        private void clientloginbtn_Click(object sender, EventArgs e)
        {

        }

        private void clientnnoacc_Click(object sender, EventArgs e)
        {
            cpanel4.Visible = false; // Hide Panel 1
            panel2.Visible = true;  // Show Panel 2
            panel3.Visible = false;

        }

        private void adminpcheck_CheckedChanged(object sender, EventArgs e)
        {
            if (adminpcheck.Checked)
            {
                adminlogint.PasswordChar = '\0'; // Show password
            }
            else
            {
                adminlogint.PasswordChar = '*'; // Hide password
            }
        }

        private void adminloginbtn_Click(object sender, EventArgs e)
        {

        }

        private void adminnoacccheck_Click(object sender, EventArgs e)
        {
            cpanel4.Visible = false; // Hide Panel 1
            panel2.Visible = true;  // Show Panel 2
            panel3.Visible = false;
        }
    }
}
