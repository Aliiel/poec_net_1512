using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice05.Classes
{
    internal abstract class CompteBancaire
    {
        public double Solde { get; set; }
        public Client? Client { get; set; }
        public List<Operation>? ListeOperations { get; set; } = new();

        protected CompteBancaire(double solde, Client? client)
        {
            Solde = solde;
            Client = client;
            ListeOperations = new List<Operation>();
        }

        public abstract void Depot(double montant);
        
        public abstract bool Retrait(double montant);

        public override string ToString()
        {
            return base.GetType().Name + $" avec un solde de {Solde} euros";
        }
    }
}
