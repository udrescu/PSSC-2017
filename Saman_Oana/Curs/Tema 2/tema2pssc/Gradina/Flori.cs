using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Gradina
{
    public class Flori
    {
        private List<Floare> flori;
        public ReadOnlyCollection<Floare> Valori { get { return flori.AsReadOnly(); } }

        internal Flori()
        {
            flori = new List<Floare>();
        }

        internal Flori(List<Floare> flori)
        {
            Contract.Requires(flori != null, "lista florilor");
            this.flori = flori;
        }

        internal void AdaugaFloare(Floare floare)
        {
            Contract.Requires(floare != null, "floare");
            flori.Add(floare);
        }  
    }
}
