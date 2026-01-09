using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice05.Classes
{
    internal abstract class CompteBancaire
    {
        public int NumeroCompte { get; set;  }
        public double Solde { get; set; }
        public Client? Client { get; set; }
        public List<Operation>? Operations { get; set; } = new();

        protected CompteBancaire(double solde, Client? client)
        {
            Solde = solde;
            Client = client;
        }

        public abstract void Depot(double montant);
        
        public abstract bool Retrait(double montant);

        public abstract string ToString();
    }
}
