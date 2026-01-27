namespace TP_ASP.NETMVC.Models
{
    public class Categorie
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Description { get; set; }
        public List<Produit> Produits { get; set; } = new List<Produit>();
    }
}
