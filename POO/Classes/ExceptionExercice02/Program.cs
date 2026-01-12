
using ExceptionExercice02.Classes;
using ExceptionExercice02.Exceptions;

Calcul calcul = new Calcul();

while (true)
{
    Console.WriteLine("Veuillez saisir un nombre pour calculer sa racine carré : ");
    string saisie = Console.ReadLine();

    try
    {
        calcul.RacineCarre(calcul.VerifierSaisie(saisie));

    } catch (NegatifException ex)
    {
        Console.WriteLine(ex.Message); 

    } catch (NotNumericEntry ex)
    {
        Console.WriteLine(ex.Message); 
    }
    
} ;