using EmployeeDashboardAPI.Interfaces;
using EmployeeDashboardAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeDashboardAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TasksController : ControllerBase
    {
        private readonly ITaskService _taskService;

        public TasksController(
            ITaskService taskService
        )
        {
            _taskService = taskService;
        }

        [HttpGet]
        public IActionResult GetTasks(string? status)
        {
            var tasks = _taskService.GetTasks();

            if (!string.IsNullOrEmpty(status))
            {
                tasks = tasks
                    .Where(t =>
                        t.Status.ToLower() ==
                        status.ToLower()
                    )
                    .ToList();
            }

            return Ok(tasks);
        }

        [HttpPost]
        public IActionResult AddTask(
            TaskModel task
        )
        {
            _taskService.AddTask(task);

            return Ok(task);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateTask(
            int id,
            TaskModel task
        )
        {
            task.Id = id;

            _taskService.UpdateTask(task);

            return Ok(task);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteTask(int id)
        {
            _taskService.DeleteTask(id);

            return Ok();
        }
    }
}