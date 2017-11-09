using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modele.Generic;

namespace Modele.Depozit
{
    public class Firma
    {
        public PlainText NumeFirma { get; internal set; }
        public CUI CUIFirma { get; internal set; }
        public Adresa AdresaFirma { get; internal set; }

    }
}
