namespace TaskListView
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;

    public class TaskListView : ListView
    {
        //--- Fields
        private List<CalendarPage> calendarPages = new List<CalendarPage>();
        private List<RoutineTask> routineTasks = new List<RoutineTask>();


        //--- Constructors
        public TaskListView() : base() 
        {
            this.DoubleBuffered = true;

            // program starts with calendar set to today's date, so we can safely create empty list
            // with DateTime.Now; it is needed to populate routine tasks into the list
            if (calendarPages.Count == 0) 
            {
                calendarPages.Add(new CalendarPage(DateTime.Now.Date));
            }

            //!!! debug
            routineTasks.Add(new RoutineTask("routine1", "Normal", true, true));
            routineTasks.Add(new RoutineTask("routine2", "Normal", true, false));
            routineTasks.Add(new RoutineTask("routine3", "Normal", false, true));
            //!!! eof debug
        }

        private TaskListView(TaskListView view) {}

        //--- Properties
        public List<RoutineTask> RoutineTasks 
        {
            get { return routineTasks; }
        }

        //--- Methods
        public void AddTask(DateTime calendarSelectedDate, string name, string priority)
        {
            calendarPages[getCalendarPageIndexByDate(calendarSelectedDate)].TaskList.Add(new CalendarTask(name, priority));
        }

        public void EditTask(ListViewItem item, DateTime calendarSelectedDate, string name, string priority)
        {
            CalendarTask task = (CalendarTask)item.Tag;

            task.Name = name;
            if(!task.IsDone)
                task.Priority = priority;
        }

        public void RemoveTask(ListViewItem item, DateTime calendarSelectedDate) 
        {
            CalendarTask task = (CalendarTask)item.Tag;

            int calendarPageIndex = getCalendarPageIndexByDate(calendarSelectedDate);

            // iterate through proper CalendarPage's inner container 
            // and remove item with matching index
            for (int i = 0; i < calendarPages[calendarPageIndex].TaskList.Count; i++)
                if (task.Index == calendarPages[calendarPageIndex].TaskList[i].Index)
                {
                    calendarPages[calendarPageIndex].TaskList.RemoveAt(i);
                    break;
                }
        }

        public void SetAsDone(ListViewItem item, DateTime calendarSelectedDate)
        {
            CalendarTask task = (CalendarTask)item.Tag;

            task.IsDone = true;
        }

        public void DisplayCalendarPage(DateTime calendarSelectedDate) 
        {
            Items.Clear();

            int calendarPageIndex = getCalendarPageIndexByDate(calendarSelectedDate);

            // copy appropriate tasks from routineTasks list into selected CalendarPage if needed
            if (calendarSelectedDate == DateTime.Now.Date && !calendarPages[calendarPageIndex].HasRoutineTasksAdded)
            {
                populateCalendarPageWithRoutineTasks(calendarSelectedDate);
                calendarPages[calendarPageIndex].HasRoutineTasksAdded = true;
            }


            // if there's something to display, populate view with tasks written in seleceted CalendarPage
            // otherwise delete empty CalendarPage
            if (calendarPages[calendarPageIndex].TaskList.Count > 0)
            {
                foreach (CalendarTask ct in calendarPages[calendarPageIndex].TaskList)
                {
                    this.Items.Add(prepTaskForDisplay(ct));
                }
            }
            else 
            {
                calendarPages.RemoveAt(calendarPageIndex);
            }

            // in future dates only, additionally display preview of currently planned routine tasks
            if (calendarSelectedDate > DateTime.Now.Date)
            {
                foreach (RoutineTask rt in routineTasks)
                {

                    if (rt.IsWorkweek &&
                        (calendarSelectedDate.DayOfWeek >= DayOfWeek.Monday &&
                         calendarSelectedDate.DayOfWeek <= DayOfWeek.Friday))
                    {
                        this.Items.Add(prepTaskForDisplay(rt));
                    }
                    if (rt.IsWeekend &&
                        (calendarSelectedDate.DayOfWeek == DayOfWeek.Saturday ||
                         calendarSelectedDate.DayOfWeek == DayOfWeek.Sunday))
                    {
                        this.Items.Add(prepTaskForDisplay(rt));
                    }
                }
            }


        }



        //--- Helpers

        private int getCalendarPageIndexByDate(DateTime date) 
        {
            bool dateFoundFlag = false;
            int index = 0;

            while (index < calendarPages.Count && !dateFoundFlag)
            {
                if (calendarPages[index].Date == date.Date)
                    dateFoundFlag = true;
                else
                    index++;
            }

            if (!dateFoundFlag)
            {
                // add new calendar page at the end
                index = calendarPages.Count;

                calendarPages.Add(new CalendarPage(date)); 
            }

            return index;
        }

        private void populateCalendarPageWithRoutineTasks(DateTime calendarSelectedDate)
        {
            int calendarPageIndex = getCalendarPageIndexByDate(calendarSelectedDate);

            foreach (RoutineTask rt in routineTasks)
            {
                if (rt.IsWorkweek &&
                    (calendarSelectedDate.DayOfWeek >= DayOfWeek.Monday &&
                     calendarSelectedDate.DayOfWeek <= DayOfWeek.Friday))
                {
                    CalendarTask newTask = new CalendarTask(rt.Name, rt.Priority);
                    newTask.Status = "Routine";
                    
                    calendarPages[calendarPageIndex].TaskList.Add(newTask);
                }

                if (rt.IsWeekend &&
                    (calendarSelectedDate.DayOfWeek == DayOfWeek.Saturday ||
                     calendarSelectedDate.DayOfWeek == DayOfWeek.Sunday))
                    {
                        CalendarTask newTask = new CalendarTask(rt.Name, rt.Priority);
                        newTask.Status = "Routine";
                        
                        calendarPages[calendarPageIndex].TaskList.Add(newTask);
                    }
                }
        }


        // change Task-derived classes into an item that can be displayed by TaskListView
        private ListViewItem prepTaskForDisplay(CalendarTask task)
        { 
            ListViewItem item = new ListViewItem();
            
            item.Tag = task;
            
            item.Text = task.Name;
            
            // assign appropriate group
            //!!!!! magic numbers ahead
            if (task.IsDone)
                item.Group = this.Groups[3];
            else if (task.Priority == "High")
                item.Group = this.Groups[0];
            else if (task.Priority == "Normal")
                item.Group = this.Groups[1];
            else
                item.Group = this.Groups[2];

            item.SubItems.Add(task.Status);

            return item;
        }
        private ListViewItem prepTaskForDisplay(RoutineTask task)
        {
            ListViewItem item = new ListViewItem();

            item.Tag = task;

            item.Text = task.Name;

            // assign appropriate group
            //!!!!! magic numbers ahead
             if (task.Priority == "High")
                item.Group = this.Groups[0];
            else if (task.Priority == "Normal")
                item.Group = this.Groups[1];
            else
                item.Group = this.Groups[2];

            item.SubItems.Add(task.Status);

            return item;
        }

    }
}
