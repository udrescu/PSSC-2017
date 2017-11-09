using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Jucatori
{
    public class JucatoriRepository
    {

        private static List<Modele.Jucatori.Jucatori> jucatori = new List<Modele.Jucatori.Jucatori>();
        public JucatoriRepository()
        {
        }

        public void AdaugaJucator(Modele.Jucatori.Jucatori jucator)
        {
            jucatori.Add(jucator);
        }
        public Modele.Jucatori.Jucatori GasesteJucator(string nume)
        {
            return jucatori.ElementAt(0);

        }
    }
}

