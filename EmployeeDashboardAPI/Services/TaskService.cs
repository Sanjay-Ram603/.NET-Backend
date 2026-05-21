using EmployeeDashboardAPI.Interfaces;
using EmployeeDashboardAPI.Models;

namespace EmployeeDashboardAPI.Services
{
    public class TaskService : ITaskService
    {
        private readonly ITaskRepository _taskRepository;

        public TaskService(
            ITaskRepository taskRepository
        )
        {
            _taskRepository = taskRepository;
        }

        public List<TaskModel> GetTasks()
        {
            return _taskRepository.GetAllTasks();
        }

        public void AddTask(TaskModel task)
        {
            _taskRepository.AddTask(task);
        }

        public void DeleteTask(int id)
        {
            _taskRepository.DeleteTask(id);
        }

        public void UpdateTask(TaskModel task)
        {
            _taskRepository.UpdateTask(task);
        }
    }
}