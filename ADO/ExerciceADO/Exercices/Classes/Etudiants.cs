using System;
using System.Collections.Generic;
using System.Text;

namespace Exercices.Classes
{
    internal class Etudiants
    {
        public int Id { get; set; }
        public string Nom {  get; set; }
        public string Prenom { get; set; }
        public string NumeroClasse { get; set; }
        public DateTime DateDiplome { get; set; }

        public Etudiants(string nom, string prenom, string numeroClasse, DateTime dateDiplome)
        {
            Nom = nom;
            Prenom = prenom;
            this.NumeroClasse = numeroClasse;
            DateDiplome = dateDiplome;
        }

        public Etudiants(int id, string nom, string prenom, string numeroClasse, DateTime dateDiplome)
        {
            Id = id;
            Nom = nom;
            Prenom = prenom;
            this.NumeroClasse = numeroClasse;
            DateDiplome = dateDiplome;
        }

        public override string ToString()
        {
            return $"Id : {Id}  | {Prenom} {Nom} | Numéro de classe : {NumeroClasse} | Date du diplôme : {DateDiplome}";
        }
    }
}
