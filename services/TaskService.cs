using taskManager_netcore.endpoints;
using taskManager_netcore.interfaces;
using taskManager_netcore.models;
using taskManager_netcore.models.enums;

namespace taskManager_netcore.services
{
    public class TaskService(TaskEndpoint endpoint) : ITask
    {
        public async Task<bool> CompleteTask(TaskModel task)
        {
            return await endpoint.CompleteTask(task.Id);
        }

        public async Task<bool> CreateTask(TaskModel task)
        {
            return await endpoint.CreateTask(task);
            
        }

        public async Task<bool> DeleteTask(TaskModel task)
        {
            return await endpoint.DeleteTask(task.Id);
        }

        public async Task<IReadOnlyCollection<TaskModel>> GetTasks()
        {
            return await endpoint.GetTasks();

        }

        public async Task<IReadOnlyCollection<TaskModel>> GetTasksByStatus(Enums.TaskStatus status)
        {
            return await endpoint.GetTasks((int)status);
        }

        public async Task<bool> UpdateTask(TaskModel task)
        {
            return await endpoint.UpdateTask(task.Id, task.Description);
        }

        private TaskModel MapTaskModel(TaskModel from, TaskModel to) 
        {
            to.Description = from.Description;
            to.Status = from.Status;
            to.UpdateDate = DateTime.Now;
            return to;
        }
    }
}
