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
        //--- Fields
        private List<TaskListView.RoutineTask> tmpRoutineTaskList;

        //--- Constructors
        public RoutineSetupForm(ref List<TaskListView.RoutineTask> routineTaskList)
        {
            InitializeComponent();

            comboBoxPriority.SelectedItem = "Normal";

            tmpRoutineTaskList = routineTaskList;

            displayRoutineList();
        }


        //--- Events
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSaveAndExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonApplyChanges_Click(object sender, EventArgs e)
        {
            // button is visible only when item is selected, so it is assumed that selected item exists
            TaskListView.RoutineTask rt = (TaskListView.RoutineTask)taskListViewRoutinePreview.SelectedItems[0].Tag;

            rt.Name = textBoxName.Text;
            rt.Priority = comboBoxPriority.Text;

            if (checkBoxWorkweek.Checked)
                rt.IsWorkweek = true;
            else
                rt.IsWorkweek = false;

            if (checkBoxWeekend.Checked)
                rt.IsWeekend = true;
            else
                rt.IsWeekend = false;

            displayRoutineList();
        }


        private void taskListViewRoutinePreview_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                TaskListView.RoutineTask rt = (TaskListView.RoutineTask)taskListViewRoutinePreview.SelectedItems[0].Tag;

                buttonAddRoutineTask.Visible = false;
                buttonApplyChanges.Visible = true;

                textBoxName.Text = rt.Name;

                if (rt.Priority == "High")
                    comboBoxPriority.SelectedItem = "High";
                else if (rt.Priority == "Normal")
                    comboBoxPriority.SelectedItem = "Normal";
                else
                    comboBoxPriority.SelectedItem = "Low";

                if (rt.IsWeekend == true)
                    checkBoxWeekend.Checked = true;
                else
                    checkBoxWeekend.Checked = false;

                if (rt.IsWorkweek == true)
                    checkBoxWorkweek.Checked = true;
                else
                    checkBoxWorkweek.Checked = false;
            }
            else
            {
                textBoxName.Text = "";
                comboBoxPriority.SelectedItem = "Normal";
                checkBoxWorkweek.Checked = false;
                checkBoxWorkweek.Checked = false;

                buttonApplyChanges.Visible = false;
                buttonAddRoutineTask.Visible = true;
            }
        }

        private void buttonAddRoutineTask_Click(object sender, EventArgs e)
        {
            TaskListView.RoutineTask newRoutine = new TaskListView.RoutineTask(textBoxName.Text, comboBoxPriority.Text,
                                                                               checkBoxWorkweek.Checked, checkBoxWeekend.Checked);
            tmpRoutineTaskList.Add(newRoutine);

            displayRoutineList();

            // cleanup
            textBoxName.Text = "";
            comboBoxPriority.SelectedItem = "Normal";
            checkBoxWorkweek.Checked = false;
            checkBoxWeekend.Checked = false;
        }


        //--- Helpers
        private void displayRoutineList() 
        {
            taskListViewRoutinePreview.Items.Clear();

            foreach (TaskListView.RoutineTask rt in tmpRoutineTaskList) 
            {
                ListViewItem item = new ListViewItem();
                
                item.Tag = rt;
                item.Text = rt.Name;

                if (rt.Priority == "High")
                    item.Group = taskListViewRoutinePreview.Groups[0];
                else if (rt.Priority == "Normal")
                    item.Group = taskListViewRoutinePreview.Groups[1];
                else
                    item.Group = taskListViewRoutinePreview.Groups[2];

                item.SubItems.Add("");
                item.SubItems.Add("");

                if (rt.IsWorkweek) 
                {
                    item.SubItems[1].Text = "\u2713";
                }
                if (rt.IsWeekend)
                {
                    item.SubItems[2].Text = "\u2713";
                }

                taskListViewRoutinePreview.Items.Add(item);
            }
        }

    }
}
