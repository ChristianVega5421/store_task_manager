using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using taskManager_netcore.interfaces;
using taskManager_netcore.models;

namespace taskManager_netcore
{
    public partial class UpdateScreen : Form
    {

        private Form _prevForm;
        private TaskModel currentTask;
        private readonly ITask taskService;
        public UpdateScreen()
        {
            InitializeComponent();
        }

        public UpdateScreen(TaskModel task, Form previousForm) : this()
        {

            taskService = (ITask)Program.ServiceProvider.GetService(typeof(ITask));
            currentTask = task;
            TaskDescription.Text = currentTask.Description;
            TaskTitle.Text = currentTask.Name;
            _prevForm = previousForm;
        }

        private async void Update(object sender, EventArgs e)
        {
            TaskModel updatedTask = currentTask.GetClone();
            updatedTask.Description = TaskDescription.Text;
            await taskService.UpdateTask(updatedTask);
            ShowTasksTabs();
        }
        private void CancelUpdate(object sender, EventArgs e)
        {
            ShowTasksTabs();
        }
        private void ShowTasksTabs()
        {
            Close();
            _prevForm.Show();
        }
    }
}
