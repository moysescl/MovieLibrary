using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieLibrary
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBoxUserName_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void checkBoxShowHide_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowHide.Checked)
            {
                textBoxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxPassword.UseSystemPasswordChar = true;
            }
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            if (checkBoxShowHide.Checked)
            {
                textBoxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxPassword.UseSystemPasswordChar = true;
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if ((this.textBoxUserName.Text == "admin") && (this.textBoxPassword.Text == "123"))
            {
                GUI.MovieLibraryForm myMainForm = new GUI.MovieLibraryForm();
                myMainForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Wrong username or password....Try again");
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            foreach (Control myControl in Controls)
            {
                if (myControl is TextBox)
                {
                    myControl.Text = "";

                }
                if(myControl is CheckBox)
                {
                    checkBoxShowHide.Checked = false;
                }
                
            }
            this.textBoxUserName.Focus();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
