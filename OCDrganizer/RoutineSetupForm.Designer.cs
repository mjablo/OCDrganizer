namespace OCDrganizer
{
    partial class RoutineSetupForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("High Priority", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Normal Priority", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("Low Priority", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("High Priority", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("Normal Priority", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup6 = new System.Windows.Forms.ListViewGroup("Low Priority", System.Windows.Forms.HorizontalAlignment.Left);
            this.buttonSaveAndExit = new System.Windows.Forms.Button();
            this.groupBoxAddEdit = new System.Windows.Forms.GroupBox();
            this.buttonAddTask = new System.Windows.Forms.Button();
            this.labelRoutine = new System.Windows.Forms.Label();
            this.checkBoxWeekend = new System.Windows.Forms.CheckBox();
            this.checkBoxWorkweek = new System.Windows.Forms.CheckBox();
            this.comboBoxPriority = new System.Windows.Forms.ComboBox();
            this.labelPriority = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.groupBoxPreview = new System.Windows.Forms.GroupBox();
            this.labelWeekend = new System.Windows.Forms.Label();
            this.labelWorkweek = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.taskListViewWeekend = new TaskListView.TaskListView();
            this.columnHeaderWeekendName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.taskListViewWorkweek = new TaskListView.TaskListView();
            this.columnHeaderWorkweekName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxAddEdit.SuspendLayout();
            this.groupBoxPreview.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSaveAndExit
            // 
            this.buttonSaveAndExit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSaveAndExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSaveAndExit.Location = new System.Drawing.Point(480, 456);
            this.buttonSaveAndExit.Name = "buttonSaveAndExit";
            this.buttonSaveAndExit.Size = new System.Drawing.Size(153, 45);
            this.buttonSaveAndExit.TabIndex = 12;
            this.buttonSaveAndExit.Text = "Save and Exit";
            this.buttonSaveAndExit.UseVisualStyleBackColor = true;
            this.buttonSaveAndExit.Click += new System.EventHandler(this.buttonSaveAndExit_Click);
            // 
            // groupBoxAddEdit
            // 
            this.groupBoxAddEdit.Controls.Add(this.buttonAddTask);
            this.groupBoxAddEdit.Controls.Add(this.labelName);
            this.groupBoxAddEdit.Controls.Add(this.labelRoutine);
            this.groupBoxAddEdit.Controls.Add(this.textBoxName);
            this.groupBoxAddEdit.Controls.Add(this.checkBoxWeekend);
            this.groupBoxAddEdit.Controls.Add(this.labelPriority);
            this.groupBoxAddEdit.Controls.Add(this.checkBoxWorkweek);
            this.groupBoxAddEdit.Controls.Add(this.comboBoxPriority);
            this.groupBoxAddEdit.Location = new System.Drawing.Point(12, 12);
            this.groupBoxAddEdit.Name = "groupBoxAddEdit";
            this.groupBoxAddEdit.Size = new System.Drawing.Size(472, 135);
            this.groupBoxAddEdit.TabIndex = 13;
            this.groupBoxAddEdit.TabStop = false;
            this.groupBoxAddEdit.Text = "Add/Edit Task";
            // 
            // buttonAddTask
            // 
            this.buttonAddTask.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonAddTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAddTask.Location = new System.Drawing.Point(345, 102);
            this.buttonAddTask.Name = "buttonAddTask";
            this.buttonAddTask.Size = new System.Drawing.Size(121, 27);
            this.buttonAddTask.TabIndex = 21;
            this.buttonAddTask.Text = "Add task";
            this.buttonAddTask.UseVisualStyleBackColor = true;
            // 
            // labelRoutine
            // 
            this.labelRoutine.AutoSize = true;
            this.labelRoutine.Location = new System.Drawing.Point(352, 16);
            this.labelRoutine.Name = "labelRoutine";
            this.labelRoutine.Size = new System.Drawing.Size(47, 13);
            this.labelRoutine.TabIndex = 20;
            this.labelRoutine.Text = "Routine:";
            // 
            // checkBoxWeekend
            // 
            this.checkBoxWeekend.AutoSize = true;
            this.checkBoxWeekend.Location = new System.Drawing.Point(355, 57);
            this.checkBoxWeekend.Name = "checkBoxWeekend";
            this.checkBoxWeekend.Size = new System.Drawing.Size(73, 17);
            this.checkBoxWeekend.TabIndex = 19;
            this.checkBoxWeekend.Text = "Weekend";
            this.checkBoxWeekend.UseVisualStyleBackColor = true;
            // 
            // checkBoxWorkweek
            // 
            this.checkBoxWorkweek.AutoSize = true;
            this.checkBoxWorkweek.Location = new System.Drawing.Point(355, 34);
            this.checkBoxWorkweek.Name = "checkBoxWorkweek";
            this.checkBoxWorkweek.Size = new System.Drawing.Size(78, 17);
            this.checkBoxWorkweek.TabIndex = 18;
            this.checkBoxWorkweek.Text = "Workweek";
            this.checkBoxWorkweek.UseVisualStyleBackColor = true;
            // 
            // comboBoxPriority
            // 
            this.comboBoxPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPriority.FormattingEnabled = true;
            this.comboBoxPriority.Items.AddRange(new object[] {
            "High",
            "Normal",
            "Low"});
            this.comboBoxPriority.Location = new System.Drawing.Point(217, 32);
            this.comboBoxPriority.Name = "comboBoxPriority";
            this.comboBoxPriority.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPriority.TabIndex = 17;
            // 
            // labelPriority
            // 
            this.labelPriority.AutoSize = true;
            this.labelPriority.Location = new System.Drawing.Point(214, 16);
            this.labelPriority.Name = "labelPriority";
            this.labelPriority.Size = new System.Drawing.Size(41, 13);
            this.labelPriority.TabIndex = 16;
            this.labelPriority.Text = "Priority:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(15, 16);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(34, 13);
            this.labelName.TabIndex = 15;
            this.labelName.Text = "Task:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(18, 32);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(180, 20);
            this.textBoxName.TabIndex = 14;
            // 
            // groupBoxPreview
            // 
            this.groupBoxPreview.Controls.Add(this.labelWeekend);
            this.groupBoxPreview.Controls.Add(this.taskListViewWeekend);
            this.groupBoxPreview.Controls.Add(this.taskListViewWorkweek);
            this.groupBoxPreview.Controls.Add(this.labelWorkweek);
            this.groupBoxPreview.Location = new System.Drawing.Point(12, 147);
            this.groupBoxPreview.Name = "groupBoxPreview";
            this.groupBoxPreview.Size = new System.Drawing.Size(621, 303);
            this.groupBoxPreview.TabIndex = 14;
            this.groupBoxPreview.TabStop = false;
            this.groupBoxPreview.Text = "Preview";
            // 
            // labelWeekend
            // 
            this.labelWeekend.AutoSize = true;
            this.labelWeekend.Location = new System.Drawing.Point(306, 26);
            this.labelWeekend.Name = "labelWeekend";
            this.labelWeekend.Size = new System.Drawing.Size(92, 13);
            this.labelWeekend.TabIndex = 7;
            this.labelWeekend.Text = "Weekend routine:";
            // 
            // labelWorkweek
            // 
            this.labelWorkweek.AutoSize = true;
            this.labelWorkweek.Location = new System.Drawing.Point(6, 26);
            this.labelWorkweek.Name = "labelWorkweek";
            this.labelWorkweek.Size = new System.Drawing.Size(97, 13);
            this.labelWorkweek.TabIndex = 4;
            this.labelWorkweek.Text = "Workweek routine:";
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCancel.Location = new System.Drawing.Point(321, 456);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(153, 45);
            this.buttonCancel.TabIndex = 15;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // taskListViewWeekend
            // 
            this.taskListViewWeekend.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderWeekendName});
            listViewGroup1.Header = "High Priority";
            listViewGroup1.Name = "listViewGroupHigh";
            listViewGroup2.Header = "Normal Priority";
            listViewGroup2.Name = "listViewGroupNormal";
            listViewGroup3.Header = "Low Priority";
            listViewGroup3.Name = "listViewGroupLow";
            this.taskListViewWeekend.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3});
            this.taskListViewWeekend.HideSelection = false;
            this.taskListViewWeekend.Location = new System.Drawing.Point(309, 42);
            this.taskListViewWeekend.MultiSelect = false;
            this.taskListViewWeekend.Name = "taskListViewWeekend";
            this.taskListViewWeekend.Size = new System.Drawing.Size(303, 250);
            this.taskListViewWeekend.TabIndex = 6;
            this.taskListViewWeekend.UseCompatibleStateImageBehavior = false;
            this.taskListViewWeekend.View = System.Windows.Forms.View.Details;
            this.taskListViewWeekend.SelectedIndexChanged += new System.EventHandler(this.taskListViewWeekend_SelectedIndexChanged);
            // 
            // columnHeaderWeekendName
            // 
            this.columnHeaderWeekendName.Text = "Task";
            this.columnHeaderWeekendName.Width = 147;
            // 
            // taskListViewWorkweek
            // 
            this.taskListViewWorkweek.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderWorkweekName});
            listViewGroup4.Header = "High Priority";
            listViewGroup4.Name = "listViewGroupHigh";
            listViewGroup5.Header = "Normal Priority";
            listViewGroup5.Name = "listViewGroupNormal";
            listViewGroup6.Header = "Low Priority";
            listViewGroup6.Name = "listViewGroupLow";
            this.taskListViewWorkweek.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup4,
            listViewGroup5,
            listViewGroup6});
            this.taskListViewWorkweek.HideSelection = false;
            this.taskListViewWorkweek.Location = new System.Drawing.Point(9, 42);
            this.taskListViewWorkweek.MultiSelect = false;
            this.taskListViewWorkweek.Name = "taskListViewWorkweek";
            this.taskListViewWorkweek.Size = new System.Drawing.Size(294, 250);
            this.taskListViewWorkweek.TabIndex = 5;
            this.taskListViewWorkweek.UseCompatibleStateImageBehavior = false;
            this.taskListViewWorkweek.View = System.Windows.Forms.View.Details;
            this.taskListViewWorkweek.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.taskListViewWorkweek_ItemSelectionChanged);
            // 
            // columnHeaderWorkweekName
            // 
            this.columnHeaderWorkweekName.Text = "Task";
            this.columnHeaderWorkweekName.Width = 133;
            // 
            // RoutineSetupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 508);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.groupBoxPreview);
            this.Controls.Add(this.groupBoxAddEdit);
            this.Controls.Add(this.buttonSaveAndExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "RoutineSetupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Routine Setup";
            this.groupBoxAddEdit.ResumeLayout(false);
            this.groupBoxAddEdit.PerformLayout();
            this.groupBoxPreview.ResumeLayout(false);
            this.groupBoxPreview.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSaveAndExit;
        private System.Windows.Forms.GroupBox groupBoxAddEdit;
        private System.Windows.Forms.Button buttonAddTask;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelRoutine;
        public System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.CheckBox checkBoxWeekend;
        private System.Windows.Forms.Label labelPriority;
        private System.Windows.Forms.CheckBox checkBoxWorkweek;
        public System.Windows.Forms.ComboBox comboBoxPriority;
        private System.Windows.Forms.GroupBox groupBoxPreview;
        private System.Windows.Forms.Label labelWeekend;
        private TaskListView.TaskListView taskListViewWeekend;
        private System.Windows.Forms.ColumnHeader columnHeaderWeekendName;
        private TaskListView.TaskListView taskListViewWorkweek;
        private System.Windows.Forms.ColumnHeader columnHeaderWorkweekName;
        private System.Windows.Forms.Label labelWorkweek;
        private System.Windows.Forms.Button buttonCancel;

    }
}