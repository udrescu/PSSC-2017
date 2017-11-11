using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Modele.ModeleMarketPlace
{
    class Vanzatori
    {
        private List<Vanzator> vanzatori = new List<Vanzator>();


        public void AdaugaVanzator(Vanzator vanzator)
        {
            vanzatori.Add(vanzator);
        }

        public List<Vanzator> GetVanzatori
        {
            get { return vanzatori; }
        }
    }
}
