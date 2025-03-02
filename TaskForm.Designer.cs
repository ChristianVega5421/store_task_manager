namespace taskManager_netcore
{
    partial class TaskForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Tabs = new TabControl();
            CreateTask = new TabPage();
            ClearForm = new Button();
            CreateTaskButton = new Button();
            TaskDescription = new TextBox();
            label2 = new Label();
            TaskTitle = new TextBox();
            label1 = new Label();
            Tasks = new TabPage();
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            creationDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            updateDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            DeleteTask = new DataGridViewButtonColumn();
            CompleteTask = new DataGridViewButtonColumn();
            taskModelBindingSource = new BindingSource(components);
            TaskReport = new TabPage();
            splitContainer1 = new SplitContainer();
            StatusSelector = new ComboBox();
            label3 = new Label();
            dataGridView2 = new DataGridView();
            idDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            creationDateDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            updateDateDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            statusDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            taskModelBindingSource1 = new BindingSource(components);
            Tabs.SuspendLayout();
            CreateTask.SuspendLayout();
            Tasks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)taskModelBindingSource).BeginInit();
            TaskReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)taskModelBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // Tabs
            // 
            Tabs.Controls.Add(CreateTask);
            Tabs.Controls.Add(Tasks);
            Tabs.Controls.Add(TaskReport);
            Tabs.Dock = DockStyle.Fill;
            Tabs.Location = new Point(0, 0);
            Tabs.Name = "Tabs";
            Tabs.SelectedIndex = 0;
            Tabs.Size = new Size(1656, 924);
            Tabs.TabIndex = 0;
            Tabs.SelectedIndexChanged += SelectedTab;
            // 
            // CreateTask
            // 
            CreateTask.Controls.Add(ClearForm);
            CreateTask.Controls.Add(CreateTaskButton);
            CreateTask.Controls.Add(TaskDescription);
            CreateTask.Controls.Add(label2);
            CreateTask.Controls.Add(TaskTitle);
            CreateTask.Controls.Add(label1);
            CreateTask.Location = new Point(4, 34);
            CreateTask.Name = "CreateTask";
            CreateTask.Padding = new Padding(3);
            CreateTask.Size = new Size(1648, 886);
            CreateTask.TabIndex = 0;
            CreateTask.Text = "Create Task";
            CreateTask.UseVisualStyleBackColor = true;
            // 
            // ClearForm
            // 
            ClearForm.Font = new Font("Segoe UI", 12F);
            ClearForm.Location = new Point(1398, 796);
            ClearForm.Name = "ClearForm";
            ClearForm.Size = new Size(206, 43);
            ClearForm.TabIndex = 5;
            ClearForm.Text = "Clear Form";
            ClearForm.UseVisualStyleBackColor = true;
            // 
            // CreateTaskButton
            // 
            CreateTaskButton.Font = new Font("Segoe UI", 12F);
            CreateTaskButton.Location = new Point(1166, 796);
            CreateTaskButton.Name = "CreateTaskButton";
            CreateTaskButton.Size = new Size(206, 43);
            CreateTaskButton.TabIndex = 4;
            CreateTaskButton.Text = "Create Task";
            CreateTaskButton.UseVisualStyleBackColor = true;
            CreateTaskButton.Click += CreateTaskBtnClick;
            // 
            // TaskDescription
            // 
            TaskDescription.AcceptsReturn = true;
            TaskDescription.AcceptsTab = true;
            TaskDescription.Location = new Point(69, 184);
            TaskDescription.Multiline = true;
            TaskDescription.Name = "TaskDescription";
            TaskDescription.Size = new Size(1535, 584);
            TaskDescription.TabIndex = 3;
            TaskDescription.TextChanged += TaskDescription_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(69, 129);
            label2.Name = "label2";
            label2.Size = new Size(169, 41);
            label2.TabIndex = 2;
            label2.Text = "Description";
            // 
            // TaskTitle
            // 
            TaskTitle.Font = new Font("Segoe UI", 15F);
            TaskTitle.Location = new Point(213, 53);
            TaskTitle.Name = "TaskTitle";
            TaskTitle.Size = new Size(1391, 47);
            TaskTitle.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(69, 56);
            label1.Name = "label1";
            label1.Size = new Size(138, 41);
            label1.TabIndex = 0;
            label1.Text = "Task Title";
            // 
            // Tasks
            // 
            Tasks.Controls.Add(dataGridView1);
            Tasks.Location = new Point(4, 34);
            Tasks.Name = "Tasks";
            Tasks.Padding = new Padding(3);
            Tasks.Size = new Size(1648, 886);
            Tasks.TabIndex = 1;
            Tasks.Text = "Tasks";
            Tasks.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, creationDateDataGridViewTextBoxColumn, updateDateDataGridViewTextBoxColumn, statusDataGridViewTextBoxColumn, DeleteTask, CompleteTask });
            dataGridView1.DataSource = taskModelBindingSource;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1642, 880);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += CellContentClickButtonAction;
            dataGridView1.CellDoubleClick += GetRowDetail;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 8;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Visible = false;
            idDataGridViewTextBoxColumn.Width = 150;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.MinimumWidth = 8;
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            descriptionDataGridViewTextBoxColumn.Visible = false;
            // 
            // creationDateDataGridViewTextBoxColumn
            // 
            creationDateDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            creationDateDataGridViewTextBoxColumn.DataPropertyName = "CreationDate";
            creationDateDataGridViewTextBoxColumn.HeaderText = "Creation Date";
            creationDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            creationDateDataGridViewTextBoxColumn.Name = "creationDateDataGridViewTextBoxColumn";
            creationDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // updateDateDataGridViewTextBoxColumn
            // 
            updateDateDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            updateDateDataGridViewTextBoxColumn.DataPropertyName = "UpdateDate";
            updateDateDataGridViewTextBoxColumn.HeaderText = "Updated On";
            updateDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            updateDateDataGridViewTextBoxColumn.Name = "updateDateDataGridViewTextBoxColumn";
            updateDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            statusDataGridViewTextBoxColumn.HeaderText = "Status";
            statusDataGridViewTextBoxColumn.MinimumWidth = 8;
            statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            statusDataGridViewTextBoxColumn.ReadOnly = true;
            statusDataGridViewTextBoxColumn.Visible = false;
            statusDataGridViewTextBoxColumn.Width = 150;
            // 
            // DeleteTask
            // 
            DeleteTask.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DeleteTask.HeaderText = "Delete Task";
            DeleteTask.MinimumWidth = 8;
            DeleteTask.Name = "DeleteTask";
            DeleteTask.ReadOnly = true;
            DeleteTask.Text = "Delete";
            DeleteTask.UseColumnTextForButtonValue = true;
            // 
            // CompleteTask
            // 
            CompleteTask.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CompleteTask.HeaderText = "Complete Task";
            CompleteTask.MinimumWidth = 8;
            CompleteTask.Name = "CompleteTask";
            CompleteTask.ReadOnly = true;
            CompleteTask.Text = "Complete";
            CompleteTask.UseColumnTextForButtonValue = true;
            // 
            // taskModelBindingSource
            // 
            taskModelBindingSource.DataSource = typeof(models.TaskModel);
            // 
            // TaskReport
            // 
            TaskReport.Controls.Add(splitContainer1);
            TaskReport.Location = new Point(4, 34);
            TaskReport.Name = "TaskReport";
            TaskReport.Padding = new Padding(3);
            TaskReport.Size = new Size(1648, 886);
            TaskReport.TabIndex = 2;
            TaskReport.Text = "Task Report";
            TaskReport.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(3, 3);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(StatusSelector);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1MinSize = 140;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dataGridView2);
            splitContainer1.Panel2MinSize = 600;
            splitContainer1.Size = new Size(1642, 880);
            splitContainer1.SplitterDistance = 140;
            splitContainer1.TabIndex = 1;
            // 
            // StatusSelector
            // 
            StatusSelector.DropDownStyle = ComboBoxStyle.DropDownList;
            StatusSelector.Font = new Font("Segoe UI", 12F);
            StatusSelector.FormattingEnabled = true;
            StatusSelector.Location = new Point(171, 49);
            StatusSelector.Name = "StatusSelector";
            StatusSelector.Size = new Size(182, 40);
            StatusSelector.TabIndex = 1;
            StatusSelector.SelectedIndexChanged += SelectedStatus;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(36, 52);
            label3.Name = "label3";
            label3.Size = new Size(129, 32);
            label3.TabIndex = 0;
            label3.Text = "Task Status";
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn1, nameDataGridViewTextBoxColumn1, descriptionDataGridViewTextBoxColumn1, creationDateDataGridViewTextBoxColumn1, updateDateDataGridViewTextBoxColumn1, statusDataGridViewTextBoxColumn1 });
            dataGridView2.DataSource = taskModelBindingSource1;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(0, 0);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(1642, 736);
            dataGridView2.TabIndex = 0;
            dataGridView2.CellDoubleClick += ShowReportForm;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn1.HeaderText = "Id";
            idDataGridViewTextBoxColumn1.MinimumWidth = 8;
            idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            idDataGridViewTextBoxColumn1.ReadOnly = true;
            idDataGridViewTextBoxColumn1.Visible = false;
            idDataGridViewTextBoxColumn1.Width = 150;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            nameDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            nameDataGridViewTextBoxColumn1.MinimumWidth = 8;
            nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            nameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn1
            // 
            descriptionDataGridViewTextBoxColumn1.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn1.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn1.MinimumWidth = 8;
            descriptionDataGridViewTextBoxColumn1.Name = "descriptionDataGridViewTextBoxColumn1";
            descriptionDataGridViewTextBoxColumn1.ReadOnly = true;
            descriptionDataGridViewTextBoxColumn1.Visible = false;
            descriptionDataGridViewTextBoxColumn1.Width = 150;
            // 
            // creationDateDataGridViewTextBoxColumn1
            // 
            creationDateDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            creationDateDataGridViewTextBoxColumn1.DataPropertyName = "CreationDate";
            creationDateDataGridViewTextBoxColumn1.HeaderText = "Creation Date";
            creationDateDataGridViewTextBoxColumn1.MinimumWidth = 8;
            creationDateDataGridViewTextBoxColumn1.Name = "creationDateDataGridViewTextBoxColumn1";
            creationDateDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // updateDateDataGridViewTextBoxColumn1
            // 
            updateDateDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            updateDateDataGridViewTextBoxColumn1.DataPropertyName = "UpdateDate";
            updateDateDataGridViewTextBoxColumn1.HeaderText = "Updated On";
            updateDateDataGridViewTextBoxColumn1.MinimumWidth = 8;
            updateDateDataGridViewTextBoxColumn1.Name = "updateDateDataGridViewTextBoxColumn1";
            updateDateDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn1
            // 
            statusDataGridViewTextBoxColumn1.DataPropertyName = "Status";
            statusDataGridViewTextBoxColumn1.HeaderText = "Status";
            statusDataGridViewTextBoxColumn1.MinimumWidth = 8;
            statusDataGridViewTextBoxColumn1.Name = "statusDataGridViewTextBoxColumn1";
            statusDataGridViewTextBoxColumn1.ReadOnly = true;
            statusDataGridViewTextBoxColumn1.Visible = false;
            statusDataGridViewTextBoxColumn1.Width = 150;
            // 
            // taskModelBindingSource1
            // 
            taskModelBindingSource1.DataSource = typeof(models.TaskModel);
            // 
            // TaskForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1656, 924);
            Controls.Add(Tabs);
            Name = "TaskForm";
            Text = "Form1";
            VisibleChanged += VisibilityChange;
            Tabs.ResumeLayout(false);
            CreateTask.ResumeLayout(false);
            CreateTask.PerformLayout();
            Tasks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)taskModelBindingSource).EndInit();
            TaskReport.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)taskModelBindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl Tabs;
        private TabPage CreateTask;
        private TabPage Tasks;
        private TabPage TaskReport;
        private Label label1;
        private TextBox TaskTitle;
        private Label label2;
        private Button ClearForm;
        private Button CreateTaskButton;
        private TextBox TaskDescription;
        private DataGridView dataGridView1;
        private BindingSource taskModelBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn creationDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn updateDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private DataGridViewButtonColumn DeleteTask;
        private DataGridViewButtonColumn CompleteTask;
        private DataGridView dataGridView2;
        private BindingSource taskModelBindingSource1;
        private SplitContainer splitContainer1;
        private ComboBox StatusSelector;
        private Label label3;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn creationDateDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn updateDateDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn1;
    }
}
