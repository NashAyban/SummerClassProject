using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using userManager;
using userManagement;
using sessionManager;
using projectManagement;
namespace finalProject
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            //display the current user usarname
            lblUserName.Text = $"{Session.CurrentUser.Username}";

            //add a tool tip when the cursor hover to the progress bar
            tipProgress.SetToolTip(progressBar, "Click to show the prgress of other projects.");

            //load and show the latest project details
            loadProject();
        }

        private void loadProject() //method to show the lates project
        {
            //get the list of projects of the current user
            var projects = Session.CurrentUser.Projects;

            //check if the user have 1 or more projects
            if (projects.Count > 0)
            {
                //get the latest project or the last in the project list
                var latestProject = projects.Last();

                //get the details of the project and display it
                btnProjectName.Text = $"{latestProject.ProjectName}";
                progressBar.Value = (int)latestProject.Progress;
                lblProgress.Text = Convert.ToInt32(latestProject.Progress).ToString() + "%";
                lblDateStart.Text = $"{latestProject.StartDate.ToShortDateString()}";
                lblDueDate.Text = $"{latestProject.DueDate.ToShortDateString()}";
            }
            else
            {
                //default values if there's no project yet
                btnProjectName.Text = "No projects Yet";
                progressBar.Value = 0;
                lblProgress.Text = "0%";
                lblDateStart.Text = "none";
                lblDueDate.Text = "none";
            }
        }

        private void btnCreateProject_Click(object sender, EventArgs e)
        {
            //open the create project form
            CreateProjectForm createForm = new CreateProjectForm();

            //open the form
            if (createForm.ShowDialog() == DialogResult.OK)
            {
                //load the dashboard to show the latest proect
                loadProject();
            }
        }

        private void btnProjectName_Click(object sender, EventArgs e)
        {
            //open the project list form
            projectList projectList = new projectList();
            projectList.ShowDialog();

            //load the dashboard after closing the form
            loadProject();
        }

        private void progressBar_Click(object sender, EventArgs e)
        {
            //open the progress form
            ProgressForm progressForm = new ProgressForm();
            progressForm.ShowDialog();

            //load the dashboard after closing the form
            loadProject();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblUserName_Click(object sender, EventArgs e)
        {

        }

        private void lblProgress_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lnklblLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //clear the current user session
            Session.CurrentUser = null;
            MessageBox.Show("You have been logged out.", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //close the current form
            this.Hide();

            //show the login form again
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            this.Close();
        }
    }
}
