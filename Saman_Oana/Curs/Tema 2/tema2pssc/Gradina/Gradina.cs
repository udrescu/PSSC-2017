using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Gradina
{
    public class Gradina
    {
        public bool casaEsteDraguta = false;
        public int nrLocatie;
        public int locuriGradina = 10;

        public Flori Flori { get; internal set; }
        public Legume Legume { get; internal set; }
        public Pomi Pomi { get; internal set; }

        internal Gradina(int nrLocatie)
        {
            this.nrLocatie = nrLocatie;
            Flori = new Flori();
            Legume = new Legume();
            Pomi = new Pomi();
        }

        public void AdaugaFloare(string nume, string culoare, int numar)
        {
            Contract.Requires(nume != null, "nume floare");
            var floare = Flori.Valori.FirstOrDefault(c => c.Nume.Equals(nume));
            if (locuriGradina > 0)
            {
                floare = new Floare(nume, culoare, numar);
                Flori.AdaugaFloare(floare);
                locuriGradina--;
            }
            else
            {
                Console.WriteLine("Nu mai sunt locuri in gradina");
            }
        }

        public void AdaugaLeguma(string nume, TipLeguma tip, int numar)
        {
            Contract.Requires(nume != null, "nume leguma");
            if (locuriGradina > 0)
            {
                var leguma = new Leguma(nume, tip, numar);
                Legume.AdaugaLeguma(leguma);
                locuriGradina--;
            }
            else
            {
                Console.WriteLine("Nu mai sunt locuri in gradina");
            }
        }

        public void AdaugaPom(string nume, int nota)
        {
            Contract.Requires(nume != null, "nume pom");
            if (locuriGradina > 0)
            {
                var pom = new Pom(nume, nota);
                Pomi.AdaugaPom(pom);
                locuriGradina--;
            }
            else
            {
                Console.WriteLine("Nu mai sunt locuri in gradina");
            }
        }

        public void DecoreazaCasaCuFlori(Floare floare, int numar)
        {
            floare.numar -= numar; //trebuie sa vad daca am destule flori
            casaEsteDraguta = true;
        }

        public void AruncaFlorileDinCasa()
        {
            casaEsteDraguta = false;
        }

        public void SalataDeNota10()
        {
            //primii 3 pomi cu nota maxima
        }

        public void LegumePentruCiorba()
        {
            //seleccteaza doar radacinoasele
        }

        #region override object
        public override string ToString()
        {
            return nrLocatie.ToString();
        }

        public override bool Equals(object obj)
        {
            var gradina = (Gradina)obj;

            if (gradina != null)
            {
                return nrLocatie.Equals(gradina.nrLocatie);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return nrLocatie.GetHashCode();
        }
        #endregion
    }
}
