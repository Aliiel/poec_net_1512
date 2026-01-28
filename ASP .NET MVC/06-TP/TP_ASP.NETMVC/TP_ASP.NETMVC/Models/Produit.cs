using System.ComponentModel.DataAnnotations.Schema;

namespace TP_ASP.NETMVC.Models
{
    public class Produit
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Description {  get; set; }

        [Column(TypeName = "decimal(18,2")]
        public decimal Prix { get; set; }
        public int QuantiteStock { get; set; }
        public DateTime DateCreation { get; set; } = DateTime.Now;
        public int CategorieId { get; set; }
        public Categorie? Categorie { get; set; }

        [NotMapped]
        public bool EstEnStock => QuantiteStock > 0;

    }
}
