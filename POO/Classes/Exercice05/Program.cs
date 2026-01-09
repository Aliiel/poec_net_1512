

using Exercice05.Classes;

string? saisie;


Client CreationClient()
{
    Console.WriteLine("Bienvenue ! Quel est votre nom ?");
    string? nom = Console.ReadLine();

    Console.WriteLine("Votre prénom ?");
    string? prenom = Console.ReadLine();

    Console.WriteLine("Votre numéro de téléphone ?");
    string? numTel = Console.ReadLine();

    Client newClient = new Client(nom, prenom, numTel);

    return newClient;
}

void Start()
{
    Client user = CreationClient();

    do
    {
        Console.WriteLine("--- MENU PRINCIPAL ---" +
            "\n1. Lister les comptes bancaires" +
            "\n2. Créer un compte bancaire" +
            "\n3. Effectuer un dépôt" +
            "\n4. Effectuer un retrait" +
            "\n5. Afficher les opérations et le solde" +
            "\n6. Quitter le programme");

        Console.Write("Votre choix : ");
        saisie = Console.ReadLine();

        switch(saisie)
        {
            case "1":
                ListerCompteBancaires(user);
                break;
            case "2":
                CreerCompteBancaire(user);
                break;
            case "3":
                break;
            case "4":
                break;
            case "5":
                break;
            case "6":
                Console.WriteLine("Au revoir !");
                break;
            default:
                Console.WriteLine("Mauvaise saisie");
                    break;
        }

    } while (saisie != "6");


}

void ListerCompteBancaires(Client client)
{
    client.AfficherComptes();
}

void CreerCompteBancaire(Client client)
{
    string? choix;

    do
    {
        Console.WriteLine("--- CREATION DE COMPTE ---" +
            "\n1. Créer un compte courant" +
            "\n2. Créer un compte épargne" +
            "\n3. Créer un compte payant" +
            "\n4. Retour");

        Console.Write("Votre choix : ");
        choix = Console.ReadLine();
        double montant = 0;

        switch (choix)
        {
            case "1":
                Console.WriteLine("Quel montant pour la création de votre compte courant ?");
                montant = double.Parse(Console.ReadLine());
                CreerCompteCourant(client, montant);
                
                break;
            case "2":
                Console.WriteLine("Quel montant pour la création de votre compte épargne ?");
                montant = double.Parse(Console.ReadLine());
                CreerCompteEpargne(client, montant);
                break;
            case "3":
                Console.WriteLine("Quel montant pour la création de votre compte payant ?");
                montant = double.Parse(Console.ReadLine());
                CreerComptePayant(client, montant);
                break;
            case "4":
                return;
            default:
                Console.WriteLine("Saisie invalide");
                break;
        } 

    } while (true);
}


void CreerCompteCourant(Client client, double montant)
{
    CompteCourant compteCourant = new CompteCourant(montant, client);
    client.CreerUnCompte(compteCourant);
}

void CreerCompteEpargne(Client client, double montant)
{
    Console.WriteLine("Saisir le taux d'épargne : ");
    double tauxEpargne = double.Parse(Console.ReadLine());
    CompteEpargne compteEpargne = new CompteEpargne(montant, client, tauxEpargne);
    client.CreerUnCompte(compteEpargne);
}

void CreerComptePayant(Client client, double montant)
{
    Console.WriteLine("Saisir le coût : ");
    double cout = double.Parse(Console.ReadLine());
    ComptePayant comptePayant = new ComptePayant(montant, client, cout);
    client.CreerUnCompte(comptePayant);
}

Start();

