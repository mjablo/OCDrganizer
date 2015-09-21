using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OCDrganizer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            // enable double buffering for TaskList control
            taskList.EnableDoubleBuffering();

            // set initial date and time
            labelDate.Text = DateTime.Now.ToLongDateString() + " (Today)";
            labelTime.Text = DateTime.Now.TimeOfDay.ToString("h\\:mm");
        }
        

        //
        // Task Done Button
        //
        private void buttonDone_Click(object sender, EventArgs e)
        {
            if (taskList.SelectedItems.Count > 0)
            {
                taskList.SetAsDone(taskList.SelectedItems[0]);
            }
        }


        //
        // Calendar
        //
        private void monthCalendarMain_DateSelected(object sender, DateRangeEventArgs e)
        {
            taskList.DisplayTaskList(monthCalendarMain.SelectionEnd.Date);

            labelDate.Text = monthCalendarMain.SelectionEnd.ToLongDateString();
            if (monthCalendarMain.SelectionEnd.Date == DateTime.Now.Date)
            {
                this.SuspendLayout();
                labelDate.Text += " (Today)";
                //labelDate.Text += " (in the past)";
                labelDate.BackColor = Color.White;
                labelTime.BackColor = Color.White;
                taskList.BackColor = Color.White;
                this.ResumeLayout();
            }
            
            if (monthCalendarMain.SelectionEnd.Date < DateTime.Now.Date)
            {
                this.SuspendLayout();
                //labelDate.Text += " (in the past)";
                labelDate.BackColor = Color.LightGray;
                labelTime.BackColor = Color.LightGray;
                taskList.BackColor = Color.LightGray;
                this.ResumeLayout();
            }

            if (monthCalendarMain.SelectionEnd.Date > DateTime.Now.Date) 
            {
                this.SuspendLayout();
                labelDate.BackColor = Color.Azure;
                labelTime.BackColor = Color.Azure;
                taskList.BackColor = Color.Azure;
                this.ResumeLayout();
            }
        }


        //
        // Menu Strip Items
        //
        //* File
        //** Export Task List
        //   !!!!!!
        //** Import Task List
        //   !!!!!!
        //** Close
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //
        // Tool Strip
        //
        //* Add New Task
        private void toolStripButtonAddNewTask_Click(object sender, EventArgs e)
        {
            if (monthCalendarMain.SelectionEnd.Date >= DateTime.Now.Date)
            {
                // !!!
                taskList.AddTask("TASK", monthCalendarMain.SelectionEnd.Date);
            }
            
        }
        //* Edit Task !!!
        private void toolStripButtonEditTask_Click(object sender, EventArgs e)
        {
            // !!!
            DateTime date = taskList.GetDate(taskList.SelectedItems[0]);
            MessageBox.Show(date.ToLongDateString());
            // !!!
        }
        //* Remove Task
        private void toolStripButtonRemoveTask_Click(object sender, EventArgs e)
        {
            if (taskList.SelectedItems.Count > 0)
                taskList.RemoveTask(taskList.SelectedItems[0]);
        }


        //
        // Clock
        // tick interval set to 1000 ms 'cause +-1sec precision is more than enough
        //
        private void timerMain_Tick(object sender, EventArgs e)
        {
            // DEBUG
            labelQuickDebug.Text = "listForDates.Count = ";
            labelQuickDebug.Text += taskList.listForDatesCount();
            // eof DEBUG

            if (labelTime.Text != DateTime.Now.TimeOfDay.ToString("h\\:mm"))
                labelTime.Text = DateTime.Now.TimeOfDay.ToString("h\\:mm");
        }




    }
}
