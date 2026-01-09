using Exercice06.Classes;
using Exercice06.Classes.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice06
{
    internal class GestionPaiements
    {

        public GestionPaiements()
        {

        }

        public void Transactions()
        {
            IPaiement paiement;

            Console.WriteLine("Quel type de paiement souhaitez-vous effectuer ? CB ou Paypal");
            string paiementType = Console.ReadLine();

            if (paiementType.Equals("CB"))
            {
                paiement = new CarteDeCredit("1234531", "Lalalala", new DateTime(2028, 3, 25), 456);
                paiement = new CarteDeCredit("2345810", "Gisèle", new DateTime(2032, 4, 24), 917);
                Console.WriteLine(paiement.EffectuerPaiement(56.5));
                Console.WriteLine(paiement.EffectuerPaiement(78.99));
            } if (paiementType.Equals("Paypal"))
            {
                paiement = new Paypal("lala@mail.com", "123456");
                Console.WriteLine(paiement.EffectuerPaiement(499.99));
                Console.WriteLine(paiement.EffectuerPaiement(-45));
            } 
        }
    }
}
