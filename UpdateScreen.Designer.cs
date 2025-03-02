namespace taskManager_netcore
{
    partial class UpdateScreen
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
            label1 = new Label();
            label2 = new Label();
            TaskTitle = new TextBox();
            TaskDescription = new TextBox();
            UpdateTask = new Button();
            CancelUpdateTask = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(49, 48);
            label1.Name = "label1";
            label1.Size = new Size(138, 41);
            label1.TabIndex = 0;
            label1.Text = "Task Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(49, 154);
            label2.Name = "label2";
            label2.Size = new Size(169, 41);
            label2.TabIndex = 1;
            label2.Text = "Description";
            // 
            // TaskTitle
            // 
            TaskTitle.Enabled = false;
            TaskTitle.Font = new Font("Segoe UI", 15F);
            TaskTitle.Location = new Point(213, 58);
            TaskTitle.Name = "TaskTitle";
            TaskTitle.Size = new Size(1285, 47);
            TaskTitle.TabIndex = 2;
            // 
            // TaskDescription
            // 
            TaskDescription.Location = new Point(60, 224);
            TaskDescription.Multiline = true;
            TaskDescription.Name = "TaskDescription";
            TaskDescription.Size = new Size(1438, 500);
            TaskDescription.TabIndex = 3;
            // 
            // UpdateTask
            // 
            UpdateTask.Font = new Font("Segoe UI", 12F);
            UpdateTask.Location = new Point(1135, 766);
            UpdateTask.Name = "UpdateTask";
            UpdateTask.Size = new Size(162, 59);
            UpdateTask.TabIndex = 4;
            UpdateTask.Text = "Update";
            UpdateTask.UseVisualStyleBackColor = true;
            UpdateTask.Click += Update;
            // 
            // CancelUpdateTask
            // 
            CancelUpdateTask.Font = new Font("Segoe UI", 12F);
            CancelUpdateTask.Location = new Point(1338, 766);
            CancelUpdateTask.Name = "CancelUpdateTask";
            CancelUpdateTask.Size = new Size(158, 59);
            CancelUpdateTask.TabIndex = 5;
            CancelUpdateTask.Text = "Cancel";
            CancelUpdateTask.UseVisualStyleBackColor = true;
            CancelUpdateTask.Click += CancelUpdate;
            // 
            // UpdateScreen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1619, 866);
            Controls.Add(CancelUpdateTask);
            Controls.Add(UpdateTask);
            Controls.Add(TaskDescription);
            Controls.Add(TaskTitle);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UpdateScreen";
            Text = "UpdateScreen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox TaskTitle;
        private TextBox TaskDescription;
        private Button UpdateTask;
        private Button CancelUpdateTask;
    }
}