using System;

namespace CLASSE
{
    //public == visible pour tout le monde
    public class Pokemon
    {
        public string? name {get; set;} = "default"; // accesseurs en lecture et écriture + default
        public int? pv {get; set;} = 10;

        public void DataPokemon()
        {
            Console.WriteLine($"Nom: {name}, Pv: {pv}");
        }
        public void Ecrire(string a){
            //void == Méthode qui ne retourne rien
            System.Console.WriteLine($"retour de la fonction ecrire: {a}");
        }
        public string Lire(){
            System.Console.WriteLine($"Veuillez saisir une valeur: ");
            string saisie = Console.ReadLine();
            return saisie;
        }

    }
}