using System;

class Exercice01
{
    static void Main(string[] args)
    {
        Console.WriteLine("Quel est votre prénom ? ");
        string prenomUtilisateur = Console.ReadLine();

        Console.WriteLine("Quel est votre nom ? ");
        string nomUtilisateur = Console.ReadLine();

        Console.WriteLine($"Bienvenue {prenomUtilisateur} {nomUtilisateur} !!");

        Console.WriteLine("Quel est votre âge ? ");
        int ageUtilisateur = Convert.ToInt32(Console.ReadLine());

        const int ageRecommande = 21;
        bool accesOk = ageUtilisateur >= ageRecommande;

        if (accesOk)
        {
            Console.WriteLine("Hello ! Que souhaitez-vous commander ?");
            double ardoise = 0;

            while (true)
            {
                Console.WriteLine(
                    "\n1 - Pinte de bière : 7.50€ " +
                    "\n2 - Moscow mule : 8.90 €" +
                    "\n3 - Orangina : 2.50 €" +
                    "\n4 - Thé à la menthe : 4 €" +
                    "\nSTOP - Affichage de l'ardoise à régler");

                string saisie = Console.ReadLine();

                if (saisie == "STOP")
                {
                    Console.WriteLine("Veuillez régler votre ardoise d'un montant de : " + ardoise);
                    break;
                }

                switch (saisie)
                {
                    case "1":
                        Console.WriteLine("7.50 € pour la pinte de bière !");
                        ardoise += 7.50;
                        break;
                    case "2":
                        Console.WriteLine("8.90 € pour le Moscow Mule !");
                        ardoise += 8.90;
                        break;
                    case "3":
                        Console.WriteLine("2.50 € pour l'Orangina !");
                        ardoise += 2.50;
                        break;
                    case "4":
                        Console.WriteLine("4 € pour le thé à la menthe !");
                        ardoise += 4;
                        break;
                    default:
                        Console.WriteLine("Choix impossible");
                        break;
                }
            }
        }
        else
        {
            Console.WriteLine("Vous n'avez pas l'âge requis pour commander. Bye !");
        }
    }
}




