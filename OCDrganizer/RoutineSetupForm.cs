namespace OCDrganizer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;

    public partial class RoutineSetupForm : Form
    {
        public RoutineSetupForm(List<TaskListView.RoutineTask> routineTaskList)
        {
            InitializeComponent();

            comboBoxPriority.SelectedItem = "Normal";

            displayRoutineList(ref routineTaskList);

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSaveAndExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void taskListViewWorkweek_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (taskListViewWorkweek.SelectedItems.Count > 0)
            {
                TaskListView.RoutineTask rt = (TaskListView.RoutineTask)taskListViewWorkweek.SelectedItems[0].Tag;
                
                textBoxName.Text = rt.Name;

                if (rt.Priority == "High")
                    comboBoxPriority.SelectedItem = "High";
                else if (rt.Priority == "Normal")
                    comboBoxPriority.SelectedItem = "Normal";
                else if (rt.Priority == "Low")
                    comboBoxPriority.SelectedItem = "Low";

                if (rt.IsWeekend == true)
                    checkBoxWeekend.Checked = true;
                else
                    checkBoxWeekend.Checked = false;

                if (rt.IsWorkweek == true)
                    checkBoxWorkweek.Checked = true;
                else
                    checkBoxWorkweek.Checked = false;

                taskListViewWeekend.SelectedItems.Clear();
            }
            
        }

        private void taskListViewWeekend_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (taskListViewWeekend.SelectedItems.Count > 0)
            {
                TaskListView.RoutineTask rt = (TaskListView.RoutineTask)taskListViewWeekend.SelectedItems[0].Tag;

                textBoxName.Text = rt.Name;

                if (rt.Priority == "High")
                    comboBoxPriority.SelectedItem = "High";
                else if (rt.Priority == "Normal")
                    comboBoxPriority.SelectedItem = "Normal";
                else if (rt.Priority == "Low")
                    comboBoxPriority.SelectedItem = "Low";

                if (rt.IsWeekend == true)
                    checkBoxWeekend.Checked = true;
                else
                    checkBoxWeekend.Checked = false;

                if (rt.IsWorkweek == true)
                    checkBoxWorkweek.Checked = true;
                else
                    checkBoxWorkweek.Checked = false;

                taskListViewWorkweek.SelectedItems.Clear();
            }
        }

        //--- Helpers

        private void displayRoutineList(ref List<TaskListView.RoutineTask> routineTaskList) 
        { 
            foreach (TaskListView.RoutineTask rt in routineTaskList) 
            {
                ListViewItem item = new ListViewItem();

                item.Tag = rt;
                item.Text = rt.Name;

                if (rt.Priority == "High")
                    item.Group = taskListViewWorkweek.Groups[0];
                else if (rt.Priority == "Normal")
                    item.Group = taskListViewWorkweek.Groups[1];
                else
                    item.Group = taskListViewWorkweek.Groups[2];

                if (rt.IsWorkweek && rt.IsWeekend)
                {
                    ListViewItem itemClone = (ListViewItem) item.Clone();
                    taskListViewWorkweek.Items.Add(item);
                    
                    taskListViewWeekend.Items.Add(itemClone);
                }
                else 
                {
                    if (rt.IsWorkweek)
                        taskListViewWorkweek.Items.Add(item);

                    if (rt.IsWeekend)
                        taskListViewWeekend.Items.Add(item);
                }
            }
        }


    }
}
