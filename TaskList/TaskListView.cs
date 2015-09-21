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

        //!!!! debug
        public string listForDatesCount() 
        {
            return listForDates.Count.ToString();
        }
        //!!!! eof debug

        private const int listsIndexNotFound = -1;

        public const int isDoneColumnIndex = 1;

        //
        // Methods
        //
        public void EnableDoubleBuffering() 
        {
            this.DoubleBuffered = true;
        }

        public void DisableDoubleBuffering()
        {
            this.DoubleBuffered = false;
        }


        public void AddTask(string name, DateTime date) 
        {
            int index;

            // if it's a 
            if (listForDates.Count == 0)
            {
                TaskListForDate newListItem = new TaskListForDate(date);
                listForDates.Add(newListItem);
                index = 0;
            }
            else
            {
                index = GetListsIndexByDate(date);

                if (index == listsIndexNotFound)
                {
                    // add a new item at the end of a list and get its index from current count,
                    // line below works because []indexes start from 0 while .Counts from 1
                    index = listForDates.Count;

                    TaskListForDate newListItem = new TaskListForDate(date);
                    listForDates.Add(newListItem);
                }
            }
            Task newTask = new Task(name, date);
            listForDates[index].AddTask(newTask);

            DisplayTaskListByIndex(index);
        }

        public void RemoveTask(ListViewItem item) 
        {
            // cast tagged ListViewItem's object into usable form, extract Date properity
            // and use it to get listForDates []indexer
            Task task = (Task)item.Tag;
            int listForDatesIndexer = GetListsIndexByDate(task.Date);

            // iterate through proper listForDates[] inner TaskList[]
            for (int i = 0; i < listForDates[listForDatesIndexer].TaskList.Count; i++)
                // if Task.Index properties match
                if (task.Index == listForDates[listForDatesIndexer].TaskList[i].Index)
                {
                    // remove that task and break out of the rest of the loop
                    listForDates[listForDatesIndexer].TaskList.RemoveAt(i);
                    break;
                }

            // if the last task from the list was removed, also remove now empty 
            // and unnecessary listForDates item
            if (listForDates[listForDatesIndexer].TaskList.Count == 0)
            {
                listForDates.RemoveAt(listForDatesIndexer);
                listForDatesIndexer = listsIndexNotFound;
            }

            // Refresh items displayed by TaskViewList
            DisplayTaskListByIndex(listForDatesIndexer);
        }

        public void SetAsDone(ListViewItem item)
        {
            Task task = (Task)item.Tag;
            task.IsDone = true;
            this.Items[item.Index].SubItems[isDoneColumnIndex].Text = "Done";
        }

        public void DisplayTaskList(DateTime date) 
        {
            DisplayTaskListByIndex(GetListsIndexByDate(date));
        }

        // !!!
        public DateTime GetDate(ListViewItem item)
        { 
            Task task = (Task)item.Tag;
            return task.Date;
        }
        // !!!

        //
        // Helpers
        //
        //* Display tasks from proper listForDates container, based on its []indexer
        private void DisplayTaskListByIndex(int index) 
        {
            // clear every TaskListView item
            this.Items.Clear();

            if (index != listsIndexNotFound)
            {
                foreach (Task t in listForDates[index].TaskList)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = t.Name;

                    if (t.IsDone)
                        item.SubItems.Add("Done");
                    else
                        item.SubItems.Add("");

                    item.Tag = t;

                    this.Items.Add(item);
                }
            }
        }

        //* Find whether task's list for that date already exists
        //* if so, return it's list[] index
        //* otherwise return listsIndexNotFound
        private int GetListsIndexByDate(DateTime date) 
        {
            bool dateFoundFlag = false;
            int i = 0;

            while (i < listForDates.Count && !dateFoundFlag)
            {
                if (listForDates[i].Date == date.Date)
                    dateFoundFlag = true;
                else
                    i++;
            }

            if (!dateFoundFlag)
                i = listsIndexNotFound;
            
            return i;
        }
    }
}
