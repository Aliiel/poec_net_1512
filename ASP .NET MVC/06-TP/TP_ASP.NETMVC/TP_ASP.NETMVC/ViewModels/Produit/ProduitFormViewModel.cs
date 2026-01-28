using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using TP_ASP.NETMVC.Models;

namespace TP_ASP.NETMVC.ViewModel.Produits
{
    public class ProduitFormViewModel
    {
        public int? Id { get; set; } 

        [Required(ErrorMessage = "Le nom est obligatoire")]
        public string Nom { get; set; }

        [Required]
        [MaxLength(500, ErrorMessage = "La description ne peut pas contenir plus de 500 caractères")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Required]
        public decimal Prix { get; set; }

        [Required]
        public int QuantiteStock { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime DateCreation { get; set; }

        public SelectList? CategoriesSelectList { get; set; }

        // public bool EstEdition => Id.HasValue;  // 
        public int CategorieId { get; set; }

        [Required]
        [Display(Name = "Catégorie")]
        public string CategorieName { get; set; }

        [Required]
        [MaxLength(500, ErrorMessage = "La description ne peut pas contenir plus de 500 caractères")]
        public string CategorieDescription { get; set; }
    }
}
