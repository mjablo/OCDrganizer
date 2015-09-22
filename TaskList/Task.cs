namespace TaskListView
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    class Task
    {
        //--- Fields
        static private uint taskIndexGen = 0;
        private uint index;
        private string name;
        private string priority;
        private DateTime date;
        private bool isDone = false;
        private bool isRoutine;


        //--- Constructors
        public Task(string name, DateTime date, string priority)
        {
            index = taskIndexGen;
            taskIndexGen++;

            Name = name;
            Date = date;
            Priority = priority;
        }


        //--- Properties
        public uint Index
        {
            get { return index; }
        }
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
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        public bool IsDone
        {
            get { return isDone; }
            set { isDone = value; }
        }
        public bool IsRoutine
        {
            get { return isRoutine; }
            set { isRoutine = value; }
        }
   
    }
}
