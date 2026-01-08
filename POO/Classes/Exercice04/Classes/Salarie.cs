using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice04.Classes
{
        internal class Salarie
        {
        private static int _nombreSalaries = 0;
        private static double _totalSalaires = 0;

        public string? Matricule { get; set; }
        public string? Service { get; set; }
        public string? Categorie { get; set; }
        public string? Nom { get; set; }
        public double Salaire { get; set; }

        public Salarie()
        {
            _nombreSalaries++;
        }

        public Salarie(string matricule, string service, string categorie, string nom, double salaire) : this()
        {
            Matricule = matricule;
            Service = service;
            Categorie = categorie;
            Nom = nom;
            Salaire = salaire;
            _totalSalaires += salaire;
        }

        public virtual void AfficherSalaire()
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
        }

        public override string ToString()
        {
            return $"-- Salarié --" +
                $"\nMatricule : {Matricule}" +
                $"\nService : {Service}" +
                $"\nCatégorie : {Categorie}" +
                $"\nNom : {Nom}" +
                $"\nSalaire : {Salaire}";
        }
    }
}
