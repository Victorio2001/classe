using System;
namespace CLASSE{
    public class Chien : IMamifere, IAnimal {
    public int prp_animal => 10;
    /**
    * ? OU 
    * ! public int prp_animal {get;} = 10;
    **/
    public void faire(){
        System.Console.WriteLine($"le chien fait via l'interface hahaahh");
    }
 }
}