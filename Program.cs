using CLASSE;
//MaClasse mc = new MaClasse();
//création PokemonObjet + Utilisation méthode de la classe
//Pokemon PokemonPikachu = new Pokemon {namePokemon = "pikachu", pvPokemon = 87};
//Méthode à utilisaer avec un connstructeur vide/default

Pokemon pikachu = new Pikachu(
nom:"NewPikachu",
pv:120,
attaques: ["Vive attaque", "Fatal Foudre", "Cage éclair", "Eclair"],
vitesse: 150,
attaque: 120,
defense_spe: 55,
defense: 100,
attaque_spe: 95
);

if(pikachu is Pikachu p){
p.DataPokemon();
p.Pikachu_Resume();
p.Pikachu_Attack();
p.Attack();
}



/***
 *      _____            _                                              _       _                          
 *     |  __ \          | |                                            | |     (_)                         
 *     | |__) |   ___   | |  _   _   _ __ ___     ___    _ __   _ __   | |__    _   ___   _ __ ___     ___ 
 *     |  ___/   / _ \  | | | | | | | '_ ` _ \   / _ \  | '__| | '_ \  | '_ \  | | / __| | '_ ` _ \   / _ \
 *     | |      | (_) | | | | |_| | | | | | | | | (_) | | |    | |_) | | | | | | | \__ \ | | | | | | |  __/
 *     |_|       \___/  |_|  \__, | |_| |_| |_|  \___/  |_|    | .__/  |_| |_| |_| |___/ |_| |_| |_|  \___|
 *                            __/ |                            | |                                         
 *                           |___/                             |_|                                         
 */
//! Exemple d'utilisation du Polymorphisme
//* Création de l'objet Pokemon 
Pokemon pokemon = new Pokemon(
nom:"Pokemon",
pv:120,
attaques: ["default", "default", "default", "default"]
);

//* Création de l'objet Raichu [Raichu->Pikachu->Pokemon]#héritage
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

var dresseur = new Dresseur();
dresseur.Capturer(pokemon);
dresseur.Capturer(pikachu);
dresseur.Capturer(raichu); //! Capturer attend un Pikachu, mais on lui passe un Raichu et cela marche car Raichu hérite de Pikachu.

dresseur.Paralyser(raichu); //! Paralyser attend un Pikachu, mais on lui passe un Raichu et cela marche car Raichu hérite de Pikachu.
// dresseur.Paralyser(pokemon); //! ne marche pas car pokemon est au dessus de Pikachu en héritage.

/***
 *      ______                  _   _                  _     _                     _____            _     _                             __  __           _            _       _                 
 *     |  ____|                | | (_)                | |   (_)                   |  __ \          | |   | |                           |  \/  |         | |          | |     (_)                
 *     | |__    __  __  _ __   | |  _    ___    __ _  | |_   _    ___    _ __     | |__) |   __ _  | |_  | |_    ___   _ __   _ __     | \  / |   __ _  | |_    ___  | |__    _   _ __     __ _ 
 *     |  __|   \ \/ / | '_ \  | | | |  / __|  / _` | | __| | |  / _ \  | '_ \    |  ___/   / _` | | __| | __|  / _ \ | '__| | '_ \    | |\/| |  / _` | | __|  / __| | '_ \  | | | '_ \   / _` |
 *     | |____   >  <  | |_) | | | | | | (__  | (_| | | |_  | | | (_) | | | | |   | |      | (_| | | |_  | |_  |  __/ | |    | | | |   | |  | | | (_| | | |_  | (__  | | | | | | | | | | | (_| |
 *     |______| /_/\_\ | .__/  |_| |_|  \___|  \__,_|  \__| |_|  \___/  |_| |_|   |_|       \__,_|  \__|  \__|  \___| |_|    |_| |_|   |_|  |_|  \__,_|  \__|  \___| |_| |_| |_| |_| |_|  \__, |
 *                     | |                                                                                                                                                                 __/ |
 *                     |_|                                                                                                                                                                |___/ 
 */
//?Vérifier type Objet && Conversion si Vérif ok
if(pikachu is Pikachu pi){//? pattern matching
dresseur.Paralyser(pi);
pi.Cri(pi);
}