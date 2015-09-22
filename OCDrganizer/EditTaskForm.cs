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
    public partial class EditTaskForm : Form
    {
        public EditTaskForm(ListViewItem item)
        {
            InitializeComponent();

            textBoxName.Text = item.Text;

            if(item.Group.Header == "High Priority")
                comboBoxPriority.SelectedItem = "High";
            else if (item.Group.Header == "Normal Priority")
                comboBoxPriority.SelectedItem = "Normal";
            else if (item.Group.Header == "Low Priority")
                comboBoxPriority.SelectedItem = "Low";
            else 
            {
                SuspendLayout();

                comboBoxPriority.Visible = false;
                Button ButtonAlreadyFinishedMask = new Button();
                ButtonAlreadyFinishedMask.Location = comboBoxPriority.Location;
                ButtonAlreadyFinishedMask.Size = comboBoxPriority.Size;
                ButtonAlreadyFinishedMask.Text = "Already Finished";
                ButtonAlreadyFinishedMask.TextAlign = ContentAlignment.TopLeft;
                this.Controls.Add(ButtonAlreadyFinishedMask);

                ResumeLayout();
            }

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonEditTask_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
