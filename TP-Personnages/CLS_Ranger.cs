using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TP_Personnages.CLS_Personnages;

namespace TP_Personnages
{
    internal class CLS_Ranger
    {
        public class Ranger : Personnage
        {
            public Ranger(string nom, Random rnd) : base(nom) { 
               
                GenererStats();

            }

            public Random rnd { get; private set; }
            public int Endurance { get; private set; }
            public int Agilite { get; private set; }
            public int Intelligence { get; private set; }

            public  void GenererStats()
            {

                Endurance = CLS_TiresDes.TiresDes(3, 10, rnd);
                Force = CLS_TiresDes.TiresDes(3, 10, rnd);
                Agilite = CLS_TiresDes.TiresDes(1, 10, rnd);
                Intelligence = CLS_TiresDes.TiresDes(1, 10, rnd);
            }
        }
    }
}
