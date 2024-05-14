using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Personnages
{
    public abstract class CLS_Personnages
    {
        public abstract class Personnage
        {
            public int Endurance { get; set; }
            public int Force { get; set; }
            public int Agilite { get; set; }
            public int Intelligence { get; set; }
            public int PointsDeVie { get; set; }

            protected static Random rnd = new Random();

            public Personnage()
            {
                PointsDeVie = 100; // par exemple, chaque personnage commence avec 100 points de vie
            }

            protected int TiresDes(int min, int max)
            {
                return rnd.Next(min, max + 1);
            }
        }
    }
}

