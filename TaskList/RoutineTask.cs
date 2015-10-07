namespace TaskListView
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class RoutineTask : Task
    {
        //--- Fields
        private bool isWorkweek;
        private bool isWeekend;


        //--- Constructors
        public RoutineTask(string name, string priority, bool isWorkweek, bool isWeekend) : base(name, priority) 
        {
            IsWorkweek = isWorkweek;
            IsWeekend = isWeekend;
            status = "Routine (Preview)";
        }

        public RoutineTask(RoutineTask source) : base(source) 
        {
            IsWeekend = source.IsWeekend;
            IsWorkweek = source.IsWorkweek;
            status = source.Status;
        }

        //--- Properties
        public bool IsWorkweek
        {
            get { return isWorkweek; }
            set { isWorkweek = value; }
        }
        public bool IsWeekend
        {
            get { return isWeekend; }
            set { isWeekend = value; }
        }

    }
}
