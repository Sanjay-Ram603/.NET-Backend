using EmployeeDashboardAPI.Models;

namespace EmployeeDashboardAPI.Interfaces
{
    public interface ITaskRepository
    {
        List<TaskModel> GetAllTasks();

        void AddTask(TaskModel task);

        void DeleteTask(int id);

        void UpdateTask(TaskModel task);
    }
}