using CLASSE;
//MaClasse mc = new MaClasse();
//création PokemonObjet + Utilisation méthode de la classe
//Pokemon PokemonPikachu = new Pokemon {namePokemon = "pikachu", pvPokemon = 87};
//Méthode à utilisaer avec un connstructeur vide/default

Pikachu pikachu = new Pikachu(
nom:"NewPikachu",
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




//! Exemple d'utilisation du Polymorphisme
//? Création de l'objet Pokemon 
Pokemon pokemon = new Pokemon(
nom:"Pokemon",
pv:120,
attaques: ["default", "default", "default", "default"]
);
//? Création de l'objet Raichu [Raichu->Pikachu->Pokemon]#héritage
Raichu raichu = new Raichu(
nom:"Raichu",
pv:120,
attaques: ["Vive attaque", "Fatal Foudre", "Cage éclair", "Eclair"],
vitesse: 150,
attaque: 120,
defense_spe: 55,
defense: 100,
attaque_spe: 95
);
raichu.DataPokemon();

//? Exemple
var dresseur = new Dresseur();

dresseur.Capturer(pokemon);
dresseur.Capturer(pikachu);
dresseur.Capturer(raichu); //! Capturer attend un Pikachu, mais on lui passe un Raichu et cela marche car Raichu hérite de Pikachu.

dresseur.Paralyser(pikachu);
dresseur.Paralyser(raichu); //! Paralyser attend un Pikachu, mais on lui passe un Raichu et cela marche car Raichu hérite de Pikachu.
// dresseur.Paralyser(pokemon); //! ne marche pas car pokemon est au dessus de Pikachu en héritage.



