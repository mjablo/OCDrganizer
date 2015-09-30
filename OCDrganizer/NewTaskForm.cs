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

    public partial class NewTaskForm : Form
    {
        //--- Constructor
        public NewTaskForm()
        {
            InitializeComponent();

            comboBoxPriority.SelectedItem = "Normal";
        }

        //--- Events
        private void buttonAddTask_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
