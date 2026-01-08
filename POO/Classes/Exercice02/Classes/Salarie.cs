using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice02.Classes
{
    internal class Salarie
    {
        private static int _nombreSalaries = 0;
        private static double _totalSalaires = 0;

        public int Matricule {  get; set; }
        public string? Service { get; set; }
        public string? Categorie { get; set; }
        public string? Nom {  get; set; }
        public double Salaire { get; set; }

        public Salarie()
        {
            _nombreSalaries++;
        }

        public Salarie(string nom, double salaire):this()
        {
            Nom = nom;
            Salaire = salaire;
            _totalSalaires += salaire;
        }

        public void AfficherSalaire() 
        {
            Console.WriteLine($"Le salaire de {Nom} est de {Salaire} euros");
        }

        public static void AfficherNombreSalaries()
        {
            Console.WriteLine(_nombreSalaries == 0 ? "Pas de salariés enregistrés." : $"Il y a {_nombreSalaries} salarié(s).");
        }

        public static void AfficherNombreSalariesEtSalaireTotal()
        {
           Console.WriteLine(_nombreSalaries == 0 ? "Pas de salariés enregistrés" : $"Le montant total des salaires des {_nombreSalaries} salariés est de {_totalSalaires} euros.");
        }

        public static void RemiseAZero()
        {
            _nombreSalaries = 0;
            _totalSalaires = 0;
            Console.WriteLine($"Remise à zéro des salariés : {_nombreSalaries} salariés.");
        }
    }
}
