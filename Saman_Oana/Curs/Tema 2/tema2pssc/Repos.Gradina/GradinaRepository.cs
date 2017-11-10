using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repos.Gradina
{
   
    public class GradinaRepositorys
    {
        private static List<Models.Gradina.Gradina> gradina = new List<Models.Gradina.Gradina>();

        public GradinaRepository()
        {
        }
        public void AdaugaDisciplina(Modele.Disciplina.Disciplina disciplina)
        {
            var result = _discipline.FirstOrDefault(d => d.Equals(disciplina));

            if (result != null) throw new DuplicateWaitObjectException();

            _discipline.Add(disciplina);
            Console.WriteLine("O noua disciplina a fostr adaugata.");
        }

        public void ActualizeazaDisciplina(Modele.Disciplina.Disciplina disciplina)
        {
            //persit changes to the database
            Console.WriteLine("Modificarile au fost salvate.");
        }

        public Modele.Disciplina.Disciplina GasesteDiscipilnaDupaNume(string nume)
        {
            return _discipline.FirstOrDefault(d => d.Nume.Text == nume);
        }  
    }
}
