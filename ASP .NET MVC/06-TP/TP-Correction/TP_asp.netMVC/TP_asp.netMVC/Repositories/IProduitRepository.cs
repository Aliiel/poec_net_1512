using TP_asp.netMVC.Models;

namespace TP_asp.netMVC.Repositories
{
    public interface IProduitRepository
    {
        // IEnumerable = Version opti pour la liste ici 
        List<Produit> GetAll();

        Produit? GetById(int Id);

        void Add(Produit produit);

        void Update(Produit produit);

        bool Delete(int Id);

        List<Categorie> GetAllCategories();

        Categorie? GetCategoryById(int Id);
    }
}
