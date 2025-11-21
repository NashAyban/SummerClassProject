using sessionManager;
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
using projectManagement;
using taskManagement;
using sessionManager;

namespace finalProject
{
    public partial class ProgressForm : Form
    {
        public ProgressForm()
        {
            InitializeComponent();
        }

        private void ProgressForm_Load(object sender, EventArgs e)
        {
            //set up the columns of the datagrid
            setupDataGrid();

            //load the list of the projects
            loadProject();
        }
        private void setupDataGrid()
        {
            //clear the datagrid
            dgvProjects.Columns.Clear();
            dgvProjects.Rows.Clear();

            //create column for the project name andd add it to the datagrid
            DataGridViewTextBoxColumn projectNameCol = new DataGridViewTextBoxColumn();
            projectNameCol.HeaderText = "Project Name";
            projectNameCol.Name = "ProjectName";
            dgvProjects.Columns.Add(projectNameCol);

            //creat column for the progress and add it to the datagrid
            DataGridViewTextBoxColumn progressCol = new DataGridViewTextBoxColumn();
            progressCol.HeaderText = "Progress";
            progressCol.Name = "Progress";
            dgvProjects.Columns.Add(progressCol);

            //create a column with a 'view task' button
            DataGridViewButtonColumn viewTaskButton = new DataGridViewButtonColumn();
            viewTaskButton.HeaderText = "Action";
            viewTaskButton.Name = "ViewTask";
            viewTaskButton.Text = "View Tasks";
            viewTaskButton.UseColumnTextForButtonValue = true; //make the column text as button
            dgvProjects.Columns.Add(viewTaskButton);

            //make the column autosize
            dgvProjects.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void loadProject()
        {
            //clear the rows
            dgvProjects.Rows.Clear();

            //loop through the users project list
            foreach (var project in Session.CurrentUser.Projects)
            {
                //add new row
                int rowIndex = dgvProjects.Rows.Add();

                //set project name
                dgvProjects.Rows[rowIndex].Cells["ProjectName"].Value = project.ProjectName;

                //set progress
                dgvProjects.Rows[rowIndex].Cells["Progress"].Value = ((int)project.Progress).ToString() + "%";

            }
        }

        private void dgvProjects_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //check if the user click the view task button
            if (e.RowIndex >= 0 && dgvProjects.Columns[e.ColumnIndex].Name == "ViewTask")
            {
                //get the selected project from the users project list
                var selectedProject = Session.CurrentUser.Projects[e.RowIndex];

                //open the task form and pass the selected project
                addTasks taskForm = new addTasks(selectedProject);
                taskForm.ShowDialog();

                
                loadProject();
            }
        }
    }
}
