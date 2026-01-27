namespace ModelDemo.Models
{
    public class Classe
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        // Propriété de navigation
        public List<Etudiant> Etudiants { get; set; } = new List<Etudiant>();
    }
}
