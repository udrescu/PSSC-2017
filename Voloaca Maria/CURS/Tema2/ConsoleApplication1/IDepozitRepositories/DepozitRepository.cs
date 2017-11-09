using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modele.Depozit;

namespace Repositories.Depozit
{
    public class DepozitRepository : Repositories.Depozit.IRepositoryDepozit
    {
        private static List<Modele.Depozit.Depozit> _depozite = new List<Modele.Depozit.Depozit>();

        public void ActualizareDepozit(Modele.Depozit.Depozit depozit)
        {
            throw new NotImplementedException();
        }

        public void AdaugaDepozit(Modele.Depozit.Depozit depozit)
        {
            var result = _depozite.FirstOrDefault(d => d.Equals(depozit));
            if (result != null) throw new DuplicateWaitObjectException();

            _depozite.Add(depozit);
            Console.WriteLine("Un nou depozit a fost adaugata.");
        }

        public Modele.Depozit.Depozit GasesteDepozit(string nume)
        {
            throw new NotImplementedException();
        }
    }
}
