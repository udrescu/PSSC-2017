
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Modele.Excursie
{
    public class Excursie
    {
        private string numeExcursie;
        public Cazare numeCazare { get; internal set; }
        public TipPret tipPret { get; internal set; }
        private float pret;
        public Perioada perioada { get; internal set; }
        public Transport transport { get; internal set; }

        internal Excursie(string nume,  float p, Cazare cazare)
        {
            numeExcursie = nume;
            numeCazare = cazare;
            pret = p;
            
        }

        public void seteazaTipPretInEuro()
        {
            tipPret = TipPret.Euro;
        }
         public void seteazaTipPretInLei()
        {
            tipPret = TipPret.Lei;
        }





    }
}
