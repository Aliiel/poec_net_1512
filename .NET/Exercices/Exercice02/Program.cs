using System;

class Exercice02
{
    static void Main(string[] args)
    {
        Console.WriteLine("Veuillez choisir votre mode de difficulté : 1, 2 ou 3");
        string difficulte = Console.ReadLine();

        int essais = 0;

        switch (difficulte)
        {
            case "1":
                essais = 3;
                Console.WriteLine("Ok, vous avez 3 essais pour trouver le bon chiffre !");
                break;
            case "2":
                essais = 2;
                Console.WriteLine("Ok, vous avez 2 essais pour trouver le bon chiffre !");
                break;
            case "3":
                essais = 1;
                Console.WriteLine("Ok, vous avez 1 seul essai pour trouver le bon chiffre ! Bon chance !");
                break;
            default:
                essais = 0;
                break;
        }

        Random rnd = new Random();
        int nbATrouver = rnd.Next(0, 100);
        Console.WriteLine($"(nombre à trouver : {nbATrouver}) ");

        do
        {
            Console.WriteLine("Entrez un chiffre :");
            int nbSaisi = Convert.ToInt32(Console.ReadLine());

            if (nbSaisi == nbATrouver)
            {
                Console.WriteLine($"Bravo ! Vous avez trouvé le bon nombre qui était : {nbATrouver}.");
                break;
            }

            if (nbSaisi < nbATrouver)
            {
                essais--;
                Console.WriteLine($"C'est plus ! Il vous reste {essais} essais");
            }

            if (nbSaisi > nbATrouver)
            {
                essais--;
                Console.WriteLine($"C'est moins ! Il vous reste {essais} essais");
            }

        } while (essais > 0);

        if (essais == 0)
        {
            Console.WriteLine($"Perdu ! Vous n'avez pas trouvé le nombre qui était : {nbATrouver}.");
        }
    }
}