using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice05.Classes
{
    internal class CompteEpargne : CompteBancaire
    {
        public double TauxEpargne { get; set; }
        public CompteEpargne(double solde, Client? client, double tauxEpargne) : base(solde, client)
        {
            TauxEpargne = tauxEpargne;
        }

        public override void Depot(double montant)
        {
            Solde += montant * TauxEpargne;
        }

        public override bool Retrait(double montant)
        {
            if (Solde < montant) return false;

            Solde -= montant;
            return true;

        }

        public override string ToString()
        {
            return $"-- Compte épargne --\n" +
                $"Compte de {Client.Prenom}, solde du compte : {Solde} euros";
        }
    }
}
