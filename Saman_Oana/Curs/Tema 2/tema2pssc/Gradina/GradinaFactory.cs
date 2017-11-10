using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Generic;
namespace Models.Gradina
{
    public class GradinaFactory
    {
        public static readonly GradinaFactory Instance = new GradinaFactory();

        private GradinaFactory()
        {

        }

        public Gradina CreeazaGradina(int nrLocatie)
        {
            Contract.Requires<ArgumentInvalidException>(
                    nrLocatie >= 1 && nrLocatie <= 50,
                    "Dati un numar intre 1 si 50");

            var gradina = new Gradina(nrLocatie);
            return gradina;
        }
    }
}
