using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using taskManagement;

namespace projectManagement
{
    public class BaseProject //create a parent class
    {
        //ENCAPSULATION
        //encapsulation of the datas
        public string ProjectName { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime StartDate { get; set; }
        public virtual double Progress { get; set; } //virtual so the child can edit it

        public BaseProject(string projectName, DateTime dueDate, DateTime startDate) //constructor to set initian value
        {
            ProjectName = projectName;
            DueDate = dueDate;
            StartDate = startDate;
            Progress = 0;
        }
        
        //POLYMORPHYSM
        public virtual string DisplayInfoToString() //method to show the progress info
        {
            return $"Project: {ProjectName}, Progress: {Progress}%";
        }
    }

    //INHERITANCE
    public class Project : BaseProject // cretae a child class
    {
        //make a list for tasks for this project
        public List<TaskItem> Tasks { get; set; }

        //this constructor sends the project name, start date, and due date to the BaseProject class
        public Project(string projectName, DateTime dueDate, DateTime startDate)

            : base(projectName, dueDate, startDate)
        {
            //creates a new empty list to store tasks for this project
            Tasks = new List<TaskItem>();
        }

        //method to add task to the project
        public void AddTask(TaskItem task)
        {
            //add task to the list
            Tasks.Add(task);

            //update and recalculate the progress
            UpdateProgress();
        }

        //ABSTRACTION
        //method to calculate the progress
        public void UpdateProgress()
        {
            //if the task count is equal to 0
            if (Tasks.Count == 0)
            {
                Progress = 0; //progress is 0
                return;
            }

            //count the 'done' tasks
            int doneCount = Tasks.Count(task => task.IsDone);

            //calculate the percentage
            Progress = (doneCount / (double)Tasks.Count) * 100;
        }

        //POLYMORPHYSM
        //override the displayinfortostring to show full info
        public override string DisplayInfoToString()
        {
            return $"Project: {ProjectName}, Start: {StartDate.ToShortDateString()}, Due: {DueDate.ToShortDateString()}, Progress: {Progress:F2}%";
        }
    }
}
