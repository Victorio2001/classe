using System;
namespace CLASSE{
    public class Dresseur{

        public void Capturer(Pokemon pokemon){ //! void quand la fonction ne return pas de value.
            System.Console.WriteLine($"Bravo {pokemon.nom_pokemon} à été capturée !!");
        }

        public void Paralyser(Pikachu pikachu){ //! void quand la fonction ne return pas de value.
            System.Console.WriteLine($"{pikachu.nom_pokemon} attaque cage éclair!!");
        }
        
    }
}