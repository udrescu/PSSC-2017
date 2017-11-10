using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modele.Excursie;
using Repositories.Excursie;

namespace Tema2
{
    class Program
    {
        static void Main(string[] args)
        {
            var excursie = ExcursieFactory.Instance.creazaExcursie("Sicilia", 145, "ButterFly");
            var repo = new ExcursieRepository();
            excursie.seteazaTipPretInEuro();
            repo.adaugaExcursie(excursie);

            var excursie2 = ExcursieFactory.Instance.creazaExcursie("Oslo", 230, "Rooms");
            excursie.seteazaTipPretInEuro();
            repo.adaugaExcursie(excursie2);

            Console.WriteLine("Detalii excursie: ");
            repo.afiseazaDetaliiExcursie("Rooms");
            
            

            Console.ReadLine();
        }
    }
}
