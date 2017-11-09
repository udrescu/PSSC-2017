using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modele.Depozit;
using Repositories.Depozit;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //creare depozit
            var depozit = DepozitFactory.Instance.CreeazaDepozit("Depozitul111","12345555");
            var repository = new DepozitRepository();
            repository.AdaugaDepozit(depozit);


            Console.WriteLine("Press any key to terminate.");
            Console.ReadLine();
        }
    }
}
