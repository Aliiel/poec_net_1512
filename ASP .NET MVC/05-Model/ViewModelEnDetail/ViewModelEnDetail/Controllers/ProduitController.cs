using Microsoft.AspNetCore.Mvc;
using ViewModelEnDetail.Models;
using ViewModelEnDetail.ViewModel;

namespace ViewModelEnDetail.Controllers
{
    public class ProduitController : Controller
    {
        private static List<Produit> _produits = new()
        {
            new Produit
            {
                Id=1,
                Nom="Ordi",
                Prix=120.50m,
                Stock=10,
                CategorieId=1,
                Categorie= new Categorie{CategorieId=1, Nom="Informatique"}
            }
             
        };

        public IActionResult Index()
        {

            return View();
        }

        public IActionResult Details(int id)
        {
            var produit = _produits.FirstOrDefault(p => p.Id == id);
            if (produit == null)
            {
                return NotFound();
            }

            var viewmodel = new ProduitDetailsViewModel
            {
                Nom = produit.Nom,
                Stock = produit.Stock,
                PrixFormatte = produit.Prix.ToString("C"),
                NomCategorie = produit.Categorie?.Nom ?? "Sans catégorie"
            };

            return View(viewmodel);
        }
    }
}
