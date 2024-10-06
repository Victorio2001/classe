using CLASSE;
//MaClasse mc = new MaClasse();
Pokemon Pok = new();
Calculatrice Calc = new();

//Ici j'ai appris à call mes class et leurs configurations
System.Console.WriteLine($"{Calc.Addition(1,5)}"); 
System.Console.WriteLine($"{Calc.Multiplication(10,2)}"); 

//création PokemonObjet
Pokemon PokemonPikachu = new Pokemon {name = "pikachu", pv = 87};
PokemonPikachu.DataPokemon();
