using Exercice02.Classes;

string? saisie;
List<Salarie> listeSalaries = new List<Salarie>();

do
{
    Console.WriteLine("--- GESTION ET AFFICHAGE DES SALARIES ---" +
    "\n1 - Entrer un nouveau salarié" +
    "\n2 - Afficher les salariés et leur salaire" +
    "\n3 - Afficher le nombre total de salariés" +
    "\n4 - Afficher le total des salariés et des salaires" +
    "\n5 - Remise à 0 des salariés" +
    "\n6 - Quitter le programme");

    saisie = Console.ReadLine();

    switch (saisie)
    {
        case "1":
            CreerNouveauSalarie(listeSalaries);
            break;
        case "2":
            AfficherSalariesEtSalaires(listeSalaries);
            break;
        case "3":
            AfficherNombreSalaries();
            break;
        case "4":
            AfficherNombreEtSalaires();
            break;
        case "5":
            RemiseAZero();
            break;
        case "6":
            Console.WriteLine("Au revoir !");
            break;
        default:
            Console.WriteLine("Choix invalide");
            break;
    }

} while (saisie != "6");


void CreerNouveauSalarie(List<Salarie> listeSalaries)
{
    double salaire;

    Console.WriteLine("Nom du salarié ?");
    string? nom = Console.ReadLine();

    Console.WriteLine($"Salaire de {nom} ?");

    string? saisie = Console.ReadLine();

    if (double.TryParse(saisie, out salaire))
    {
        Salarie salarie = new Salarie(nom, salaire);
        listeSalaries.Add(salarie);
    }
    else
    {
        Console.WriteLine("Erreur : veuillez entrer un nombre valide pour le salaire.");
    }
}

void AfficherSalariesEtSalaires(List<Salarie> listeSalaries)
{
    foreach (Salarie salarie in listeSalaries)
    {
        salarie.AfficherSalaire();
    }
}

void AfficherNombreSalaries()
{
    Salarie.AfficherNombreSalaries();
}

void AfficherNombreEtSalaires()
{
    Salarie.AfficherNombreSalariesEtSalaireTotal();
}

void RemiseAZero ()
{
    Salarie.RemiseAZero();
    listeSalaries.Clear();
}

