using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using userManagement;
using userManager;
using sessionManager;
namespace finalProject
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            //hide the password with dots
            txtPassword.UseSystemPasswordChar = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //get the username and the password from the textboxes
            string username = txtUserName.Text.Trim();
            string password = txtPassword.Text.Trim();

            //check if either is empty
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username and password cannot be blank.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //check all the users in the user list
            foreach (var user in UserManager.Users)
            {
                //if login is success
                if (user.Login(username, password))
                {
                    //save  the current user to the session
                    Session.CurrentUser = user;

                    MessageBox.Show("Login Successful!", "" , MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //hide the login form
                    this.Hide();

                    //display the dashboard form
                    DashboardForm dashboardForm = new DashboardForm();
                    dashboardForm.Show();
                    return;
                }
            }

            MessageBox.Show("Wrong username or password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void cboxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            //validate if the checkbox is clicked or not
            if (cboxShowPassword.Checked)
            {
                //if yes, the password will be shown
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                //if not, it will remain dots
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void lnkRegiter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //hide the login form 
            this.Hide();

            //opne the register form
            register reg = new register();
            reg.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
