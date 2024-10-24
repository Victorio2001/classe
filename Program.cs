using CLASSE;
//MaClasse mc = new MaClasse();
//création PokemonObjet + Utilisation méthode de la classe
//Pokemon PokemonPikachu = new Pokemon {namePokemon = "pikachu", pvPokemon = 87};
//Méthode à utilisaer avec un connstructeur vide/default

Pikachu pikachu = new Pikachu(
nom:"Pikachu",
pv:120,
attaques: ["Vive attaque", "Fatal Foudre", "Cage éclair", "Eclair"],
vitesse: 150,
attaque: 120,
defense_spe: 55,
defense: 100,
attaque_spe: 95
);

pikachu.DataPokemon();
pikachu.Pikachu_Resume();
pikachu.Pikachu_Attack();
pikachu.Attack();


