using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice05.Classes
{
    internal class ComptePayant : CompteBancaire
    {
        public static int _compteurComptesPayants = 0;
        public ComptePayant(double solde, Client? client) : base(solde, client)
        {
            _compteurComptesPayants++;
        }

        public override string ListerComptes()
        {
            return base.ListerComptes() + $"\nTotal comptes payants : {_compteurComptesPayants}";
        }

        public override void EffectuerOperation(Operation operation) 
        {
            base.EffectuerOperation(operation);
        }

        public override string ToString()
        {
            return $"-- Compte payant --\n" + base.ToString();
        }
    }
}
