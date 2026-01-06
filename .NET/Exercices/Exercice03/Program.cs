

/*
# Exercice 03 - Mastermind

## Objectifs

using System.Net.Http.Headers;

Appréhender le langage C# dans le cadre de la réalisation d'un programme de base

## Sujet 

Créer une application de type console en C# permettant:

* A un utilisateur de pouvoir choisir entre plusieurs modes de difficultés 
* Le programme va générer une succession de pions de couleurs aléatoire (de 4 à 10 pions en fonction du mode de difficulté)
* Le but pour l'utilisateur est de trouver la succession de pions de couleurs générée par le programme, par exemple `BJJR` pour Bleu, Jaune, Jaune, Rouge.
* Le programme devra compter les tentatives de découvertes de l'utilisateur et l'informer, à chaque tentative, de si il a trouvé : 
    * Un pion faisant partie de l'ensemble des pions, placé au bon emplacement
    * Un pion faisant partie de l'ensemble des pions, mais n'étant pas à la bonne place
    * Un pion ne faisant pas partie de l'ensemble des pions de la chaine de pions
* Le nombre de tentatives pourra être limité via un système de vie, au besoin

*/

using System;

class Exercice03
{
    static void Main(string[] args)
    {
        Console.WriteLine("Veuillez choisir votre mode de difficulté entre : " +
            "\n- Easy : 4 pions" +
            "\n- Moyen : 6 pions" +
            "\n- Difficile : 10 pions");

        string[] couleurs = { "Bleu", "Vert", "Jaune", "Violet" };

        string[] tabEasy = new string[4];
        string[] tabMoyen = new string[6];
        string[] tabDifficile = new string[10];

        for (int i = 0; i < 4; i++) 
        {
            Random rnd = new Random();
            int nbRandom = rnd.Next(0, 4);
            tabEasy[i] = couleurs[nbRandom];
        }

        for (int i = 0; i < 6; i++)
        {
            Random rnd = new Random();
            int nbRandom = rnd.Next(0, 4);
            tabMoyen[i] = couleurs[nbRandom];
        }

        for (int i = 0; i < 10; i++)
        {
            Random rnd = new Random();
            int nbRandom = rnd.Next(0, 4);
            tabDifficile[i] = couleurs[nbRandom];
        }

        Console.WriteLine("---- TAB EASY : ");
        foreach (string s in tabEasy)
        {
            Console.WriteLine($"Element du tableau : {s}");
        }

        Console.WriteLine("---- TAB MOYEN : ");
        foreach (string s in tabMoyen)
        {
            Console.WriteLine($"Element du tableau : {s}");
        }

        Console.WriteLine("---- TAB DIFFICILE : ");
        foreach (string s in tabDifficile)
        {
            Console.WriteLine($"Element du tableau : {s}");
        }


        int tentatives = 0;
        string saisieUtilisateur;

        string difficulte = Console.ReadLine();
        string[] tabATrouver;
    }
}