using System;
using System.Collections.Generic;
using System.Text;

namespace TPBonus.Classes
{
    internal class Lieu : Adresse
    {
        public string Capacite { get; set; }

        public Lieu(string rue, string ville, string capacite) : base(rue,ville)
        {
            Capacite = capacite;
        }

        
    }


}
