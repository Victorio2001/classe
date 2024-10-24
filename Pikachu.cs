using System;

namespace CLASSE
{
    //public == visible pour tout le monde
    //Revoir ceci: pas compris => https://learn.microsoft.com/fr-fr/dotnet/csharp/fundamentals/tutorials/inheritance
    public class Pikachu : Pokemon
    {
        public int vitesse_pikachu { get; set; }
        public int attaque_pikachu { get; set; }
        public int defense_pikachu { get; set; }
        public int attaque_spe_pikachu { get; set; }
        public int defense_spe_pikachu { get; set; }

        //! 2 constructeurs, choix selon params.
        public Pikachu(
        int vitesse = 0,
        int attaque = 0,
        int defense = 0,
        int attaque_spe = 0,
        int defense_spe = 0
        ) : base("PokemonNameDefault", 10, ["defaultAttack1", "defaultAttack2"]) //! "base" pour Classe Parent
        {
            //? Attribut Classe Parent Pokemon En Dure.
            vitesse_pikachu = vitesse;
            attaque_pikachu = attaque;
            defense_pikachu = defense;
            attaque_spe_pikachu = attaque_spe;
            defense_spe_pikachu = defense_spe;
        }

        public Pikachu(
        string nom,
        int pv,
        List<string> attaques,
        int vitesse,
        int attaque,
        int defense,
        int attaque_spe,
        int defense_spe
        ) : base(nom, pv, attaques) //! "base" pour Classe Parent
        {
            //? Attribut Classe Parent Pokemon Dynamique.
            vitesse_pikachu = vitesse;
            attaque_pikachu = attaque;
            defense_pikachu = defense;
            attaque_spe_pikachu = attaque_spe;
            defense_spe_pikachu = defense_spe;
        }

        public void Pikachu_Attack()
        {
            Console.WriteLine($"{nom_pokemon} connaît les attaques suivantes:");
            foreach (var attaque in attaque_pokemon)
            {
                Console.WriteLine($"- {attaque}");
            }
        }

        public void Pikachu_Resume()
        {
            Console.WriteLine($"{nom_pokemon} à pour statistiques: Vitesse => {vitesse_pikachu}, Attaque => {attaque_pikachu}, Defense => {defense_pikachu}, Attaque_Spe => {attaque_spe_pikachu}, Defense_Spe => {defense_spe_pikachu}");
        }
    }
}