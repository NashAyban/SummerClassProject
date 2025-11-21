using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskManagement
{
    public class TaskItem
    {
        public string TasksName { get; set; } //the name of the task
        public bool IsDone { get; set; } //tru if the task is done, false if not
        
        //set the task name and mark it as not done as default
        public TaskItem(string tasksName)
        {
            TasksName = tasksName;
            IsDone = false;
        }
    }
}
