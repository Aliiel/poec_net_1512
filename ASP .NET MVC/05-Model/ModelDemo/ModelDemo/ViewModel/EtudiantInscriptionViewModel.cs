using ModelDemo.Validation;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace ModelDemo.ViewModel
{

    // Class Model (ViewModel) adaptée à une vue spécifique 
    // (ici formulaire d'inscription d'un étudiant)
    public class EtudiantInscriptionViewModel
    {
        [Required(ErrorMessage = "Le nom est obligatoire")]
        [Display(Name = "Nom de l'étudiant")]
        [StringLength(20, MinimumLength =2, ErrorMessage="Le nom doit contenir minimum 2 caractères et maximum 20")]
        public string Nom {  get; set; }

        [EmailAddress(ErrorMessage = "Le format de l'email est invalide")]
        [Required(ErrorMessage = "L'email est obligatoire")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [MinimumAge(16)]
        public DateTime DateNaissance { get; set; }
    }
}
