
namespace Examples.ISP
{
    interface IWork
    {
        int WorkOnTask(string taskId);
        int AssignTask(string taskId, string developerName);
        int CloseTask(string taskId);
    }
}
