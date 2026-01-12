using Exercice06.Classes.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice06.Classes
{
    internal class Paypal : IPaiement
    {
        public string AdresseMail { get; set; }
        public string MotDePasse { get; set; }
        public double Montant { get; set; }

        public Paypal(string adresseMail, string motDePasse)
        {
            AdresseMail = adresseMail;
            MotDePasse = motDePasse;
        }

        public string EffectuerPaiement(double montant)
        {
            if (Montant > montant) return $"paiement of {montant} euros by Paypal successed";

            return $"paiement of {montant} euros by Paypal failed";
        }

    }
}
