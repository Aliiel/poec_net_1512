namespace ModelDemo.Models
{
    public class Cours
    {
        public int Id { get; set; }
        public string? Nom { get; set; }

        // Propriété de navigation vers les étudiants 
        public List<Etudiant> Etudiants { get; set; } = new List<Etudiant>();
    }
}
