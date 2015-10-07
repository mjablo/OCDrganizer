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
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("High Priority", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("Normal Priority", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup6 = new System.Windows.Forms.ListViewGroup("Low Priority", System.Windows.Forms.HorizontalAlignment.Left);
            this.buttonSaveAndExit = new System.Windows.Forms.Button();
            this.groupBoxAddEdit = new System.Windows.Forms.GroupBox();
            this.buttonAddRoutineTask = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.labelRoutine = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.checkBoxWeekend = new System.Windows.Forms.CheckBox();
            this.labelPriority = new System.Windows.Forms.Label();
            this.checkBoxWorkweek = new System.Windows.Forms.CheckBox();
            this.comboBoxPriority = new System.Windows.Forms.ComboBox();
            this.groupBoxPreview = new System.Windows.Forms.GroupBox();
            this.taskListViewRoutinePreview = new TaskListView.TaskListView();
            this.columnHeaderWorkweekName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderWorkweek = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderWeekend = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonApplyChanges = new System.Windows.Forms.Button();
            this.groupBoxAddEdit.SuspendLayout();
            this.groupBoxPreview.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSaveAndExit
            // 
            this.buttonSaveAndExit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSaveAndExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSaveAndExit.Location = new System.Drawing.Point(214, 456);
            this.buttonSaveAndExit.Name = "buttonSaveAndExit";
            this.buttonSaveAndExit.Size = new System.Drawing.Size(153, 45);
            this.buttonSaveAndExit.TabIndex = 12;
            this.buttonSaveAndExit.Text = "Save and Exit";
            this.buttonSaveAndExit.UseVisualStyleBackColor = true;
            this.buttonSaveAndExit.Click += new System.EventHandler(this.buttonSaveAndExit_Click);
            // 
            // groupBoxAddEdit
            // 
            this.groupBoxAddEdit.Controls.Add(this.labelName);
            this.groupBoxAddEdit.Controls.Add(this.labelRoutine);
            this.groupBoxAddEdit.Controls.Add(this.textBoxName);
            this.groupBoxAddEdit.Controls.Add(this.checkBoxWeekend);
            this.groupBoxAddEdit.Controls.Add(this.labelPriority);
            this.groupBoxAddEdit.Controls.Add(this.checkBoxWorkweek);
            this.groupBoxAddEdit.Controls.Add(this.comboBoxPriority);
            this.groupBoxAddEdit.Controls.Add(this.buttonAddRoutineTask);
            this.groupBoxAddEdit.Controls.Add(this.buttonApplyChanges);
            this.groupBoxAddEdit.Location = new System.Drawing.Point(12, 12);
            this.groupBoxAddEdit.Name = "groupBoxAddEdit";
            this.groupBoxAddEdit.Size = new System.Drawing.Size(355, 135);
            this.groupBoxAddEdit.TabIndex = 13;
            this.groupBoxAddEdit.TabStop = false;
            this.groupBoxAddEdit.Text = "Add/Edit Task";
            // 
            // buttonAddRoutineTask
            // 
            this.buttonAddRoutineTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAddRoutineTask.Location = new System.Drawing.Point(217, 102);
            this.buttonAddRoutineTask.Name = "buttonAddRoutineTask";
            this.buttonAddRoutineTask.Size = new System.Drawing.Size(121, 27);
            this.buttonAddRoutineTask.TabIndex = 21;
            this.buttonAddRoutineTask.Text = "Add Routine Task";
            this.buttonAddRoutineTask.UseVisualStyleBackColor = true;
            this.buttonAddRoutineTask.Click += new System.EventHandler(this.buttonAddRoutineTask_Click);
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
            // labelRoutine
            // 
            this.labelRoutine.AutoSize = true;
            this.labelRoutine.Location = new System.Drawing.Point(15, 61);
            this.labelRoutine.Name = "labelRoutine";
            this.labelRoutine.Size = new System.Drawing.Size(47, 13);
            this.labelRoutine.TabIndex = 20;
            this.labelRoutine.Text = "Routine:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(18, 32);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(180, 20);
            this.textBoxName.TabIndex = 14;
            // 
            // checkBoxWeekend
            // 
            this.checkBoxWeekend.AutoSize = true;
            this.checkBoxWeekend.Location = new System.Drawing.Point(18, 102);
            this.checkBoxWeekend.Name = "checkBoxWeekend";
            this.checkBoxWeekend.Size = new System.Drawing.Size(73, 17);
            this.checkBoxWeekend.TabIndex = 19;
            this.checkBoxWeekend.Text = "Weekend";
            this.checkBoxWeekend.UseVisualStyleBackColor = true;
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
            // checkBoxWorkweek
            // 
            this.checkBoxWorkweek.AutoSize = true;
            this.checkBoxWorkweek.Location = new System.Drawing.Point(18, 79);
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
            // groupBoxPreview
            // 
            this.groupBoxPreview.Controls.Add(this.taskListViewRoutinePreview);
            this.groupBoxPreview.Location = new System.Drawing.Point(12, 147);
            this.groupBoxPreview.Name = "groupBoxPreview";
            this.groupBoxPreview.Size = new System.Drawing.Size(355, 303);
            this.groupBoxPreview.TabIndex = 14;
            this.groupBoxPreview.TabStop = false;
            this.groupBoxPreview.Text = "Preview";
            // 
            // taskListViewRoutinePreview
            // 
            this.taskListViewRoutinePreview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderWorkweekName,
            this.columnHeaderWorkweek,
            this.columnHeaderWeekend});
            this.taskListViewRoutinePreview.FullRowSelect = true;
            listViewGroup4.Header = "High Priority";
            listViewGroup4.Name = "listViewGroupHigh";
            listViewGroup5.Header = "Normal Priority";
            listViewGroup5.Name = "listViewGroupNormal";
            listViewGroup6.Header = "Low Priority";
            listViewGroup6.Name = "listViewGroupLow";
            this.taskListViewRoutinePreview.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup4,
            listViewGroup5,
            listViewGroup6});
            this.taskListViewRoutinePreview.HideSelection = false;
            this.taskListViewRoutinePreview.Location = new System.Drawing.Point(9, 19);
            this.taskListViewRoutinePreview.MultiSelect = false;
            this.taskListViewRoutinePreview.Name = "taskListViewRoutinePreview";
            this.taskListViewRoutinePreview.Size = new System.Drawing.Size(340, 273);
            this.taskListViewRoutinePreview.TabIndex = 5;
            this.taskListViewRoutinePreview.UseCompatibleStateImageBehavior = false;
            this.taskListViewRoutinePreview.View = System.Windows.Forms.View.Details;
            this.taskListViewRoutinePreview.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.taskListViewRoutinePreview_ItemSelectionChanged);
            // 
            // columnHeaderWorkweekName
            // 
            this.columnHeaderWorkweekName.Text = "Task";
            this.columnHeaderWorkweekName.Width = 196;
            // 
            // columnHeaderWorkweek
            // 
            this.columnHeaderWorkweek.Text = "Workweek";
            this.columnHeaderWorkweek.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderWorkweek.Width = 70;
            // 
            // columnHeaderWeekend
            // 
            this.columnHeaderWeekend.Text = "Weekend";
            this.columnHeaderWeekend.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderWeekend.Width = 70;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCancel.Location = new System.Drawing.Point(55, 456);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(153, 45);
            this.buttonCancel.TabIndex = 15;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonApplyChanges
            // 
            this.buttonApplyChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonApplyChanges.Location = new System.Drawing.Point(217, 102);
            this.buttonApplyChanges.Name = "buttonApplyChanges";
            this.buttonApplyChanges.Size = new System.Drawing.Size(121, 27);
            this.buttonApplyChanges.TabIndex = 22;
            this.buttonApplyChanges.Text = "Apply Changes";
            this.buttonApplyChanges.UseVisualStyleBackColor = true;
            this.buttonApplyChanges.Visible = false;
            this.buttonApplyChanges.Click += new System.EventHandler(this.buttonApplyChanges_Click);
            // 
            // RoutineSetupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 508);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSaveAndExit;
        private System.Windows.Forms.GroupBox groupBoxAddEdit;
        private System.Windows.Forms.Button buttonAddRoutineTask;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelRoutine;
        public System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.CheckBox checkBoxWeekend;
        private System.Windows.Forms.Label labelPriority;
        private System.Windows.Forms.CheckBox checkBoxWorkweek;
        public System.Windows.Forms.ComboBox comboBoxPriority;
        private System.Windows.Forms.GroupBox groupBoxPreview;
        private TaskListView.TaskListView taskListViewRoutinePreview;
        private System.Windows.Forms.ColumnHeader columnHeaderWorkweekName;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ColumnHeader columnHeaderWorkweek;
        private System.Windows.Forms.ColumnHeader columnHeaderWeekend;
        private System.Windows.Forms.Button buttonApplyChanges;

    }
}