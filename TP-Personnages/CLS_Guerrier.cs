using System;

namespace TP_Personnages
{
    public class Guerrier : Personnage
    {
        Random rnd;

        public Guerrier(string nom, Random rnd) : base(nom)
        {
            this.rnd = rnd;
            GenererStats();
        }

        public int Endurance { get; private set; }
        public int Force { get; private set; }
        public int Agilite { get; private set; }
        public int Intelligence { get; private set; }

        public void GenererStats()
        {
            Endurance = CLS_TiresDes.TiresDes(3, 10, rnd);
            Force = CLS_TiresDes.TiresDes(3, 10, rnd);
            Agilite = CLS_TiresDes.TiresDes(1, 10, rnd);
            Intelligence = CLS_TiresDes.TiresDes(1, 10, rnd);
        }
    }
}
