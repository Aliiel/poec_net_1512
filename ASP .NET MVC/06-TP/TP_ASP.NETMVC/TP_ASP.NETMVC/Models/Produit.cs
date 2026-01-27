namespace TP_ASP.NETMVC.Models
{
    public class Produit
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Description {  get; set; }
        public int Prix { get; set; }
        public int QuantiteStock { get; set; }
        public DateTime DateCreation { get; set; }
        public int CategorieId { get; set; }
        public Categorie Categorie { get; set; }
        public bool EstEnStock => QuantiteStock > 0;

    }
}
