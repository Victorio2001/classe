using System;

namespace CLASSE
{
    //public == visible pour tout le monde
    public class Pokemon
    {
        public string nom_pokemon {get; set;} = "default"; //? Accesseurs + Default Value
        public int pv_pokemon {get; set;} = 10;
        public List<string> attaque_pokemon {get; set;} = new List<string>(); //? Accesseurs + Default Value
        public bool capturer_pokemon {get;} // ! prop en lecture seule définisable uniquement à la construction
        public int age_pokemon {get; private set;}  // ! prop définisable à tout moment de la viue de la classe
        

        public Pokemon(string nom, int pv, List<string> attaques)
        {
            age_pokemon = 10;
            capturer_pokemon = false;
            nom_pokemon = nom;
            pv_pokemon = pv;
            attaque_pokemon = attaques;
        }

        public void DataPokemon()
        {
            Console.WriteLine($"Nom: {nom_pokemon}, Pv: {pv_pokemon}, Age: {age_pokemon = 30}, Capturée: {capturer_pokemon}");
        }
        public void Attack()
        {
            Console.WriteLine($"{nom_pokemon} attaque!");
        }

        public void Cri(Pokemon pokemon)
        {
            if(pokemon is Pikachu p){//! Vérifie si le Pokemon est Pikachu et si oui applique ces méthodes dans la variable.
                System.Console.WriteLine($"Cri de Pikachu => {p.nom_pokemon}");
            }
        }

    }
}