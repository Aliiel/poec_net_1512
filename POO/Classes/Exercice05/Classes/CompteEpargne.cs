using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice05.Classes
{
    internal class CompteEpargne : CompteBancaire
    {
        public static int _compteurComptesEpargne = 0;
        public CompteEpargne(double solde, Client? client) : base(solde, client)
        {
            _compteurComptesEpargne++;
        }

        public override string ListerComptes()
        {
            return base.ListerComptes() + $"\nTotal comptes épargne : {_compteurComptesEpargne}";
        }

        public override void EffectuerOperation(Operation operation)
        {
            base.EffectuerOperation(operation);
        }

        public override string ToString()
        {
            return $"-- Compte épargne --\n" + base.ToString();
        }
    }
}
