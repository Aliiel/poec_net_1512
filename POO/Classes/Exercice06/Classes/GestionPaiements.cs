using Exercice06.Classes.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice06.Classes
{
    internal class GestionPaiements
    {

        public GestionPaiements()
        {
           
        }

        public void Transactions()
        {
            
        }


        public CarteDeCredit EntrerInfosCB()
        {
            IPaiement PaiementCB;

            Console.WriteLine("Entrez les numéros de votre carte : ");
            string numeroCB = Console.ReadLine();

            Console.WriteLine("Entrez le nom du titulaire de la carte : ");
            string nomTitulaire = Console.ReadLine();

            Console.WriteLine("Entrez la date d'expiration (format AAAA, M, J)");
            DateTime dateXP = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Entrez le cryptogramme de la carte : ");
            int CCV = int.Parse(Console.ReadLine());

            PaiementCB = new CarteDeCredit(numeroCB, nomTitulaire, dateXP, CCV);

            return (CarteDeCredit) PaiementCB;
        }


        public Paypal EntrerInfosPaypal ()
        {
            IPaiement PaiementPayPal;

            Console.WriteLine("Entrez votre adresse e-mail : ");
            string Email = Console.ReadLine();

            Console.WriteLine("Entrez votre mot de passe");
            string MotDePasse = Console.ReadLine();

            PaiementPayPal = new Paypal(Email, MotDePasse);

            return (Paypal) PaiementPayPal;
        }
    }
}
