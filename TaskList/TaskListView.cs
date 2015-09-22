using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TaskListView
{
    public class TaskListView : ListView
    {
        
        private List<TaskListForDate> listForDates = new List<TaskListForDate>();
        private const int listsIndexNotFound = -1;
        
        //!!!! debug
        public string listForDatesCount() 
        {
            return listForDates.Count.ToString();
        }
        //!!!! eof debug

        public void EnableDoubleBuffering() 
        {
            this.DoubleBuffered = true;
        }
        public void DisableDoubleBuffering()
        {
            this.DoubleBuffered = false;
        }


        public void AddTask(string name, DateTime date, string priority)
        {
            int listForDatesIndex;

            // check if it's a first task to be ever created
            if (listForDates.Count == 0)
            {
                TaskListForDate newListItem = new TaskListForDate(date);
                listForDates.Add(newListItem);
                listForDatesIndex = 0;
            }
            else
            {
                listForDatesIndex = getListsIndexByDate(date);

                if (listForDatesIndex == listsIndexNotFound)
                {
                    // add a new item at the end of a list and get its index from current count,
                    // line below works because []indexes start from 0 while .Counts from 1
                    listForDatesIndex = listForDates.Count;

                    TaskListForDate newListItem = new TaskListForDate(date);
                    listForDates.Add(newListItem);
                }
            }
            Task newTask = new Task(name, date, priority);            
            listForDates[listForDatesIndex].AddTask(newTask);

            displayTaskListByListIndex(listForDatesIndex);
        }

        public void EditTask(ListViewItem item, DateTime calendarsSelectedDate, string name, string priority)
        {
            // cast tagged ListViewItem's object into usable form
            Task task = (Task)item.Tag;

            task.Name = name;
            if(!task.IsDone)
                task.Priority = priority;

            DisplayTaskListByDate(calendarsSelectedDate);
        }

        public void RemoveTask(ListViewItem item) 
        {
            // cast tagged ListViewItem's object into usable form
            Task task = (Task)item.Tag;

            // extract Date properity and use it to get listForDates index
            int listForDatesIndex = getListsIndexByDate(task.Date);

            // iterate through proper listForDates inner TaskList
            for (int i = 0; i < listForDates[listForDatesIndex].TaskList.Count; i++)
                // if Task.Index properties match
                if (task.Index == listForDates[listForDatesIndex].TaskList[i].Index)
                {
                    // remove that task and break out of the rest of the loop
                    listForDates[listForDatesIndex].TaskList.RemoveAt(i);
                    break;
                }

            // if the last task from the list was removed, also remove now empty 
            // and unnecessary listForDates item
            if (listForDates[listForDatesIndex].TaskList.Count == 0)
            {
                listForDates.RemoveAt(listForDatesIndex);
                listForDatesIndex = listsIndexNotFound;
            }

            // Refresh items displayed by TaskViewList
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

        #region helpers
        
        private void displayTaskListByListIndex(int index) 
        {
            // clear every TaskListView item
            this.Items.Clear();

            if (index != listsIndexNotFound)
            {
                foreach (Task t in listForDates[index].TaskList)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = t.Name;

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

        // return listForDates index if it exists,
        // otherwise return listsIndexNotFound
        private int getListsIndexByDate(DateTime date) 
        {
            bool dateFoundFlag = false;
            int index = 0;

            while (index < listForDates.Count && !dateFoundFlag)
            {
                if (listForDates[index].Date == date.Date)
                    dateFoundFlag = true;
                else
                    index++;
            }

            if (!dateFoundFlag)
                index = listsIndexNotFound;
            
            return index;
        }
        
        #endregion

    }
}
