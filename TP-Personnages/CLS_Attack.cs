using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TP_Personnages.CLS_Personnages;

namespace TP_Personnages
{
    internal class CLS_Attack 
    {
            public static Personnage SimulerCombat(Personnage personnage1, Personnage personnage2)
            {
                for (int i = 0; i < 5; i++)
                {
                    // Simuler une attaque de personnage1 sur personnage2
                    personnage2.PointsDeVie -= personnage1.Force;

                    // Simuler une attaque de personnage2 sur personnage1
                    personnage1.PointsDeVie -= personnage2.Force;

                    // Vérifier si l'un des personnages est à court de points de vie
                    if (personnage1.PointsDeVie <= 0)
                    {
                        return personnage2;
                    }
                    else if (personnage2.PointsDeVie <= 0)
                    {
                        return personnage1;
                    }
                }

                // Si aucun personnage n'est à court de points de vie après 5 rounds, on décide du gagnant en fonction des points de vie restants
                return personnage1.PointsDeVie > personnage2.PointsDeVie ? personnage1 : personnage2;
            }
        }      
    }

