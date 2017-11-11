
using System;

namespace Examples.ISP
{
    public class TeamLeader : IWork
    {
        public int AssignTask(string taskId, string developerName)
        {
            // assign the task with taskId for developer with name developerName

            return 1;
        }

        public int CloseTask(string taskId)
        {
            throw new NotImplementedException(); 
        }

        public int WorkOnTask(string taskId)
        {
            // implement a new functionality

            return 1;
        }
    }
}
