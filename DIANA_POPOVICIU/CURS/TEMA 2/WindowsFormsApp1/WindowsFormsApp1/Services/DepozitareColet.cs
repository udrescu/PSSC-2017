using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models.Entities;
using WindowsFormsApp1.Repository;

namespace WindowsFormsApp1.Services
{
    class DepozitareColet
    {
        public static void eliberare_colet(string numar_colet)
        {
            foreach (Colet colet in StoreColete.listColete)
            {
                if (colet.Numar_inregistrare.CompareTo(numar_colet) == 0)
                {
                    colet.Depozitat = true;
                }
            }
        }
    }
}
