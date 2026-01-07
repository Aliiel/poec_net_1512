using System;
using System.Collections.Generic;
using System.Text;

namespace DemoClasses
{
    internal class Chaise
    {
        public int NombrePieds { get; set; }

        public string? Materiaux { get; set; }

        public string? Couleur { get; set; }

        public Chaise()
        {
            NombrePieds = 4;
            Materiaux = "bois";
            Couleur = "marron";
        }

        public Chaise (int nombrePieds, string materiaux, string couleur)
        {
            NombrePieds = nombrePieds;
            Materiaux = materiaux;
            Couleur = couleur;
        }

        override
        public string ToString ()
        {
            return $"Je suis une chaise, j'ai {NombrePieds} pieds, je suis en {Materiaux} et de couleur {Couleur}."; ;
        }
    }
}
