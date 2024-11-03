using System;
namespace CLASSE{
    public interface IForme {
    void superCool();
    //! pas super en therme de POO mais une implémantation des méthodes par défaut est possible.
    public void defaultImpl(){
        System.Console.WriteLine("haahahah");
    }
 }
}