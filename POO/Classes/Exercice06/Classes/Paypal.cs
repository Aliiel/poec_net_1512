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

        public Paypal(string adresseMail, string motDePasse)
        {
            AdresseMail = adresseMail;
            MotDePasse = motDePasse;
        }

        public string EffectuerPaiement(double montant)
        {
            if (montant > 0) return $"paiement of {montant} successed";

            return $"paiement {montant} failed";
        }

    }
}
