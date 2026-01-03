Console.WriteLine("Quel est votre prénom ? ");
string prenomUtilisateur = Console.ReadLine();

Console.WriteLine("Quel est votre nom ? ");
string nomUtilisateur = Console.ReadLine();

Console.WriteLine($"Bienvenue {prenomUtilisateur} {nomUtilisateur} !!");

Console.WriteLine("Quel est votre âge ? ");
int ageUtilisateur = Convert.ToInt32(Console.ReadLine());

const int ageRecommande = 21;
bool accesOk = ageUtilisateur > ageRecommande;