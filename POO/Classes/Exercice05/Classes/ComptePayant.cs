using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice05.Classes
{
    internal class ComptePayant : CompteBancaire
    {

        public double Cout { get; set; }
        public ComptePayant(double solde, Client? client, double cout) : base(solde, client)
        {
            Cout = cout;
        }

        public override void Depot(double montant)
        {
             montant += (Solde - Cout);
        }

        public override bool Retrait(double montant)
        {
            if (Solde < montant) return false;

            Solde -= montant;
            return true;
            
        }

        public override string ToString()
        {
            return $"-- Compte payant --\n" +
                $"Compte de {Client.Prenom}, solde du compte : {Solde} euros";
        }
    }
}
