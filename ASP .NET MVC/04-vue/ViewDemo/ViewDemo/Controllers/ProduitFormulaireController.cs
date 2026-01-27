using Microsoft.AspNetCore.Mvc;
using ViewDemo.Models;

namespace ViewDemo.Controllers
{
    public class ProduitFormulaireController : Controller
    {
        private static List<Produit> _produits = new List<Produit>();
        // en static pour pouvoir la partager entre les fichiers sans devoir la réinstancier à chaque fois

        private static int _NextID = 1;
        public IActionResult Index()
        {
            return View(_produits);
        }


        [HttpGet] // pour afficher le formulaire vide 
        public IActionResult CreerProduit()
        {
            return View(new Produit()); // créé un produit vide pour le formulaire
        }

        [HttpPost]
        public IActionResult CreerProduit(Produit ProduitCree)
        {
            ProduitCree.Id = _NextID;
            _NextID++;

            _produits.Add(ProduitCree);

            return RedirectToAction("Index");
        }


    public IActionResult Details (int Id)
        {
            var Produit = _produits.FirstOrDefault(i=> i.Id == Id);

            return View(Produit);
        }
    }   
}
