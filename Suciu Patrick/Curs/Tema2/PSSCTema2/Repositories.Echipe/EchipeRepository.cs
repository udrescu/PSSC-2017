using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Echipe
{
  public class EchipeRepository
    {
        private static List<Modele.Echipe.Echipa> echipe = new List<Modele.Echipe.Echipa>();
        public EchipeRepository()
        {
        }
        public void AdaugaEchipa(Modele.Echipe.Echipa echipa)
        {
            echipe.Add(echipa);
        }
        public Modele.Echipe.Echipa GasesteEchipa(string nume)
        {

            int i;
            for(i=0;i<echipe.Count;i++)
            {
                if(nume.Equals(echipe.ElementAt(i).get_nume()))
            
                    return echipe.ElementAt(i);
            }
            return null;

        }
    }
}

