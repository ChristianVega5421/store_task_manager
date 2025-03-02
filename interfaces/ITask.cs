using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using taskManager_netcore.models;
using taskManager_netcore.models.enums;

namespace taskManager_netcore.interfaces
{
    public interface ITask
    {
        Task<IReadOnlyCollection<TaskModel>> GetTasks();

        Task<IReadOnlyCollection<TaskModel>> GetTasksByStatus(Enums.TaskStatus status);

        Task<bool> CreateTask(TaskModel task);

        Task<bool> UpdateTask(TaskModel task);

        Task<bool> CompleteTask(TaskModel task);

        Task<bool> DeleteTask(TaskModel task);
    }
}
