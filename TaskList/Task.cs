using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaskListView
{
    class Task
    {
        static private uint taskIndexGen = 0;

        private uint index;
        private string name;
        private DateTime date;

        private bool isDone = false;

        //
        // Constructors
        //
        public Task(string name, DateTime date)
        {
            index = taskIndexGen;
            taskIndexGen++;

            Name = name;
            Date = date;
        }

        //
        // Accessors
        //
        public uint Index 
        {
            get { return index; }
        }
        public bool IsDone 
        {
            get { return isDone; }
            set { isDone = value; }

        }
        public string Name 
        { 
            get { return name; }
            set { name = value; }
        }
        public DateTime Date 
        {
            get { return date; }
            set { date = value; }
        }
        
    }
}
