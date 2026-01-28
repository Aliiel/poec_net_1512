using System.ComponentModel.DataAnnotations;
using TP_ASP.NETMVC.Models;

namespace TP_ASP.NETMVC.ViewModel.Produits
{
    public class ProduitDetailsViewModel
    {
        public int Id { get; set; }
        public string Nom {  get; set; }
        public string Description { get; set; }
        public decimal Prix { get; set; }

        [Display(Name = "Nom de la catégorie")]
        public string NomCategorie { get; set; }

        public int QuantiteStock { get; set; }

        public string PrixFormate => Prix.ToString("C", new System.Globalization.CultureInfo("fr-FR"));

        public int CategorieId { get; set; }

        public DateTime DateCreation = DateTime.Now;

        public string DisponibiliteMessage
        {
            get
            {
                if (QuantiteStock == 0) return "Rupture de stock";
                if (QuantiteStock < 5) return "A réapprovisionner";
                return "En stock";
            }
        }

        public string DisponibiliteCssClass
        {
            get
            {
                if (QuantiteStock <= 0) return "bg-danger";
                if (QuantiteStock > 5) return "bg-warning";
                return "bg-success";

            }
        }

        [Display(Name = "Disponible")]
        public bool EstEnStock { get; set; }
    }
}
