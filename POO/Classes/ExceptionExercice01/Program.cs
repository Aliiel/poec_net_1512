using ExceptionExercice01.Exceptions;
using ExceptionExercice01.Classes;


Saisie saisie = new Saisie();

while (true)
{
    try
    {
        saisie.SaisieUtilisateur();
    }
    catch (NotIntException e)
    {
        Console.WriteLine(e.Message);
    }
} 
