using EmployeeDashboardAPI.Models;

namespace EmployeeDashboardAPI.Interfaces
{
    public interface ITaskService
    {
        List<TaskModel> GetTasks();

        void AddTask(TaskModel task);

        void DeleteTask(int id);

        void UpdateTask(TaskModel task);
    }
}