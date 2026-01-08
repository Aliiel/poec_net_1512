using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice05.Classes
{
    internal abstract class CompteBancaire
    {
        public static int _compteurTotalComptes = 0;
        public double Solde { get; set; }
        public Client? client { get; set; }
        public List<Operation>? operations { get; set; } = new();

        protected CompteBancaire(double solde, Client? client)
        {
            _compteurTotalComptes++;
            Solde = solde;
            this.client = client;
        }

        public virtual void EffectuerOperation(Operation operations)
        {
            switch (operations.statut)
            {

                case Operation.Statut.retrait:
                    Solde -= operations.Montant;
                    break;

                case Operation.Statut.depot:
                    Solde += operations.Montant;
                    break;
                default:
                    throw new ArgumentException("Erreur dans la transaction");
            }
        }

        public virtual string ListerComptes()
        {
            return $"Nombre total de comptes : {_compteurTotalComptes}"; 
        }

        public virtual string ToString()
        {
            return $"Compte de {client.Prenom}, solde du compte : {Solde} euros";
        }
    }
}
