namespace taskManager_netcore
{
    partial class ReportForm
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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(78, 89);
            label1.Name = "label1";
            label1.Size = new Size(111, 32);
            label1.TabIndex = 0;
            label1.Text = "Task Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(78, 191);
            label2.Name = "label2";
            label2.Size = new Size(135, 32);
            label2.TabIndex = 1;
            label2.Text = "Description";
            // 
            // TaskTitle
            // 
            TaskTitle.Enabled = false;
            TaskTitle.Font = new Font("Segoe UI", 12F);
            TaskTitle.Location = new Point(210, 86);
            TaskTitle.Name = "TaskTitle";
            TaskTitle.Size = new Size(1226, 39);
            TaskTitle.TabIndex = 2;
            // 
            // TaskDescription
            // 
            TaskDescription.Enabled = false;
            TaskDescription.Font = new Font("Segoe UI", 12F);
            TaskDescription.Location = new Point(78, 245);
            TaskDescription.Multiline = true;
            TaskDescription.Name = "TaskDescription";
            TaskDescription.Size = new Size(1358, 500);
            TaskDescription.TabIndex = 3;
            // 
            // ReportForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1525, 797);
            Controls.Add(TaskDescription);
            Controls.Add(TaskTitle);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ReportForm";
            Text = "ReportForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox TaskTitle;
        private TextBox TaskDescription;
    }
}