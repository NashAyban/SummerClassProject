using sessionManager;
using userManagement;
using userManager;

namespace finalProject
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void register_Load(object sender, EventArgs e)
        {
            //set password to dots
            txtPassword.UseSystemPasswordChar = true;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //get the username and password from the textbox
            string username = txtUserName.Text.Trim();
            string password = txtPassword.Text.Trim();

            //check if either field is empty
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username and password fields cannot be empty.", "Please Enter Details", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //loop to the user list and check if the username already exist
            foreach (var user in UserManager.Users)
            {
                if (user.Username == username)
                {
                    MessageBox.Show("Username already exists.");
                    return;
                }
            }

            //create a new user and add it to the list
            User newUser = new User(username, password);
            UserManager.Users.Add(newUser);

            MessageBox.Show("Account Created!");
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }

        private void cboxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void lnkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
