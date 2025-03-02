using taskManager_netcore.interfaces;
using taskManager_netcore.models;
using taskManager_netcore.models.enums;

namespace taskManager_netcore
{
    public partial class TaskForm : Form
    {
        private readonly ITask taskService;
        private readonly BindingSource activeTasks = new BindingSource();
        private readonly BindingSource reportTasks = new BindingSource();
        private readonly BindingSource _statusSource = new BindingSource();
        public TaskForm()
        {
            InitializeComponent();
            taskService = (ITask)Program.ServiceProvider.GetService(typeof(ITask));
            taskModelBindingSource.DataSource = activeTasks;
            taskModelBindingSource1.DataSource = reportTasks;
            StatusSelector.DataSource = _statusSource;
            _statusSource.DataSource = Enum.GetValues(typeof(Enums.TaskStatus));
        }

        private async void CreateTaskBtnClick(object sender, EventArgs e)
        {
            if (ValidateRequiredFields())
            {
                if (await taskService.CreateTask(new TaskModel(TaskTitle.Text, TaskDescription.Text, DateTime.Now, null, 1)))
                {
                    Clear();
                    MessageBox.Show("Task created successfully!");
                }
            }
        }

        private void SelectedTab(object sender, EventArgs e)
        {
            if (Tabs.SelectedTab == Tasks)
            {
                UpdateTasksView();
            }
        }

        private bool ValidateRequiredFields()
        {
            if (string.IsNullOrEmpty(TaskTitle.Text))
            {
                MessageBox.Show("Task title is missing");
                return false;
            }
            if (string.IsNullOrEmpty(TaskDescription.Text))
            {
                MessageBox.Show("Description is missing");
                return false;
            }
            return true;
        }

        private void VisibilityChange(object sender, EventArgs e)
        {
            if (Visible && Tabs.SelectedTab == Tasks)
            {
                UpdateTasksView();
            }
        }

        private void GetRowDetail(object sender, DataGridViewCellEventArgs e)
        {
            Form taskDetail = new UpdateScreen(activeTasks.List.OfType<TaskModel>().ElementAt(e.RowIndex), this);
            Hide();
            taskDetail.Show();

        }

        private async void CellContentClickButtonAction(object sender, DataGridViewCellEventArgs e)
        {
            var grid = (DataGridView)sender;
            var column = grid.Columns[e.ColumnIndex];
            if (column is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                switch (column.Name)
                {
                    case "CompleteTask":
                        string message = "Are you sure you want to complete this task?";
                        string title = "Complete task";
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttons);
                        if (result == DialogResult.Yes)
                        {
                            var task = activeTasks.List.OfType<TaskModel>().ElementAt(e.RowIndex);
                            if (await taskService.CompleteTask(task))
                            {
                                MessageBox.Show("Task Completed successfully!");
                            }
                        }
                        break;
                    case "DeleteTask":
                        message = "Are you sure you want to delete this task?";
                        title = "Delete task";
                        buttons = MessageBoxButtons.YesNo;
                        result = MessageBox.Show(message, title, buttons);
                        if (result == DialogResult.Yes)
                        {
                            var task = activeTasks.List.OfType<TaskModel>().ElementAt(e.RowIndex);
                            if (await taskService.DeleteTask(task))
                            {
                                MessageBox.Show("Task Deleted successfully!");
                            }
                        }
                        break;
                    default:
                        MessageBox.Show("what are you doing! You are breaking things!");
                        break;
                }
                UpdateTasksView();
            }
        }

        private async void UpdateTasksView()
        {
            var loadingScreen = new SplashScreen();
            loadingScreen.Show();
            activeTasks.DataSource = await taskService.GetTasks();
            loadingScreen.Hide();
        }

        private void Clear(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            TaskDescription.Clear();
            TaskTitle.Clear();
        }

        private async void SelectedStatus(object sender, EventArgs e)
        {
            reportTasks.DataSource = await taskService.GetTasksByStatus((Enums.TaskStatus)StatusSelector.SelectedItem);
        }

        private void ShowReportForm(object sender, DataGridViewCellEventArgs e)
        {
            Form taskDetail = new ReportForm(reportTasks.List.OfType<TaskModel>().ElementAt(e.RowIndex));
            taskDetail.Show();
        }

        private void TaskDescription_TextChanged(object sender, EventArgs e)
        {
            var x = "asdasd";
        }
    }
}
