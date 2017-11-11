using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ModelGeneric
{
    class Utilizator
    {
        private string username;
        private int tip_utilizator; //0 - cumparator, 1 -  vanzator

        public Utilizator(string username)
        {
            this.username = username;
        }

        public string GetUserName()
        {
            return username;
        }
        public int GetTipUtilizator()
        {
            return tip_utilizator;
        }

    }
}
