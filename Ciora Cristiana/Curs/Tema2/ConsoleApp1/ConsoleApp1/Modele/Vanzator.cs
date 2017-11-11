using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.ModelGeneric;

namespace ConsoleApp1.Modele
{
    class Vanzator
    {

        private string nume;
        private Utilizator utilizator;
        public string produs;

        public Vanzator(string nume, Utilizator utilizator, string produs)
        {
            this.nume = nume;
            this.utilizator = utilizator;
            this.produs = produs;
        }

        public string Nume { get => nume; set => nume = value; }
        public Utilizator user { get => utilizator; set => utilizator = value; }

    }
}
