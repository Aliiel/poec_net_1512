using Exercice06.Classes;
using Exercice06.Classes.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice06
{
    internal class CarteDeCredit : IPaiement
    {

        public string NumeroCarte { get; set; }
        public string TitulaireCarte { get; set; }
        public DateTime DateExpiration { get; set; }
        public int CodeCCV { get; set; }

        public CarteDeCredit(string numeroCarte, string titulaireCarte, DateTime dateExpiration, int codeCCV)
        {
            NumeroCarte = numeroCarte;
            TitulaireCarte = titulaireCarte;
            DateExpiration = dateExpiration;
            CodeCCV = codeCCV;
        }


        public string EffectuerPaiement(double montant)
        {
            if (montant > 0) return $"paiement of {montant} euros successed";

            return $"paiement of {montant} failed";

        }
    }
}
