using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models.Entities;
using WindowsFormsApp1.Repository;

namespace WindowsFormsApp1.Services
{
    class EliberareScrisoare
    {
        public static void eliberare_colet(string nume_destinatar)
        {
            foreach (Scrisoare scrisoare in StoreScrisori.listaScrisori)
            {
                if (scrisoare.Destinatar.CompareTo(nume_destinatar) == 0)
                {
                    StoreScrisori.listaScrisori.Remove(scrisoare);
                }
            }

        }
    }
}
