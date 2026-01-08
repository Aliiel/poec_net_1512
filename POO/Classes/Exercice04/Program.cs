using Exercice04.Classes;

string? saisie;
string? choix;
Salarie[] salariesTabs = new Salarie[0];
Commercial[] commercialTabs = new Commercial[0];

do
{
    Console.WriteLine("--- GESTION DES EMPLOYES ---" +
    "\n1 - Entrer un nouvel employé" +
    "\n2 - Afficher les salariés et leur salaire" +
    "\n3 - Rechercher un employé" +
    "\n4 - Quitter le programme");

    Console.Write("Entrez votre choix : ");
    saisie = Console.ReadLine();

    switch (saisie)
    {
        case "1":
            CreerNouveauSalarie();
            break;
        case "2":
            AfficherSalariesEtSalaires();
            break;
        case "3":
            Console.WriteLine("En cours");
            break;
        case "4":
            Console.WriteLine("Au revoir !");
            break;
        default:
            Console.WriteLine("Choix invalide");
            break;
    }

} while (saisie != "4");


void CreerEmploye()
{

}


void CreerCommercial()
{

}


void CreerNouveauSalarie()
{
    double salaire;

    Console.WriteLine("Matricule du salarié ?");
    string? matricule = Console.ReadLine();

    Console.WriteLine("Service ?");
    string? service = Console.ReadLine();

    Console.WriteLine("Catégorie ?");
    string? categorie = Console.ReadLine();

    Console.WriteLine("Nom du salarié ?");
    string? nom = Console.ReadLine();

    Console.WriteLine($"Salaire de {nom} ?");

    string? saisie = Console.ReadLine();

    if (double.TryParse(saisie, out salaire))
    {
        Salarie salarie = new Salarie(matricule, service, categorie, nom, salaire);

        Salarie[] newTab = new Salarie[salariesTabs.Length + 1];
        salariesTabs.CopyTo(newTab, 0);
        newTab[newTab.Length - 1] = salarie;

        salariesTabs = newTab;
    }
    else
    {
        Console.WriteLine("Erreur : veuillez entrer un nombre valide pour le salaire.");
    }
}

void AfficherSalariesEtSalaires()
{
    foreach (Salarie salarie in salariesTabs)
    {
        salarie.AfficherSalaire();
    }
}