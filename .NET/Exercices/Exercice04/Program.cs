using System;

class Exercice04
{
    static void Main(string[] args)
    {

        Console.WriteLine("Veuillez entrer le nombre de produits que vous souhaitez ajouter (entre 5 et 20) : ");
        int NbProduits = Convert.ToInt32(Console.ReadLine());

        string[] NomProduits = new string[NbProduits];
        double[] PrixProduits = new double[NbProduits];
        int[] QuantiteProduits = new int[NbProduits];
        int[] nBProduitsVendus = new int[NbProduits];

        for (int i = 0; i < NomProduits.Length; i++)
        {
            Console.WriteLine($"Veuillez entrer le nom du produit n° {i + 1}: ");
            NomProduits[i] = Console.ReadLine();
        }

        foreach (string p in NomProduits)
        {
            Console.WriteLine($"Produit : {p}");
        }

        for (int i = 0; i < NomProduits.Length; i++)
        {
            Console.WriteLine($"Veuillez entrer le prix du produit {NomProduits[i]} : ");
            PrixProduits[i] = double.Parse(Console.ReadLine());
            Console.WriteLine($"Veuillez entrer la quantité du produit {NomProduits[i]} : ");
            QuantiteProduits[i] = int.Parse(Console.ReadLine());
            Console.WriteLine($"Veuillez entrer le nombre de produits vendus de {NomProduits[i]} : ");
            nBProduitsVendus[i] = int.Parse(Console.ReadLine());
        }

        foreach (double p in PrixProduits)
        {
            Console.WriteLine($"Prix du produit : {p}");
        }

        foreach (int p in QuantiteProduits)
        {
            Console.WriteLine($"Quantité du produit : {p}");
        }

        foreach (int p in nBProduitsVendus)
        {
            Console.WriteLine($"Nombre de produits vendus : {p}");
        }


        double CalculerValeurStock(double[] prix, int[] quantites)
        {
            double ValeurTotale = 0;

            for (int i = 0; i < NomProduits.Length; i++)
            {
                ValeurTotale += prix[i] * quantites[i];
            }

            return ValeurTotale;
        }

        double ValeurTotale = CalculerValeurStock(PrixProduits, QuantiteProduits);

        Console.WriteLine($"Valeur totale des produits : {ValeurTotale} euros.");


        double CalculerChiffreAffaires(double[] prix, int[] ventes)
        {
            double ChiffreAffaire = 0;

            for (int i = 0; i < NomProduits.Length; i++)
            {
                ChiffreAffaire += prix[i] * ventes[i];
            }

            return ChiffreAffaire;
        }

        double ChiffreAffaire = CalculerChiffreAffaires(PrixProduits, nBProduitsVendus);
        Console.WriteLine($"Chiffre d'affaire total : {ChiffreAffaire} euros.");


        string TrouverProduitPlusCher(string[] noms, double[] prix)
        {
            double prixMax = 0;
            string NomProduitPlusCher = "";

            for (int i = 0; i < NomProduits.Length; i++)
            {
                if (prix[i] > prixMax)
                {
                    prixMax = prix[i];
                    NomProduitPlusCher = NomProduits[i];
                }
            }

            return NomProduitPlusCher;
        }

        string NomProduitPlusCher = TrouverProduitPlusCher(NomProduits, PrixProduits);
        Console.WriteLine($"Le produit le plus cher est : {NomProduitPlusCher} ");


        string TrouverProduitLePlusVendu(string[] noms, int[] ventes)
        {
            double VentesMax = 0;
            string NomProduitPlusVendu = "";

            for (int i = 0; i < NomProduits.Length; i++)
            {
                if (ventes[i] > VentesMax)
                {
                    VentesMax = ventes[i];
                    NomProduitPlusVendu = NomProduits[i];
                }
            }

            return NomProduitPlusVendu;
        }

        string NomProduitPlusVendu = TrouverProduitLePlusVendu(NomProduits, nBProduitsVendus);
        Console.WriteLine($"Le produit le plus vendu est : {NomProduitPlusVendu} ");


        int CompterProduitsEnRupture(int[] quantites)
        {
            int NombreProduitsEnRupture = 0;

            for (int i = 0; i < quantites.Length; i++)
            {
                if (quantites[i] == 0)
                {
                    NombreProduitsEnRupture++;
                }
            }

            return NombreProduitsEnRupture;
        }

        int NombreProduitsEnRupture = CompterProduitsEnRupture(QuantiteProduits);
        Console.WriteLine($"Nombre de produits actuellement en rupture : {NombreProduitsEnRupture}");


        int CompterProduitsStockFaible(int[] quantites, int seuil)
        {
            int NombreDeProduitsSousStock = 0;

            for (int i = 0; i < quantites.Length; i++)
            {
                if (quantites[i] < seuil)
                {
                    NombreDeProduitsSousStock++;
                } 
            }

            return NombreDeProduitsSousStock;
        }

        Console.WriteLine($"Veuillez préciser le seuil pour vérifier le nombre de produits ayant une quantité inférieure : ");
        int seuil = int.Parse(Console.ReadLine());
        int NombreDeProduitsSousStock = CompterProduitsStockFaible(QuantiteProduits, seuil);
        Console.WriteLine($"Le nombre de produits ayant une quantité inférieure à {seuil} est : {NombreDeProduitsSousStock}");


        void AfficherFicheProduit(string nom, double prix, int quantite, int ventes)
        {
            string statut = "";
            double ChiffreAffaireGenere = prix * ventes;

            if (quantite < 10)
            {
                statut = "Stock faible";
            }
            if (quantite >= 10)
            {
                statut = "Stock correct";
            }
            if ( quantite == 0)
            {
                statut = "Rupture de stock";
            }

            Console.WriteLine("---- FICHE PRODUIT : ----" +
                $"\n- Nom du produit : {nom}" +
                $"\n- Prix unitaire du produit : {prix} euros" +
                $"\n- Quantité en stock : {quantite}" +
                $"\n- Nombre de ventes : {ventes}" +
                $"\n- Chiffre d'affaire généré : {ChiffreAffaireGenere} euros" +
                $"\n- Statut : {statut}");
        }

        Console.WriteLine("Veuillez saisir les informations du produit à afficher : ");
        Console.WriteLine("Nom du produit ?");
        string NomProduit = Console.ReadLine();
        Console.WriteLine("Prix du produit ? ");
        double PrixProduit = double.Parse(Console.ReadLine());
        Console.WriteLine("Quantité(s) du produit ? ");
        int QuantiteProduit = int.Parse(Console.ReadLine());
        Console.WriteLine("Nombre de ventes du produit ? ");
        int NombreVentesProduit = int.Parse(Console.ReadLine());

        AfficherFicheProduit(NomProduit, PrixProduit, QuantiteProduit, NombreVentesProduit);


        double CalculerMoyenne(double[] valeurs)
        {
            double Somme = 0;

            for (int i = 0; i < valeurs.Length; i++)
            {
                Somme += valeurs[i];
            }

            double Moyenne = Somme / valeurs.Length;
            return Moyenne;
        }


        void AfficherAlerteStock(string[] noms, int[] quantites, int seuil)
        {
            string ArticlesEnRupture = " ";

            for (int i = 0; i < quantites.Length; i++)
            {
                if (quantites[i] < seuil)
                {
                    ArticlesEnRupture += noms[i];
                }
                else
                {
                    ArticlesEnRupture = "Aucune alerte";
                }
            }
        }


        Console.WriteLine($"Veuillez préciser le seuil pour vérifier le nombre de produits ayant une quantité inférieure : ");
        int seuil2 = int.Parse(Console.ReadLine());
        AfficherAlerteStock(NomProduits, QuantiteProduits, seuil2);


    }
}