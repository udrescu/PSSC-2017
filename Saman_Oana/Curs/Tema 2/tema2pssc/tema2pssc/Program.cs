using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Generic;
using Models.Gradina;
using Repositories.Gradina;
using Services.Gradina;
namespace tema2pssc
{
    class Program
    {
        static void Main(string[] args)
        {
            var gradina = GradinaFactory.Instance.CreeazaGradina(1);
            var gradina1 = GradinaFactory.Instance.CreeazaGradina(1);
            var gradina2 = GradinaFactory.Instance.CreeazaGradina(0);
            var repository = new GradinaRepository();
            repository.AdaugaGradina(gradina);
            repository.AdaugaGradina(gradina1);

            gradina.AdaugaFloare("Garoafa", "Galben", 12);
        }
    }
}
