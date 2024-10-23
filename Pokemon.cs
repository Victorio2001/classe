using System;

namespace CLASSE
{
    //public == visible pour tout le monde
    public class Pokemon
    {

        public string namePokemon {get; set;} = "default"; // accesseurs en lecture et écriture + default
        public int pvPokemon {get; set;} = 10;

        public Pokemon(string name, int pv)
        {
            namePokemon = name;
            pvPokemon = pv;
        }

        public void DataPokemon()
        {
            Console.WriteLine($"Nom: {namePokemon}, Pv: {pvPokemon}");
        }
        public void Attack()
        {
            Console.WriteLine($"{namePokemon} attaque!");
        }

    }
}