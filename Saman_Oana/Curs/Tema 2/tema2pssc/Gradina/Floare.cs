using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

namespace Models.Gradina
{
    public class Floare
    {
        public string nume;
        public string culoare;
        public int numar;

        public string Nume { get; internal set; }
        public string Culoare { get; internal set; }
        public int Numar { get; internal set; }

        internal Floare(string nume, string culoare, int numar)
        {
            Contract.Requires(nume != null, "nume");
            Nume = nume;
            Culoare = culoare;
            Numar = numar;
        }

    }
}
