using EmployeeDashboardAPI.Interfaces;
using EmployeeDashboardAPI.Models;

namespace EmployeeDashboardAPI.Repository
{
    public class TaskRepository : ITaskRepository
    {
        private static List<TaskModel> tasks =
            new List<TaskModel>
        {
            new TaskModel
            {
                Id = 1,
                Title = "Create Login Page",
                Status = "Completed",
                Priority = "High"
            },

            new TaskModel
            {
                Id = 2,
                Title = "Sidebar Integration",
                Status = "In Progress",
                Priority = "Medium"
            }
        };

        public List<TaskModel> GetAllTasks()
        {
            return tasks;
        }

        public void AddTask(TaskModel task)
        {
            tasks.Add(task);
        }

        public void DeleteTask(int id)
        {
            var task =
                tasks.FirstOrDefault(t => t.Id == id);

            if (task != null)
            {
                tasks.Remove(task);
            }
        }

        public void UpdateTask(TaskModel updatedTask)
        {
            var existingTask =
                tasks.FirstOrDefault(
                    t => t.Id == updatedTask.Id
                );

            if (existingTask != null)
            {
                existingTask.Title =
                    updatedTask.Title;

                existingTask.Status =
                    updatedTask.Status;

                existingTask.Priority =
                    updatedTask.Priority;
            }
        }
    }
}