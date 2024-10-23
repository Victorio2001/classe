using System;

namespace CLASSE
{
    //public == visible pour tout le monde
    //Revoir ceci: pas compris => https://learn.microsoft.com/fr-fr/dotnet/csharp/fundamentals/tutorials/inheritance
    public class Pikachu : Pokemon
    {
        //! 2 constructeurs, choix selon params.
        public Pikachu() : base("PokemonDefault", 10 )
        {
            //? Attribut Classe Parent Pokemon En Dure.
        }
        public Pikachu(string name, int pv) : base(name, pv)
        {
            //? Attribut Classe Parent Pokemon Dynamique.
        }

        public void AttaqueFatalFoudre()
        {
            Console.WriteLine($"{namePokemon} utilise Fatal Foudre!");
        }
    }
}