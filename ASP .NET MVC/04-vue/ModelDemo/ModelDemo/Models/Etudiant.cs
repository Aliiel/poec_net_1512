using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelDemo.Models
{
    public class Etudiant
    {
        public int Id { get; set; }

        
        [Display(Name ="Votre nom : ")]  // pour renommer la propriété dans le rendu
        // Le nom est obligatoire, le message d'erreur s'affiche s'il n'est pas rempli 
        [Required(ErrorMessage = "Le {0} est obligatoire")] // {0} correspond à la valeur de display.name qui est repris automatiquement (ici : "Votre nom : ")
        public string? Nom { get; set; }

        // Limitation du nombre de caractères à 100 & le min est de 2
        [StringLength(100, MinimumLength = 2)]
        public string? Prenom { get; set; }

        [Column(TypeName = "decimal(18,2)")]  // précise qu'il s'agit d'un décimal qui doit avoir 2 chiffres après la virgule 
        [Range(0, 20, ErrorMessage = "La note doit être entre 0 et 20")]
        public decimal Note { get; set; }

        [EmailAddress(ErrorMessage = "Format d'email invalide")]
        public string Email { get; set; }

        [Column("Telephone")]  // renomme la colonne dans la bdd 
        [Required(ErrorMessage = "Le numéro de téléphone est obligatoire")]
        [Phone(ErrorMessage = "Numéro de téléphone invalide")]
        public string NumeroTelephone { get; set; }

        [Url(ErrorMessage = "L'url est invalide")]
        public string PortfolioUrl { get; set; }

        // Empêche les âges négatifs avec un âge min a 16 et age max a 100
        [Range(16, 100, ErrorMessage = "L'âge doit être compris entre 16 et 100 ans")]
        public int Age { get; set; }
        public DateTime DateNaissance { get; set; }


        // Propriétés calculées 
        public bool IsAdult => Age > 18;

        // Pour préciser que l'attribut n'est pas persisté en bdd
        [NotMapped]
        public string FullName
        {
            get 
            {
                return $"{Nom} + {Prenom}";
            }
        }


        public string CategorieAge
        {
            get
            {
                if (Age < 18) return "Mineur";
                if (Age <= 25) return "Jeune adulte";
                return "Adulte";
            }
        }

        [DataType(DataType.MultilineText)]
        [Display(Name = "La vie de l'étudiant")]
        public string Biographie { get; set; }


        // => pour des calculs simples 
        // "get {}" pour de la logique complexe

        // Clé étrangère qui est une référence vers la classe 
        public int ClasseId { get; set; }

        // Propriété de navigation qui permet d'accéder à la classe 
        public Classe Classe { get; set; }

        // Propriété de navigation vers les cours
        public List<Cours> Cours { get; set; } = new List<Cours>();



        /* 
         | Annotation | Description | Exemple | Type cible |
         |------------|-------------|---------|------------|
         | `[Required]` | Champ obligatoire | `[Required]` | Tous |
         | `[StringLength]` | Longueur max (et min) | `[StringLength(100, MinimumLength = 3)]` | string |
        | `[MaxLength]` | Longueur maximale | `[MaxLength(100)]` | string, array |
        | `[MinLength]` | Longueur minimale | `[MinLength(3)]` | string, array |
        | `[Range]` | Plage de valeurs | `[Range(1, 100)]` | int, decimal, double |
        | `[EmailAddress]` | Format email | `[EmailAddress]` | string |
        | `[Phone]` | Format téléphone | `[Phone]` | string |
        | `[Url]` | Format URL | `[Url]` | string |
        | `[CreditCard]` | Format carte bancaire | `[CreditCard]` | string |
        | `[Compare]` | Comparer deux champs | `[Compare("Password")]` | Tous |
        | `[RegularExpression]` | Regex personnalisée | `[RegularExpression(@"^\d{5}$")]` | string |
        | `[Column]` | Type SQL ou nom de colonne | `[Column(TypeName = "decimal(18,2)")]` | Tous |
        | `[NotMapped]` | Propriété non mappée en BDD | `[NotMapped]` | Tous |
         */
    }
}
