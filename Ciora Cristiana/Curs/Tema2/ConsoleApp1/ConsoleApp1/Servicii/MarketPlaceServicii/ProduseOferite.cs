using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Modele;

namespace ConsoleApp1.Servicii.MarketPlaceServicii
{
    class ProduseOferite
    {
        public void AfisareProduse(List<Vanzator> vanzatori)
        {
            foreach (Vanzator v in vanzatori)
            {
                Console.WriteLine(v.produs);
            }
        }
    }
}
