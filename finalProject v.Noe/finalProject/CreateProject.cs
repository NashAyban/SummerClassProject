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
using projectManagement;

namespace finalProject
{

    public partial class CreateProjectForm : Form
    {

        public CreateProjectForm()
        {
            InitializeComponent();

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string projectName = txtProjectName.Text.Trim(); //get the project name from textbox
            string duetest = lnkDueDate.Text.Trim(); //get the duedate from link label
            string starttest = lnkStartDate.Text.Trim(); //get the startdate from the link label
            string starttest1 = "MM/DD/YYYY"; //a default text date


            //check if the required details are missing
            if (string.IsNullOrEmpty(projectName) || starttest.Equals(starttest1))
            {
                MessageBox.Show("Please enter complete details.", "Please Enter Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                //convert the date string to actual date
                var startDate = DateTime.Parse(lnkStartDate.Text);
                var dueDate = DateTime.Parse(lnkDueDate.Text);

                //create a new proect using the Project class (inherits from the BaseProject)
                BaseProject newProject = new Project(projectName, dueDate, startDate);

                //add the new project to the current user project list
                Session.CurrentUser.Projects.Add((Project)newProject);

                //show message and close the windows form
                MessageBox.Show(newProject.DisplayInfoToString(), "Created Succesfully");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }


        }

        private void CreateProjectForm_Load(object sender, EventArgs e)
        {

        }

        private void lnkStartDate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btnSelectDate_Click(object sender, EventArgs e)
        {
            //open the calendar form
            CalendarForm cal = new CalendarForm();

            //wait for the user to finish selecting the dates
            if (cal.ShowDialog() == DialogResult.OK)
            {
                //check if both dates have value
                if (cal.StartDate.HasValue && cal.EndDate.HasValue)
                {
                    /*show the selected date in the link label (used 'ToShortDateString()' 
                     * to get the date only and not included the time)*/
                    lnkStartDate.Text = cal.StartDate.Value.ToShortDateString();
                    lnkDueDate.Text = cal.EndDate.Value.ToShortDateString();
                }
                else
                {
                    MessageBox.Show("Both start and end dates must be selected.");
                }
            }
        }

        private void btnAddTasks_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
