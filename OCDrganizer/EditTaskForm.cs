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

    public partial class EditTaskForm : Form
    {
        //--- Constructor
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
                /* if task is already finished, don't allow changes to priority;
                 * and since DropDownList style of comboBox looks similar to a button,
                 * replace the whole thing with inactive, same sized button */

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

        //--- Events
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
