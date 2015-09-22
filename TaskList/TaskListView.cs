namespace TaskListView
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;

    public class TaskListView : ListView
    {
        //!!! debug
        public string listForDatesCount()
        {
            return taskListForDates.Count.ToString();
        }


        //--- Fields
        private const int listsIndexNotFound = -1;

        private List<TaskListForDate> taskListForDates = new List<TaskListForDate>();


        //--- Constructors
        public TaskListView() : base() { }


        //--- Methods
        public void AddTask(string name, DateTime date, string priority)
        {
            int listForDatesIndex = getListsIndexByDate(date);
            
            if (listForDatesIndex == listsIndexNotFound)
            {
                // save index now, add item later (because indexing starts with 0)
                listForDatesIndex = taskListForDates.Count;

                taskListForDates.Add(new TaskListForDate(date));
            }
    
            taskListForDates[listForDatesIndex].TaskList.Add(new Task(name, date, priority));

            displayTaskListByListIndex(listForDatesIndex);
        }

        public void EditTask(ListViewItem item, DateTime calendarsSelectedDate, string name, string priority)
        {
            Task task = (Task)item.Tag;

            task.Name = name;
            if(!task.IsDone)
                task.Priority = priority;

            DisplayTaskListByDate(calendarsSelectedDate);
        }

        public void RemoveTask(ListViewItem item) 
        {
            Task task = (Task)item.Tag;

            int listForDatesIndex = getListsIndexByDate(task.Date);

            // iterate through proper listForDates[] inner container 
            // and remove item with matching index
            for (int i = 0; i < taskListForDates[listForDatesIndex].TaskList.Count; i++)
                if (task.Index == taskListForDates[listForDatesIndex].TaskList[i].Index)
                {
                    taskListForDates[listForDatesIndex].TaskList.RemoveAt(i);
                    break;
                }

            // if the last task from the list was removed, also remove now empty 
            // and unnecessary listForDates item
            if (taskListForDates[listForDatesIndex].TaskList.Count == 0)
            {
                taskListForDates.RemoveAt(listForDatesIndex);
                listForDatesIndex = listsIndexNotFound;
            }

            displayTaskListByListIndex(listForDatesIndex);
        }

        public void SetAsDone(ListViewItem item)
        {
            Task task = (Task)item.Tag;

            task.IsDone = true;
            
            DisplayTaskListByDate(task.Date);
        }

        public void DisplayTaskListByDate(DateTime date) 
        {
            displayTaskListByListIndex(getListsIndexByDate(date));
        }

        public void EnableDoubleBuffering() { this.DoubleBuffered = true; }
        public void DisableDoubleBuffering() { this.DoubleBuffered = false; }

        
        //--- Helpers
        private void displayTaskListByListIndex(int index) 
        {
            this.Items.Clear();

            if (index != listsIndexNotFound)
            {
                foreach (Task t in taskListForDates[index].TaskList)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = t.Name;

                    
                    // assign appropriate group
                    // !!!!! magic numbers ahead
                    if (t.IsDone)
                        item.Group = this.Groups[3];
                    else if (t.Priority == "High")
                        item.Group = this.Groups[0];
                    else if (t.Priority == "Normal")
                        item.Group = this.Groups[1];
                    else 
                        item.Group = this.Groups[2];


                    item.Tag = t;

                    this.Items.Add(item);
                }
            }
        }

        // return listForDates index if it exists, otherwise return listsIndexNotFound
        private int getListsIndexByDate(DateTime date) 
        {
            bool dateFoundFlag = false;
            int index = 0;

            while (index < taskListForDates.Count && !dateFoundFlag)
            {
                if (taskListForDates[index].Date == date.Date)
                    dateFoundFlag = true;
                else
                    index++;
            }

            if (!dateFoundFlag)
                index = listsIndexNotFound;
            
            return index;
        }

    }
}
