using ExceptionExercice02.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionExercice02.Classes
{
    internal class Calcul
    {

        public Calcul() { }


        public void RacineCarre(int a)
        {
            if (a < 0)
            {
                throw new NegatifException("Votre nombre doit être positif !");
            }

            Console.WriteLine($"La racine carré de {a} est {Math.Sqrt(a)}");
        }


        public int VerifierSaisie(string saisie)
        {
            int SaisieConvertie;

            if (!int.TryParse(saisie, out SaisieConvertie))
            {
                throw new NotNumericEntry("Veuillez saisir une entrée numérique");
            }
            else
            {
                return SaisieConvertie;
            }
        }
    }
}
