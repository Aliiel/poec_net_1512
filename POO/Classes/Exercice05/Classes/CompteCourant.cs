using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice05.Classes
{
    internal class CompteCourant : CompteBancaire
    {
        public CompteCourant(double solde, Client? client) : base(solde, client)
        {

        }

        public override void Depot(double montant)
        {
            Solde += montant;
            ListeOperations.Add(new Operation(montant, Statut.depot));
        }

        public override bool Retrait(double montant)
        {
            if (Solde < montant) return false;

            Solde -= montant;
            ListeOperations.Add(new Operation(montant, Statut.retrait));
            return true;
        }

        public override string ToString()
        {
            return $"-- Compte courant --\n" +
                $"Compte de {Client.Prenom}, solde du compte : {Solde} euros";
        }
    }
}
