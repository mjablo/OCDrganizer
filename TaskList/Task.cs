namespace TaskListView
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    public class Task
    {
        //--- Fields
        private string name;
        private string priority;
        protected string status;

        //--- Constructors
        public Task(string name, string priority)
        {

            status = "";

            Name = name;
            Priority = priority;
        }


        //--- Properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Priority
        {
            get { return priority; }
            set { priority = value; }
        }
        internal string Status 
        {
            get { return status; }
            set { status = value; }
        }
    }
}
