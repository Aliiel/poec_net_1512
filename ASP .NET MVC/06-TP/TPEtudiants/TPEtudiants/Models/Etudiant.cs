using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace TPEtudiants.Models
{
    public class Etudiant
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Cours Cours { get; set; }

    }
}
