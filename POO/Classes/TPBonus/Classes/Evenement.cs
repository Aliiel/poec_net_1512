using System;
using System.Collections.Generic;
using System.Text;

namespace TPBonus.Classes
{
    internal class Evenement
    {
        public string Nom { get; set; }
        public Lieu Lieu { get; set; }
        public DateOnly Date { get; set; }
        public DateOnly Heure { get; set; }
        public int NombrePlaces { get; set; }
        public Billet Billet { get; set; }

        public Evenement(string nom, Lieu lieu, DateOnly date, DateOnly heure, int nombrePlaces, Billet billet)
        {
            Nom = nom;
            Lieu = lieu;
            Date = date;
            Heure = heure;
            NombrePlaces = nombrePlaces;
            Billet = billet;
        }
    }
}
