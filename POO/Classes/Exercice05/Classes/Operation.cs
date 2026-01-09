using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice05.Classes
{
    internal class Operation
    {
        public static int _numeroOperation = 0;

        public int NumeroOperation { get; set; }
        public double Montant { get; set; }
        public Statut statut { get; set; }
        public enum Statut
        {
            retrait,
            depot
        };

        public Operation(double montant, Statut statut)
        {
            _numeroOperation++;
            NumeroOperation = _numeroOperation;
            Montant = montant;
        }

        public override string ToString()
        {
            return $"Opérations effectuées : {statut}, d'un montant de {Montant}";
        }
    }
}
