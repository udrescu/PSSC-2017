using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Modele.ModeleMarketPlace
{
    class Cumparatori
    {
        private List<Cumparator> cumparatori = new List<Cumparator>();


        public void AdaugaCumparator(Cumparator cumparator)
        {
            cumparatori.Add(cumparator);
        }

        public List<Cumparator> GetCumparatori
        {
            get { return cumparatori; }
        }
    }
}
