using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Modele.ModeleMarketPlace
{
    class FactoryMarketPlace
    {
        public MarketPlace NewMarketPlace (string nume, List<Vanzator> vanzatori, List<Cumparator> cumparatori)
        { 
            MarketPlace marketPlace = new MarketPlace(nume, vanzatori, cumparatori);
            return marketPlace;
        }
    }
}
