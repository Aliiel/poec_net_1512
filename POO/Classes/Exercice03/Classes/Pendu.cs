using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice03.Classes
{
    internal class Pendu
    {
        public string? Masque {  get; set; }
        public int NombreEssais { get; set; }
        public string? MotATrouver { get; set; }
        
        public Pendu(int nombreEssais) 
        {
            NombreEssais = nombreEssais;
        }

        public string GenererMasque (string motATrouver)
        {
            for (int i = 0; i < motATrouver.Length; i++)
            {
                return "";
            }
        }
    }
}
