using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace ModelDemo.ViewModel
{
    public class ContactViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Veuillez entrer votre nom")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Le nom doit contenir entre 2 et 50 caractères")]
        [Display(Name = "Votre nom")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Veuillez entrer votre email")]
        [EmailAddress(ErrorMessage = "Format d'email invalide")]
        [Display(Name = "Votre email", Prompt = "exemple@domaine.com")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Veuillez entrer un sujet")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Le sujet doit contenir entre 5 et 100 caractères")]
        [Display(Name = "Sujet du message")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "Veuillez entrer votre message")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Le message doit contenir entre 20 et 2000 caractères")]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Votre message")]
        public string Message { get; set; }

        [Phone(ErrorMessage = "Numéro de téléphone invalide")]
        [Display(Name = "Téléphone (optionnel)", Prompt = "06 12 34 56 78")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Veuillez sélectionner un niveau d'urgence")]
        [Display(Name = "Niveau d'urgence")]
        [DataType(DataType.Text)]
        public string Urgency { get; set; }

        public string UrgencyOptions { get; set; }

    }
}
