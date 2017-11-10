using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Gradina;
namespace Repositories.Gradina
{
    public class GradinaRepository
    {
        private static List<Models.Gradina.Gradina> gradini = new List<Models.Gradina.Gradina>();

        public GradinaRepository()
        {
        }
        public void AdaugaGradina(Models.Gradina.Gradina gradina)
        {
            var result = gradini.FirstOrDefault(d => d.Equals(gradina));

            if (result != null) throw new LocationAlreadyTakenException("Gradina exista deja la locatia" + gradina.nrLocatie);

            gradini.Add(gradina);
            Console.WriteLine("O noua gradina a fost plantata la locatia " + gradina.nrLocatie);
        }

        public void StergeGradina(Models.Gradina.Gradina gradina)
        {
            Console.WriteLine("Gradina a fost deplantata.");
        }

        public void CautaGradina(int nrLocatie)
        {
            if( gradini.FirstOrDefault(d => d.nrLocatie == nrLocatie) != null)
                Console.WriteLine("Exista o gradina la locatia " + nrLocatie);
            else
                Console.WriteLine("Nu am gasit gradina la locatia " + nrLocatie);
        }
    }
}
