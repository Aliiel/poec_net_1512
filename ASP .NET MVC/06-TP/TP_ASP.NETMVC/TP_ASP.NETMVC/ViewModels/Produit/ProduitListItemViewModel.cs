using System.ComponentModel.DataAnnotations;
using TP_ASP.NETMVC.Models;

namespace TP_ASP.NETMVC.ViewModel.Produits
{
    public class ProduitListItemViewModel
    {
        public int Id { get; set; }
        public string Nom { get; set; } = string.Empty;
        public decimal Prix { get; set; }
        public int QuantiteStock { get; set; }

        [Display(Name = "Catégorie")]
        public string NomCategorie { get; set; } = string.Empty;

        public string PrixFormate => Prix.ToString("C", new System.Globalization.CultureInfo("fr-FR"));

        [Display(Name = "Disponible")]
        public bool EstEnStock => QuantiteStock > 0;
    }
}
