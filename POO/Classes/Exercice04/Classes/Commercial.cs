using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice04.Classes
{
    internal class Commercial : Salarie
    {
        public double ChiffreAffaire { get; set; }
        public double Commission { get; set; }

        public Commercial(string matricule, string service, string categorie, string nom, double salaire, double chiffreAffaire, double commission) : base(matricule, service, categorie, nom, salaire)
        {
            ChiffreAffaire = chiffreAffaire;
            Commission = commission;
        }

        public override void AfficherSalaire()
        {
            base.AfficherSalaire();
            double SalaireReel = Salaire + Commission;
            Console.WriteLine($"Commission : {Commission} euros");
            Console.WriteLine($"Salaire réel : {SalaireReel} euros");
        }

        public override string ToString()
        {
            return "-- Commercial --\n" + base.ToString();
        }
    }
}
