using System.ComponentModel.DataAnnotations;

namespace ViewModelEnDetail.Models
{
    public class Classe
    {
        [Key] // Primary Key
        public int ClasseId { get; set; }
        public string ClasseName { get; set; }
    }
}
