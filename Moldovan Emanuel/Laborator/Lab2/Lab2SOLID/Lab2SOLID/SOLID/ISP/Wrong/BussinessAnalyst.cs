using System;

namespace Examples.ISP
{
    public class BussinessAnalyst : IWork
    {
        public int AssignTask(string taskId, string developerName)
        {
            // assign the task with taskId for developer with name developerName

            return 1;
        }

        public int CloseTask(string taskId)
        {
            // verify the status for the task with taskId
            // if done --> mark the task as closed

            return 1;
        }

        public int WorkOnTask(string taskId)
        {
            throw new NotImplementedException();
        }
    }
}
