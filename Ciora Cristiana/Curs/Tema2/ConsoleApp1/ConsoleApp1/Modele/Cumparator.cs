using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.ModelGeneric;

namespace ConsoleApp1.Modele
{
    class Cumparator
    {

        private string nume;
        private Utilizator utilizator;

        public Cumparator(string nume, Utilizator utilizator)
        {
            this.nume = nume;
            this.utilizator = utilizator;
        }

        public string Nume { get => nume; set => nume = value; }
        public Utilizator user { get => utilizator; set => utilizator = value; }
    }
}
