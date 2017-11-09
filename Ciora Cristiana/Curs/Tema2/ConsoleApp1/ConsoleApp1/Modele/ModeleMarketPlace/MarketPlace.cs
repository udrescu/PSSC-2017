using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.ModelGeneric;

namespace ConsoleApp1.Modele.ModeleMarketPlace
{
    class MarketPlace
    {

        private string nume;
        private List<Vanzator> vanzatori { get; set; }
        private List<Cumparator> cumparatori { get; set; }



        public MarketPlace(string nume, List<Vanzator> vanzatori, List<Cumparator> cumparatori)
        {
            this.nume = nume;
            this.vanzatori = vanzatori;
            this.cumparatori = cumparatori;
        }

        public MarketPlace()
        {
        }

        void AdaugaCumparator(Cumparator cumparator, Cumparatori cumparatori)
        {
            cumparatori.AdaugaCumparator(cumparator);
        }

        void AdaugaVanzator(Vanzator vanzator, Vanzatori vanzatori)
        {
            vanzatori.AdaugaVanzator(vanzator);
        }

        public List<Cumparator> GetCumparatori
        {
            get { return cumparatori; }
        }

        public List<Vanzator> GetVanzatori
        {
            get { return vanzatori; }
        }
    }
}
