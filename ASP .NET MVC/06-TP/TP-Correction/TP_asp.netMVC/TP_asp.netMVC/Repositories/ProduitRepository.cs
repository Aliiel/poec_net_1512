using Microsoft.AspNetCore.Http.HttpResults;
using TP_asp.netMVC.Data;
using TP_asp.netMVC.Models;

namespace TP_asp.netMVC.Repositories
{
    public class ProduitRepository : IProduitRepository
    {
        public void Add(Produit produit)
        {
            if (DbFake.Produits.Any())
            {
                produit.Id = DbFake.Produits.Max(p => p.Id);
            }
            else
            {
                produit.Id = 1;
            }

            produit.Categorie = GetCategoryById(produit.CategorieId);
            DbFake.Produits.Add(produit);
        }

        public bool Delete(int Id)
        {
            var produit = DbFake.Produits.FirstOrDefault(p => p.Id == Id);

            if (produit != null)
            {
                DbFake.Produits.Remove(produit);
                return true;
            }

            return false;

        }

        public List<Produit> GetAll()
        {
            return DbFake.Produits;
        }

        public List<Categorie> GetAllCategories()
        {
            return DbFake.Categories.ToList();
        }

        public Produit? GetById(int Id)
        {
            return DbFake.Produits.FirstOrDefault(p => p.Id == Id);
        }

        public Categorie? GetCategoryById(int Id)
        {
            return DbFake.Categories.FirstOrDefault(c => c.Id == Id);
        }

        public void Update(Produit produit)
        {
            var index = DbFake.Produits.FindIndex(p => p.Id == produit.Id);

            if (index >= 0)
            {
                produit.Categorie = GetCategoryById(produit.CategorieId);
                DbFake.Produits[index] = produit;
            }
        }
    }
}
