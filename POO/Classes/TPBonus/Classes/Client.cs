using System;
using System.Collections.Generic;
using System.Text;

namespace TPBonus.Classes
{
    internal class Client
    {
        public string Nom {  get; set; }
        public string Prenom { get; set; }
        public Adresse Adresse { get; set; }
        public int Age { get; set; }
        public string NumeroTelephone { get; set; }
        public List<Billet> ListeBillets { get; set; }


    }
}
