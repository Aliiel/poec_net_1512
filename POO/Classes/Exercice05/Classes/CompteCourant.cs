using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice05.Classes
{
    internal class CompteCourant : CompteBancaire
    {
        public static int _compteurComptesCourants = 0;
        public CompteCourant(double solde, Client? client) : base(solde, client)
        {
            _compteurComptesCourants++;
            base.Solde = solde;
            base.client = client;
        }

        public override string ListerComptes()
        {
            return base.ListerComptes() + $"\nTotal comptes courants : {_compteurComptesCourants}";
        }

        public override void EffectuerOperation(Operation operation)
        {
            base.EffectuerOperation(operation);
        }

        public override string ToString()
        {
            return $"-- Compte courant --\n" + base.ToString();
        }
    }
}
