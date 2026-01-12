using ExceptionExercice01.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionExercice01.Classes
{
    internal class Saisie
    {
        public Saisie() { }
        public void SaisieUtilisateur() 
        {
                string? saisie;
                int saisieInt;

                Console.Write("Bonjour ! Veuillez saisir un nombre entier :");
                saisie = Console.ReadLine();

                if (!int.TryParse(saisie, out saisieInt)) throw new NotIntException("Saisie incorrecte, il faut saisir un nombre entier");
        }
    }
}
