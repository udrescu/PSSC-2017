using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Gradina
{
    public class Legume
    {
        private List<Leguma> legume;
        public ReadOnlyCollection<Leguma> Valori { get { return legume.AsReadOnly(); } }

        internal Legume()
        {
            legume = new List<Leguma>();
        }

        internal Legume(List<Leguma> legume)
        {
            Contract.Requires(legume != null, "lista legumelor");
            this.legume = legume;
        }

        internal void AdaugaLeguma(Leguma leguma)
        {
            Contract.Requires(leguma != null, "leguma");
            legume.Add(leguma);
        }
    }
}
