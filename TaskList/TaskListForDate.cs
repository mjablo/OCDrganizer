namespace TaskListView
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class TaskListForDate
    {
        //--- Fields
        private DateTime date;
        private List<Task> taskList = new List<Task>();


        //--- Constructors
        public TaskListForDate(DateTime date) 
        {
            this.date = date;
        }


        //--- Properties
        public DateTime Date 
        {
            get { return date; }
        }
        public List<Task> TaskList 
        {
            get { return taskList; }
            set { taskList = value; }
        }

    }
}
