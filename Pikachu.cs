using System;

namespace CLASSE
{
    //public == visible pour tout le monde
    public class Pikachu : Pokemon
    {
        //Revoir ceci: pas compris => https://learn.microsoft.com/fr-fr/dotnet/csharp/fundamentals/tutorials/inheritance
        public Pikachu(string name, int pv) : base(name, pv)
        {
        }
    
        // public Pikachu() :base(34)
        // {
        // }
        public void AttaqueFatalFoudre()
        {
            Console.WriteLine($"{namePokemon} utilise Fatal Foudre!");
        }
    }
}