using System;

class Exercice02
{
    static void Main(string[] args)
    {
        Console.WriteLine("Veuillez choisir votre mode de difficulté : 1, 2 ou 3");
        string? Difficulte = Console.ReadLine();

        int Essais = Difficulte switch
        {
            "1" => 3,
            "2" => 2,
            "3" => 1,
            _ => 0
        };

        Random rnd = new Random();
        int NbATrouver = rnd.Next(0, 100);
        Console.WriteLine($"(nombre à trouver : {NbATrouver}) ");

        do
        {
            Console.WriteLine("Entrez un chiffre :");
            int NbSaisi = Convert.ToInt32(Console.ReadLine());

            if (NbSaisi == NbATrouver)
            {
                Console.WriteLine($"Bravo ! Vous avez trouvé le bon nombre qui était : {NbATrouver}.");
                break;
            }

            if (NbSaisi < NbATrouver)
            {
                Essais--;
                Console.WriteLine($"C'est plus ! Il vous reste {Essais} essais");
            }

            if (NbSaisi > NbATrouver)
            {
                Essais--;
                Console.WriteLine($"C'est moins ! Il vous reste {Essais} essais");
            }

        } while (Essais > 0);

        if (Essais == 0)
        {
            Console.WriteLine($"Perdu ! Vous n'avez pas trouvé le nombre qui était : {NbATrouver}.");
        }
    }
}