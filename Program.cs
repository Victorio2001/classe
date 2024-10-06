using CLASSE;
//MaClasse mc = new MaClasse();
Calculatrice Calc = new();

//Ici j'ai appris à call mes class et leurs configurations
System.Console.WriteLine($"{Calc.Addition(1,5)}"); 
System.Console.WriteLine($"{Calc.Multiplication(10,2)}"); 

//création PokemonObjet + Utilisation méthode de la classe
//Pokemon PokemonPikachu = new Pokemon {namePokemon = "pikachu", pvPokemon = 87}; // méthode à utilisaer avec un connstructeur vide/default
Pokemon PokemonPikachu = new Pokemon("pikachu", 187);
PokemonPikachu.DataPokemon();

Pikachu pika = new("pikachuHeritage", 320);
pika.DataPokemon();
pika.attaqueFatalFoudre();
