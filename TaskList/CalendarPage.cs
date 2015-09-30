namespace TaskListView
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class CalendarPage
    {
        //--- Fields
        private DateTime date;
        private List<ListedTask> taskList = new List<ListedTask>();
        private bool hasRoutineTasksAdded = false;


        //--- Constructors
        public CalendarPage(DateTime date) 
        {
            this.date = date;
        }


        //--- Properties
        public DateTime Date 
        {
            get { return date; }
        }
        internal List<ListedTask> TaskList 
        {
            get { return taskList; }
            set { taskList = value; }
        }
        public bool HasRoutineTasksAdded
        {
            get { return hasRoutineTasksAdded; }
            set { hasRoutineTasksAdded = value; }
        }
    }
}
