using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modele.Generic.Exceptions;
using Modele.Generic;


namespace Modele.Depozit
{
    public class DepozitFactory
    {
        public static readonly DepozitFactory Instance = new DepozitFactory();

        private DepozitFactory()
        { }
        public Depozit CreeazaDepozit(string nume, string cui)
        {
            if (nume == null)
                throw new ArgumentNullException("nume");
            if (nume.Length < 2)
                throw new ArgumentInvalidLengthException("lungime nume prea mica");
            var depozit = new Depozit(new PlainText(nume), new CUI(cui));

            return depozit;
        }
    }
}
