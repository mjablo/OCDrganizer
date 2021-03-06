﻿namespace TaskListView
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class CalendarTask : Task
    {
        //--- Fields
        static private uint taskIndexGen = 0;
        private uint index;
        private bool isDone = false;

        //--- Constructors
        public CalendarTask(string name, string priority) : base(name, priority) 
        {
            index = taskIndexGen;
            taskIndexGen++;
        }

        public CalendarTask(CalendarTask source) : base(source)
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
