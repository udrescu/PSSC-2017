using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modele.Generic;

namespace Modele.Depozit
{
    public class Depozit
    {
        public PlainText NumeDepozit { get; internal set; }
        public CUI CuiDepozit { get; internal set; } 

        private List<Firma> _firmeBeneficare;
        public IReadOnlyCollection<Firma> FirmeBeneficiare { get { return _firmeBeneficare.AsReadOnly(); } }

        internal Depozit(PlainText nume,CUI cuiDepozit)
        {
            if (nume == null)
                throw new ArgumentNullException("nume");
            if (cuiDepozit == null)
                throw new ArgumentNullException("CUI Depozit");

            NumeDepozit = nume;
            CuiDepozit = cuiDepozit;
            _firmeBeneficare = new List<Firma>();

        }
    }
}
