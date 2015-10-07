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

    public partial class MainForm : Form
    {
        
        //--- Constructors
        public MainForm()
        {
            InitializeComponent();

            // set initial date and time
            labelDate.Text = DateTime.Now.ToLongDateString() + " (Today)";
            labelTime.Text = DateTime.Now.TimeOfDay.ToString("h\\:mm");

            // populate initial list items
            taskList.DisplayCalendarPage(DateTime.Now.Date);
        }
        

        //--- Events
        //... Menu Strip
        //.. File
        
        //. Export Task List
        //      !!!!!!
        
        //. Import Task List
        //      !!!!!!
        
        //. Close
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //... Tool Strip
        //.. New Task
        private void toolStripButtonNewTask_Click(object sender, EventArgs e)
        {
            // allow changes only for present and future dates
            if (monthCalendarMain.SelectionEnd.Date >= DateTime.Now.Date)
            {
                NewTaskForm newTask = new NewTaskForm();
                newTask.Owner = this;
                newTask.ShowDialog();

                if (newTask.DialogResult == DialogResult.OK)
                {
                    taskList.AddTask(monthCalendarMain.SelectionEnd.Date, newTask.textBoxName.Text, newTask.comboBoxPriority.Text);
                }

                // refresh view
                taskList.DisplayCalendarPage(monthCalendarMain.SelectionEnd.Date);
            }
            
        }

        //.. Edit Task
        private void toolStripButtonEditTask_Click(object sender, EventArgs e)
        {
            // allow changes only for present and future dates
            if (monthCalendarMain.SelectionEnd.Date >= DateTime.Now.Date) 
            {
                if (taskList.SelectedItems.Count > 0 && taskList.SelectedItems[0].SubItems[1].Text != "Routine (Preview)")
                {
                    EditTaskForm editTask = new EditTaskForm(taskList.SelectedItems[0]);
                    editTask.Owner = this;
                    editTask.ShowDialog();

                    if (editTask.DialogResult == DialogResult.OK)
                    {
                        taskList.EditTask(taskList.SelectedItems[0], monthCalendarMain.SelectionEnd.Date,
                                          editTask.textBoxName.Text, editTask.comboBoxPriority.Text);
                    }
                }

                // refresh view
                taskList.DisplayCalendarPage(monthCalendarMain.SelectionEnd.Date);
            }
            
        }

        //.. Remove Task
        private void toolStripButtonRemoveTask_Click(object sender, EventArgs e)
        {
            if (taskList.SelectedItems.Count > 0 && taskList.SelectedItems[0].SubItems[1].Text != "Routine (Preview)")
                taskList.RemoveTask(taskList.SelectedItems[0], monthCalendarMain.SelectionEnd.Date);

            // refresh view
            taskList.DisplayCalendarPage(monthCalendarMain.SelectionEnd.Date);
        }

        //.. Routine
        private void toolStripButtonRoutine_Click(object sender, EventArgs e)
        {
            // create new temporary List<> container and copy current routine task into it
            List<TaskListView.RoutineTask> tmpRoutineTasks = new List<TaskListView.RoutineTask>();
            foreach (TaskListView.RoutineTask rt in taskList.RoutineTasks)
            {
                tmpRoutineTasks.Add(new TaskListView.RoutineTask(rt));
            }

            RoutineSetupForm routineSetup = new RoutineSetupForm(ref tmpRoutineTasks);
            routineSetup.Owner = this;
            routineSetup.ShowDialog();

            if (routineSetup.DialogResult == DialogResult.OK)
            {
                // save changes by copying back from modified temporary list
                taskList.RoutineTasks.Clear();
                taskList.RoutineTasks.AddRange(tmpRoutineTasks);

                // refresh view if neccessary
                if (monthCalendarMain.SelectionEnd.Date > DateTime.Now.Date)
                    taskList.DisplayCalendarPage(monthCalendarMain.SelectionEnd.Date);
            }
        }

        //... Task Done Button
        private void buttonDone_Click(object sender, EventArgs e)
        {
            if (taskList.SelectedItems.Count > 0)
            {
                taskList.SetAsDone(taskList.SelectedItems[0], monthCalendarMain.SelectionEnd.Date);
            }

            // refresh view
            taskList.DisplayCalendarPage(monthCalendarMain.SelectionEnd.Date);
        }


        //... Calendar
        private void monthCalendarMain_DateSelected(object sender, DateRangeEventArgs e)
        {
            taskList.DisplayCalendarPage(monthCalendarMain.SelectionEnd.Date);

            labelDate.Text = monthCalendarMain.SelectionEnd.ToLongDateString();
            if (monthCalendarMain.SelectionEnd.Date == DateTime.Now.Date)
            {
                this.SuspendLayout();
                labelDate.Text += " (Today)";
                labelDate.BackColor = Color.White;
                labelTime.BackColor = Color.White;
                taskList.BackColor = Color.White;
                this.ResumeLayout();
            }

            if (monthCalendarMain.SelectionEnd.Date < DateTime.Now.Date)
            {
                this.SuspendLayout();
                labelDate.BackColor = Color.LightGray;
                labelTime.BackColor = Color.LightGray;
                taskList.BackColor = Color.LightGray;
                this.ResumeLayout();
            }

            if (monthCalendarMain.SelectionEnd.Date > DateTime.Now.Date)
            {
                this.SuspendLayout();
                labelDate.BackColor = Color.LightBlue;
                labelTime.BackColor = Color.LightBlue;
                taskList.BackColor = Color.LightBlue;
                this.ResumeLayout();
            }
        }


        //... Clock
        // timer's tick interval is set to 1000 ms because +-1sec precision is more than enough
        private void timerMain_Tick(object sender, EventArgs e)
        {
            if (taskList.SelectedItems.Count > 0)
                labelQuickDebug.Text = taskList.SelectedItems[0].SubItems[1].Text;
            
            if (labelTime.Text != DateTime.Now.TimeOfDay.ToString("h\\:mm"))
                labelTime.Text = DateTime.Now.TimeOfDay.ToString("h\\:mm");
        }

    }
}
