using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice05.Classes
{
    internal class Operation
    {
        public string? Numero { get; set; }
        public double Montant { get; set; }
        public Statut statut { get; set; }
        public enum Statut
        {
            retrait,
            depot
        };

        public Operation(string? numero, double montant, Statut statut)
        {
            Numero = numero;
            Montant = montant;
            this.statut = statut;
        }
    }
}
