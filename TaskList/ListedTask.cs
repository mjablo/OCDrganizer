namespace TaskListView
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class ListedTask : Task
    {
        //--- Fields
        static private uint taskIndexGen = 0;
        private uint index;
        private bool isDone = false;

        //--- Constructors
        public ListedTask(string name, string priority) : base(name, priority) 
        {
            index = taskIndexGen;
            taskIndexGen++;
        }

        //--- Properties
        public uint Index
        {
            get { return index; }
        }

        public bool IsDone
        {
            get { return isDone; }
            set { isDone = value; }
        }
    }
}
