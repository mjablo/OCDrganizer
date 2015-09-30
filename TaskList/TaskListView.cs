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
        private const int calendarPageIndexNotFound = -1;

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
            //routineTasks.Add(new RoutineTask("routine1", "Normal", true, true));
            //routineTasks.Add(new RoutineTask("routine2", "Normal", true, false));
            //routineTasks.Add(new RoutineTask("routine3", "Normal", false, true));
            //!!! eof debug
        }

        //--- Properties
        public List<RoutineTask> RoutineTasks 
        {
            get { return routineTasks; }
        }

        //--- Methods
        public void AddTask(string name, DateTime calendarSelectedDate, string priority)
        {
            // check if list for given date already exists; create one if doesn't
            int calendarPageIndex = getCalendarPageIndexByDate(calendarSelectedDate);
            if (calendarPageIndex == calendarPageIndexNotFound)
            {
                // save index now, add item later (because indexing starts with 0, counting with 1)
                calendarPageIndex = calendarPages.Count;

                calendarPages.Add(new CalendarPage(calendarSelectedDate));
            }

            // add new task
            calendarPages[calendarPageIndex].TaskList.Add(new ListedTask(name, priority));

            // refresh view
            DisplayCalendarPage(calendarSelectedDate);
        }

        public void EditTask(ListViewItem item, DateTime calendarSelectedDate, string name, string priority)
        {
            ListedTask task = (ListedTask)item.Tag;

            task.Name = name;
            if(!task.IsDone)
                task.Priority = priority;

            // refresh view
            DisplayCalendarPage(calendarSelectedDate);
        }

        public void RemoveTask(ListViewItem item, DateTime calendarSelectedDate) 
        {
            ListedTask task = (ListedTask)item.Tag;

            int calendarPageIndex = getCalendarPageIndexByDate(calendarSelectedDate);

            // iterate through proper CalendarPage's inner container 
            // and remove item with matching index
            for (int i = 0; i < calendarPages[calendarPageIndex].TaskList.Count; i++)
                if (task.Index == calendarPages[calendarPageIndex].TaskList[i].Index)
                {
                    calendarPages[calendarPageIndex].TaskList.RemoveAt(i);
                    break;
                }

            // if the last task from the list was removed, also remove now empty 
            // and unnecessary listForDates item
            if (calendarPages[calendarPageIndex].TaskList.Count == 0)
            {
                calendarPages.RemoveAt(calendarPageIndex);
                calendarPageIndex = calendarPageIndexNotFound;
            }

            // refresh view
            DisplayCalendarPage(calendarSelectedDate);
        }

        public void SetAsDone(ListViewItem item, DateTime calendarSelectedDate)
        {
            ListedTask task = (ListedTask)item.Tag;

            task.IsDone = true;
            
            // refresh view
            DisplayCalendarPage(calendarSelectedDate);
        }

        public void DisplayCalendarPage(DateTime calendarSelectedDate) 
        {
            this.Items.Clear();

            int listForDatesIndex = getCalendarPageIndexByDate(calendarSelectedDate);
            if (listForDatesIndex != calendarPageIndexNotFound)
            {
                // Routine tasks
                if (calendarPages[listForDatesIndex].HasRoutineTasksAdded == false)
                    populateCalendarPageWithRoutineTasks(calendarSelectedDate);

                // Planned tasks
                foreach (ListedTask t in calendarPages[listForDatesIndex].TaskList)
                {
                    this.Items.Add(prepTaskForDisplay(t));
                }
            }
            else 
            { 
                // display preview of routine tasks in future dates
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


        }


        //--- Helpers
        
        // return listForDates index if it exists, otherwise return listsIndexNotFound
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
                index = calendarPageIndexNotFound;
            
            return index;
        }

        // change Task-based classes into a form that can be displayed by TaskListView
        private ListViewItem prepTaskForDisplay(ListedTask task)
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

        // 
        private void populateCalendarPageWithRoutineTasks(DateTime date)
        {
            int calendarPageIndex = getCalendarPageIndexByDate(date);

            foreach (RoutineTask rt in routineTasks)
            {
                // create ListedTask based on RoutineTask 
                ListedTask newTask = new ListedTask(rt.Name, rt.Priority);
                newTask.Status = "Routine";

                calendarPages[calendarPageIndex].TaskList.Add(newTask);
            }

            calendarPages[calendarPageIndex].HasRoutineTasksAdded = true;
        }
    }
}
