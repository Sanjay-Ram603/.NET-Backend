namespace EmployeeDashboardAPI.Models
{
    public class DashboardModel
    {
        public int TotalTasks { get; set; }

        public int CompletedTasks { get; set; }

        public int PendingTasks { get; set; }

        public int Progress { get; set; }

        public List<string> Activities { get; set; }

        public List<string> Announcements { get; set; }
    }
}