using EmployeeDashboardAPI.Interfaces;
using EmployeeDashboardAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeDashboardAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DashboardController : ControllerBase
    {
        private readonly ITaskService _taskService;

        public DashboardController(
            ITaskService taskService
        )
        {
            _taskService = taskService;
        }

        [HttpGet]
        public IActionResult GetDashboardData()
        {
            var tasks = _taskService.GetTasks();

            var totalTasks = tasks.Count;

            var completedTasks =
                tasks.Count(t =>
                    t.Status == "Completed");

            var pendingTasks =
                tasks.Count(t =>
                    t.Status == "Pending");

            var progress =
                totalTasks == 0
                ? 0
                : (completedTasks * 100)
                    / totalTasks;

            var dashboardData =
                new DashboardModel
                {
                    TotalTasks = totalTasks,

                    CompletedTasks = completedTasks,

                    PendingTasks = pendingTasks,

                    Progress = progress,

                    Activities = new List<string>
                    {
                        "Completed Login Module",
                        "Integrated Backend APIs",
                        "Implemented Dark Mode",
                        "Added CRUD Operations",
                        "Implemented Task Filtering"
                    },

                    Announcements = new List<string>
                    {
                        "Project review scheduled on Friday",
                        "React evaluation next week",
                        "Team meeting at 4 PM today",
                        "Backend integration successfully completed"
                    }
                };

            return Ok(dashboardData);
        }
    }
}