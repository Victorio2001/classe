using System;

namespace CLASSE
{
    //public == visible pour tout le monde
    public class Pikachu : Pokemon
    {
        //Revoir ceci: pas compris
        public Pikachu(string name, int pv):base(name, pv){

        }

        public void attaqueFatalFoudre(){
            System.Console.WriteLine($"Pikachu attaque fatal Foudre");
        }
    }
}