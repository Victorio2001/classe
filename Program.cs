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

/***
 *       _____                         _                                   
 *      / ____|                       | |                                  
 *     | (___    _   _   _ __    ___  | |__     __ _   _ __    __ _    ___ 
 *      \___ \  | | | | | '__|  / __| | '_ \   / _` | | '__|  / _` |  / _ \
 *      ____) | | |_| | | |    | (__  | | | | | (_| | | |    | (_| | |  __/
 *     |_____/   \__,_| |_|     \___| |_| |_|  \__,_| |_|     \__, |  \___|
 *                                                             __/ |       
 *                                                            |___/        
 */
 //! Use mot clef virtual pour la méthode de la classe parente, pour dire que cette méthode peut être utiliser tel quelle ou modifier.
 //! Use mot clef Override depuis la classe child

if(pikachu is Pikachu po){
    po.Attaque_Eclair();
}
raichu.Attaque_Eclair();

/***
 *                 _             _                           _     _                 
 *         /\     | |           | |                         | |   (_)                
 *        /  \    | |__    ___  | |_   _ __    __ _    ___  | |_   _    ___    _ __  
 *       / /\ \   | '_ \  / __| | __| | '__|  / _` |  / __| | __| | |  / _ \  | '_ \ 
 *      / ____ \  | |_) | \__ \ | |_  | |    | (_| | | (__  | |_  | | | (_) | | | | |
 *     /_/    \_\ |_.__/  |___/  \__| |_|     \__,_|  \___|  \__| |_|  \___/  |_| |_|
 *                                                                                   
 *                                                                                   
 */
/*
 ! l'abstraction d'une classe empeche la création d'une nouvelle instance
*/
dresseur.Parler();


/***
 *      _____                   _       __              
 *     |  __ \                 | |     /_/              
 *     | |__) |   ___    _ __  | |_    ___    ___   ___ 
 *     |  ___/   / _ \  | '__| | __|  / _ \  / _ \ / __|
 *     | |      | (_) | | |    | |_  |  __/ |  __/ \__ \
 *     |_|       \___/  |_|     \__|  \___|  \___| |___/
 *                                                      
 *                                                      
 */
 /** 
 * ! définit la visiblitée de qlqchs:
 * - public -- visible par tous n'importe ou
 * - private -- visible seulement à l'intérieur de la classe (use for méthode ou données)
 * - internal -- visible uniquement dans le projet
 * - protected -- visible dans la classe et dans toute ces child
 * - protected internal -- visible dans une classe child d'un autre projet et le sien, jonction des deux visibilités
 * - private protected -- union de protected et internal, visibiliter pour les child definit dans le même projet  et pas les classes child d'un autre projet.
 **/


 
/***
 *      _____           _                    __                       
 *     |_   _|         | |                  / _|                      
 *       | |    _ __   | |_    ___   _ __  | |_    __ _    ___    ___ 
 *       | |   | '_ \  | __|  / _ \ | '__| |  _|  / _` |  / __|  / _ \
 *      _| |_  | | | | | |_  |  __/ | |    | |   | (_| | | (__  |  __/
 *     |_____| |_| |_|  \__|  \___| |_|    |_|    \__,_|  \___|  \___|
 *                                                                    
 *                                                                    
 */
 //! une Classe peut implémenter plusieurs interface
 //! une Interface peut hériter elle même d'une  autre interface
 //! pas besoin d'utiliser le mot clef override afin de substituer
 //! si redéfinition de la méthode alors il est impossible d'appeler la méthode "d'origine"
 //! pas de constructeur donc pas possible de forcer certaines informations à la création
var chien = new Chien();
chien.faire();

//! Cas d'héritage entre Interface
var test = new hopInterface();


/***
 *       _____   _             _     _        
 *      / ____| | |           | |   (_)       
 *     | (___   | |_    __ _  | |_   _    ___ 
 *      \___ \  | __|  / _` | | __| | |  / __|
 *      ____) | | |_  | (_| | | |_  | | | (__ 
 *     |_____/   \__|  \__,_|  \__| |_|  \___|
 *                                            
 *                                            
 */
// Chien.faire(); Non static
//! Pratique mais eviter un maximum le static pour les données.
//! membre et propriété en privatttteeee comme sa modifiable que depuis la classe
//! utiliser surtout pour les caches ou singleton

ClassStatic.retour();

 



 







