namespace HW8
{
    class Project : Employee
    {
    string projectDescription;
    DateTime projectDeadline = new DateTime();
    Customer projectCustomer;
    TeamLead teamLead = new TeamLead();
    List<Task> taskList = new List<Task>();
    ProjectStatus status = new ProjectStatus();
    public Project(DateTime projectDeadline,)
    public void CheckProjectStatus()
        {
            foreach (Task task in taskList)
            {
                if (task.statusTask != TaskStatus.Выполнена)
                {
                    status = ProjectStatus.Закрыт;
                }
            }
        status = ProjectStatus.Исполнение;
        }
    }
}