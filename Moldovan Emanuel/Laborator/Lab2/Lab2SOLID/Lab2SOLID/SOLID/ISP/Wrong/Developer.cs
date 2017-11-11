
using System;

namespace Examples.ISP
{
    public class Developer : IWork
    {
        public int AssignTask(string taskId, string developerName)
        {
            throw new NotImplementedException();
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
