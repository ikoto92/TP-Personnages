using System;
using static TP_Personnages.CLS_Enemies;
using static TP_Personnages.CLS_Mages;
using static TP_Personnages.CLS_Personnages;
using static TP_Personnages.CLS_Ranger;

namespace TP_Personnages
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random(); // Déclaration de la variable rnd ici

            Console.WriteLine("Entrez le nom de votre personnage:");
            string nom = Console.ReadLine();

            Console.WriteLine("Choisissez un personnage:");
            Console.WriteLine("1. Guerrier");
            Console.WriteLine("2. Mage");
            Console.WriteLine("3. Ranger");
            int choix = int.Parse(Console.ReadLine());

            Personnage joueur;

            switch (choix)
            {
                case 1:
                    joueur = new Guerrier(nom, rnd);
                    break;
                case 2:
                    joueur = new Mage(nom, rnd);
                    break;
                case 3:
                    joueur = new Ranger(nom, rnd);
                    break;
                default:
                    Console.WriteLine("Choix invalide. Par défaut, vous êtes un Guerrier.");
                    joueur = new Guerrier(nom, rnd);
                    break;
            }
            bool continuer = true;

            while (continuer)
            {
                // Générer un adversaire aléatoire
                Personnage adversaire;
                switch (rnd.Next(1, 4))
                {
                    case 1:
                        adversaire = new Guerrier();
                        break;
                    case 2:
                        adversaire = new Mage();
                        break;
                    case 3:
                        adversaire = new Ranger();
                        break;
                    default:
                        adversaire = new Guerrier();
                        break;
                }

                // Lancer le combat
                Personnage gagnant = CLS_Attack.SimulerCombat(joueur, adversaire);

                Console.WriteLine($"Le gagnant est: {(gagnant == joueur ? "Vous" : "L'adversaire")}");

                Console.WriteLine("Voulez-vous continuer? (o/n)");
                continuer = Console.ReadLine().ToLower() == "o";
            }
        }
    }
}
