using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaskListView
{
    class TaskListForDate
    {
        private DateTime date;
        private List<Task> taskList = new List<Task>();

        public TaskListForDate(DateTime date) 
        {
            this.date = date;
        }

        //
        // Accessors 
        //
        public DateTime Date 
        {
            get { return date; }
        }
        public List<Task> TaskList 
        {
            get { return taskList; }
            set { taskList = value; }
        }

        //
        // Methods
        //
        public void AddTask(Task task)
        {
            taskList.Add(task);
        }
    }
}
