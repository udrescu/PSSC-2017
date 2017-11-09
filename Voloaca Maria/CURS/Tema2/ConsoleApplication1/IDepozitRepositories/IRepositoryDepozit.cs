using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Depozit
{
    interface IRepositoryDepozit
    {
        void ActualizareDepozit(Modele.Depozit.Depozit depozit);
        void AdaugaDepozit(Modele.Depozit.Depozit depozit);
        Modele.Depozit.Depozit GasesteDepozit(string nume);
    }
}
