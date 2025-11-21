using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using sessionManager;
using userManagement;
using userManager;
using projectManagement;
using taskManagement;

namespace finalProject
{
    public partial class addTasks : Form
    {
        private Project currentProject;
        private bool suppressDoubleClick = false; //stop the double click

        public addTasks(Project currentProject) //a constructor that helps initialized the form with the current project
        {
            InitializeComponent();
            this.currentProject = currentProject;
        }

        private void addTasks_Load(object sender, EventArgs e)
        {
            //clear any rows and columns in datagrid
            dgvTasks.Columns.Clear();
            dgvTasks.Rows.Clear();

            //add columns on the datagrid
            dgvTasks.Columns.Add("TaskName", "Task Name");
            dgvTasks.Columns.Add("Status", "Status");

            //create a 3rd column for the action
            DataGridViewTextBoxColumn actionColumn = new DataGridViewTextBoxColumn();
            actionColumn.Name = "Action";
            actionColumn.HeaderText = "Action";

            //make the column aligns in the center
            actionColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            actionColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvTasks.Columns.Add(actionColumn);

            //makes column if the datagrid autofit
            dgvTasks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //load the task to the table
            LoadTaskList();

            //attached event handlers
            dgvTasks.CellDoubleClick += dgvTasks_CellDoubleClick;
            dgvTasks.CellContentClick += dgvTasks_CellContentClick;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            string taskName = txtTasks.Text.Trim();

            //validate the input
            if (string.IsNullOrEmpty(taskName))
            {
                MessageBox.Show("Please enter a task name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //create and add new tasks to the project
            TaskItem task = new TaskItem(taskName);
            currentProject.AddTask(task);

            //clear the textbox and refresh the list
            txtTasks.Clear();
            LoadTaskList();
        }

        private void LoadTaskList() //load the task to the datagrid
        {
            dgvTasks.Rows.Clear();

            foreach (var task in currentProject.Tasks)
            {
                string status = task.IsDone ? "Done" : "Pending";
                string actionText = task.IsDone ? "✓ Done | Delete" : "Mark as Done | Delete";

                //add the task as rows
                dgvTasks.Rows.Add(task.TasksName, status, actionText);
            }
        }

        private void dgvTasks_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //validates and prevent conflict with the cellcontentclick
            if (suppressDoubleClick)
            {
                suppressDoubleClick = false;
                return;
            }

            //validates and  check if a valid row is double click outside the 'action' column
            if (e.RowIndex >= 0 &&
                e.ColumnIndex != dgvTasks.Columns["Action"].Index)
            {
                var selectedTask = currentProject.Tasks[e.RowIndex];

                //toggle the status of the task
                selectedTask.IsDone = !selectedTask.IsDone;

                currentProject.UpdateProgress(); //update the project progress
                LoadTaskList(); //refresh the list
            }
        }

        private void dgvTasks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            //check if the click column is the 'acion' column
            if (dgvTasks.Columns[e.ColumnIndex].Name == "Action")
            {
                var actionsText = dgvTasks.Rows[e.RowIndex].Cells["Action"].Value?.ToString();
                if (string.IsNullOrEmpty(actionsText)) return;

                //get the mouse position to know where in the column is clicked
                var mousePosition = dgvTasks.PointToClient(Cursor.Position);
                var cellRect = dgvTasks.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);
                int relativeX = mousePosition.X - cellRect.X;

                //if left-side is clicked 'mark as done'
                if (relativeX < cellRect.Width / 2)
                {
                    
                    var selectedTask = currentProject.Tasks[e.RowIndex];

                    if (selectedTask.IsDone)
                    {
                        MessageBox.Show("This task is marked as done.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        selectedTask.IsDone = true;
                        currentProject.UpdateProgress();
                        LoadTaskList();
                    }
                }
                else //else, then it is 'delete'
                {
                    
                    string taskName = currentProject.Tasks[e.RowIndex].TasksName;

                    var result = MessageBox.Show(
                        $"Are you sure you want to delete the task '{taskName}'?",
                        "Confirm Delete",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (result == DialogResult.Yes)
                    {
                        currentProject.Tasks.RemoveAt(e.RowIndex);
                        currentProject.UpdateProgress();
                        LoadTaskList();
                    }
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
