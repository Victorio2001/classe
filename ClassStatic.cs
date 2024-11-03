using System;
namespace CLASSE{
    public static class ClassStatic{
        //! regle ethique 
        //* jamais mettre de membre ou prop static en publique
        private static int number {get; set;} = 10;
        public static void retour(){
            System.Console.WriteLine($"retour de la méthode static hahaha {number}");
        }
    }
}