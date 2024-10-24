using System;
namespace CLASSE{
        public class Raichu : Pikachu{
            public Raichu(
            string nom,
            int pv,
            List<string> attaques,
            int vitesse,
            int attaque,
            int defense,
            int attaque_spe,
            int defense_spe
            ) : base(nom, pv, attaques, vitesse, attaque, defense, attaque_spe, defense_spe)
            {
            }

        }
}