using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sessionManager;
using userManagement;
using userManager;
using projectManagement;

namespace finalProject
{
    public partial class projectList : Form
    {
        //holds the current selected project
        private Project currentProject;
        public projectList()
        {
            InitializeComponent();
        }

        private void projectList_Load(object sender, EventArgs e)
        {
            //get the list of the projects and bind it in the datagridview
            var projectList = new BindingList<Project>(Session.CurrentUser.Projects);
            dgvProjectList.DataSource = projectList;

            //rename the column headers
            dgvProjectList.Columns["ProjectName"].HeaderText = "Project Name";
            dgvProjectList.Columns["StartDate"].HeaderText = "Start Date";
            dgvProjectList.Columns["DueDate"].HeaderText = "Due Date";

            //format the progress column to show percent
            if (dgvProjectList.Columns.Contains("Progress"))
            {
                dgvProjectList.Columns["Progress"].DefaultCellStyle.Format = "0'%'";
                dgvProjectList.Columns["Progress"].HeaderText = "Progress (%)";
            }

            //check if the delete button column exist
            if (!dgvProjectList.Columns.Contains("Delete"))
            {
                //if not, add a delete button column
                DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
                deleteButton.Name = "Delete";
                deleteButton.HeaderText = "Action";
                deleteButton.Text = "Delete";
                deleteButton.UseColumnTextForButtonValue = true;
                dgvProjectList.Columns.Add(deleteButton);
            }

            //auto resize the columns of the datagridview
            dgvProjectList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProjectList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProjectList.MultiSelect = false;
        }


        private void listProj_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //check if a project is selected
            if (currentProject == null)
            {
                MessageBox.Show("Please select a project from the list first.", "No Project Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //open the task form and pass the selected project to it
            addTasks t = new addTasks(currentProject);
            t.ShowDialog();
        }

        private void dgvProjectList_SelectionChanged(object sender, EventArgs e)
        {
            //if a row is selected, count it as the selected project
            if (dgvProjectList.SelectedRows.Count > 0)
            {
                currentProject = dgvProjectList.SelectedRows[0].DataBoundItem as Project;
            }
        }

        private void dgvProjectList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //validate the click is not on the header but on the delete button collumn
            if (e.RowIndex >= 0 && dgvProjectList.Columns[e.ColumnIndex].Name == "Delete")
            {
                var selectedProject = dgvProjectList.Rows[e.RowIndex].DataBoundItem as Project;

                //ask a confirmation before deleting
                var result = MessageBox.Show(
                    $"Are you sure you want to delete the project \"{selectedProject.ProjectName}\"?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                //if yes, delete the project and refresh the datagridview
                if (result == DialogResult.Yes)
                {
                    Session.CurrentUser.Projects.Remove(selectedProject);
                    refreshProjectList();
                }
            }
        }

        //method to refresh the datagridview
        private void refreshProjectList()
        {
            dgvProjectList.DataSource = null;
            dgvProjectList.Columns.Clear();
            projectList_Load(null, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
