using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Exercice05.Classes
{
    internal class Client
    {
        private static Guid _identifiant;
        public string? Nom { get; set; }
        public string? Prenom { get; set; }
        public List<CompteBancaire>? ListeDesComptes { get; set; } = new ();
        public string? NumeroTel { get; set; }

        public Client ()
        {
            _identifiant = Guid.NewGuid();
        }

        public Client(string? nom, string? prenom, string? numeroTel)
        {
            Nom = nom;
            Prenom = prenom;
            NumeroTel = numeroTel;
        }

        public void CreerUnCompte(CompteBancaire compteACreer)
        {
            ListeDesComptes.Add(compteACreer);
        }

        public void ListerComptes()
        {
            
        }

        public void AfficherComptes()
        {
            if (ListeDesComptes.Count == 0) Console.WriteLine("Pas encore de compte bancaire");

            foreach (CompteBancaire compte in ListeDesComptes)
            {
                Console.WriteLine(compte.ToString());
            }
        }
    }
}
 