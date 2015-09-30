namespace OCDrganizer
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("High Priority", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup6 = new System.Windows.Forms.ListViewGroup("Normal Priority", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup7 = new System.Windows.Forms.ListViewGroup("Low Priority", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup8 = new System.Windows.Forms.ListViewGroup("Finished Tasks", System.Windows.Forms.HorizontalAlignment.Left);
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportTaskListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importTaskListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.labelTime = new System.Windows.Forms.Label();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.toolStripLabelTask = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButtonNewTask = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEditTask = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRemoveTask = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonRoutine = new System.Windows.Forms.ToolStripButton();
            this.labelDate = new System.Windows.Forms.Label();
            this.panelTaskList = new System.Windows.Forms.Panel();
            this.taskList = new TaskListView.TaskListView();
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonDone = new System.Windows.Forms.Button();
            this.monthCalendarMain = new System.Windows.Forms.MonthCalendar();
            this.timerMain = new System.Windows.Forms.Timer(this.components);
            this.labelQuickDebug = new System.Windows.Forms.Label();
            this.menuStripMain.SuspendLayout();
            this.toolStripMain.SuspendLayout();
            this.panelTaskList.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(894, 24);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStripMain";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportTaskListToolStripMenuItem,
            this.importTaskListToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exportTaskListToolStripMenuItem
            // 
            this.exportTaskListToolStripMenuItem.Name = "exportTaskListToolStripMenuItem";
            this.exportTaskListToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.exportTaskListToolStripMenuItem.Text = "Export Task List...";
            // 
            // importTaskListToolStripMenuItem
            // 
            this.importTaskListToolStripMenuItem.Name = "importTaskListToolStripMenuItem";
            this.importTaskListToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.importTaskListToolStripMenuItem.Text = "Import Task List...";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(164, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // statusStripMain
            // 
            this.statusStripMain.Location = new System.Drawing.Point(0, 540);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(894, 22);
            this.statusStripMain.TabIndex = 2;
            this.statusStripMain.Text = "Ready";
            // 
            // labelTime
            // 
            this.labelTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTime.BackColor = System.Drawing.SystemColors.Window;
            this.labelTime.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTime.Location = new System.Drawing.Point(525, -1);
            this.labelTime.Margin = new System.Windows.Forms.Padding(0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(97, 37);
            this.labelTime.TabIndex = 3;
            this.labelTime.Text = "hh:mm";
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripMain
            // 
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelTask,
            this.toolStripButtonNewTask,
            this.toolStripButtonEditTask,
            this.toolStripButtonRemoveTask,
            this.toolStripSeparator2,
            this.toolStripButtonRoutine});
            this.toolStripMain.Location = new System.Drawing.Point(0, 24);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(894, 25);
            this.toolStripMain.TabIndex = 6;
            this.toolStripMain.Text = "toolStrip1";
            // 
            // toolStripLabelTask
            // 
            this.toolStripLabelTask.Name = "toolStripLabelTask";
            this.toolStripLabelTask.Size = new System.Drawing.Size(39, 22);
            this.toolStripLabelTask.Text = "Tasks:";
            // 
            // toolStripButtonNewTask
            // 
            this.toolStripButtonNewTask.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonNewTask.Image")));
            this.toolStripButtonNewTask.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNewTask.Name = "toolStripButtonNewTask";
            this.toolStripButtonNewTask.Size = new System.Drawing.Size(51, 22);
            this.toolStripButtonNewTask.Text = "New";
            this.toolStripButtonNewTask.Click += new System.EventHandler(this.toolStripButtonNewTask_Click);
            // 
            // toolStripButtonEditTask
            // 
            this.toolStripButtonEditTask.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEditTask.Image")));
            this.toolStripButtonEditTask.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEditTask.Name = "toolStripButtonEditTask";
            this.toolStripButtonEditTask.Size = new System.Drawing.Size(47, 22);
            this.toolStripButtonEditTask.Text = "Edit";
            this.toolStripButtonEditTask.ToolTipText = "Edit Task";
            this.toolStripButtonEditTask.Click += new System.EventHandler(this.toolStripButtonEditTask_Click);
            // 
            // toolStripButtonRemoveTask
            // 
            this.toolStripButtonRemoveTask.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRemoveTask.Image")));
            this.toolStripButtonRemoveTask.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRemoveTask.Name = "toolStripButtonRemoveTask";
            this.toolStripButtonRemoveTask.Size = new System.Drawing.Size(70, 22);
            this.toolStripButtonRemoveTask.Text = "Remove";
            this.toolStripButtonRemoveTask.ToolTipText = "Remove Task";
            this.toolStripButtonRemoveTask.Click += new System.EventHandler(this.toolStripButtonRemoveTask_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonRoutine
            // 
            this.toolStripButtonRoutine.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRoutine.Image")));
            this.toolStripButtonRoutine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRoutine.Name = "toolStripButtonRoutine";
            this.toolStripButtonRoutine.Size = new System.Drawing.Size(101, 22);
            this.toolStripButtonRoutine.Text = "Setup Routine";
            this.toolStripButtonRoutine.Click += new System.EventHandler(this.toolStripButtonRoutine_Click);
            // 
            // labelDate
            // 
            this.labelDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDate.BackColor = System.Drawing.SystemColors.Window;
            this.labelDate.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDate.Location = new System.Drawing.Point(0, 0);
            this.labelDate.Margin = new System.Windows.Forms.Padding(0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(632, 37);
            this.labelDate.TabIndex = 8;
            this.labelDate.Text = "dd mmmm yyyy";
            this.labelDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDate.UseMnemonic = false;
            // 
            // panelTaskList
            // 
            this.panelTaskList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTaskList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTaskList.Controls.Add(this.taskList);
            this.panelTaskList.Controls.Add(this.labelTime);
            this.panelTaskList.Controls.Add(this.labelDate);
            this.panelTaskList.Location = new System.Drawing.Point(12, 53);
            this.panelTaskList.Margin = new System.Windows.Forms.Padding(0);
            this.panelTaskList.Name = "panelTaskList";
            this.panelTaskList.Size = new System.Drawing.Size(634, 477);
            this.panelTaskList.TabIndex = 9;
            // 
            // taskList
            // 
            this.taskList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.taskList.BackColor = System.Drawing.SystemColors.Window;
            this.taskList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.taskList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName,
            this.columnHeaderStatus});
            listViewGroup5.Header = "High Priority";
            listViewGroup5.Name = "listViewGroupHighPrioriy";
            listViewGroup6.Header = "Normal Priority";
            listViewGroup6.Name = "listViewGroupNormalPriority";
            listViewGroup7.Header = "Low Priority";
            listViewGroup7.Name = "listViewGroupLowPriority";
            listViewGroup8.Header = "Finished Tasks";
            listViewGroup8.Name = "listViewGroupFinished";
            this.taskList.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup5,
            listViewGroup6,
            listViewGroup7,
            listViewGroup8});
            this.taskList.Location = new System.Drawing.Point(0, 38);
            this.taskList.Margin = new System.Windows.Forms.Padding(0);
            this.taskList.Name = "taskList";
            this.taskList.Size = new System.Drawing.Size(634, 438);
            this.taskList.TabIndex = 9;
            this.taskList.UseCompatibleStateImageBehavior = false;
            this.taskList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Task";
            this.columnHeaderName.Width = 219;
            // 
            // columnHeaderStatus
            // 
            this.columnHeaderStatus.Text = "Status";
            this.columnHeaderStatus.Width = 105;
            // 
            // buttonDone
            // 
            this.buttonDone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDone.Location = new System.Drawing.Point(649, 466);
            this.buttonDone.Margin = new System.Windows.Forms.Padding(0);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(227, 65);
            this.buttonDone.TabIndex = 7;
            this.buttonDone.Text = "Task Done!";
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // monthCalendarMain
            // 
            this.monthCalendarMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.monthCalendarMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.monthCalendarMain.Location = new System.Drawing.Point(649, 52);
            this.monthCalendarMain.Margin = new System.Windows.Forms.Padding(0);
            this.monthCalendarMain.MaxSelectionCount = 1;
            this.monthCalendarMain.Name = "monthCalendarMain";
            this.monthCalendarMain.TabIndex = 4;
            this.monthCalendarMain.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendarMain_DateSelected);
            // 
            // timerMain
            // 
            this.timerMain.Enabled = true;
            this.timerMain.Interval = 1000;
            this.timerMain.Tick += new System.EventHandler(this.timerMain_Tick);
            // 
            // labelQuickDebug
            // 
            this.labelQuickDebug.AutoSize = true;
            this.labelQuickDebug.Location = new System.Drawing.Point(690, 256);
            this.labelQuickDebug.Name = "labelQuickDebug";
            this.labelQuickDebug.Size = new System.Drawing.Size(99, 13);
            this.labelQuickDebug.TabIndex = 10;
            this.labelQuickDebug.Text = "Quick Debug Label";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 562);
            this.Controls.Add(this.labelQuickDebug);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.monthCalendarMain);
            this.Controls.Add(this.panelTaskList);
            this.Controls.Add(this.toolStripMain);
            this.Controls.Add(this.statusStripMain);
            this.Controls.Add(this.menuStripMain);
            this.MainMenuStrip = this.menuStripMain;
            this.MinimumSize = new System.Drawing.Size(16, 375);
            this.Name = "MainForm";
            this.Text = "O(CD)rganizer";
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.panelTaskList.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripButton toolStripButtonNewTask;
        private System.Windows.Forms.ToolStripButton toolStripButtonEditTask;
        private System.Windows.Forms.ToolStripButton toolStripButtonRemoveTask;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Panel panelTaskList;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.MonthCalendar monthCalendarMain;
        private System.Windows.Forms.ToolStripMenuItem exportTaskListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importTaskListToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private TaskListView.TaskListView taskList;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.Timer timerMain;
        private System.Windows.Forms.Label labelQuickDebug;
        private System.Windows.Forms.ColumnHeader columnHeaderStatus;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonRoutine;
        private System.Windows.Forms.ToolStripLabel toolStripLabelTask;
    }
}

