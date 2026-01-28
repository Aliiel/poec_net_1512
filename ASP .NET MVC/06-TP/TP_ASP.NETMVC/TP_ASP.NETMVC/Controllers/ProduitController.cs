using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using TP_ASP.NETMVC.Extensions;
using TP_ASP.NETMVC.Models;
using TP_ASP.NETMVC.ViewModel.Produits;

namespace TP_ASP.NETMVC.Controllers
{
    public class ProduitController : Controller
    {
        private static readonly List<Categorie> _categories = new()
            {
                new() { Id = 1, Nom = "Informatique" },
                new() { Id = 2, Nom = "Accessoires" },
                new() { Id = 3, Nom = "Périphériques" }
            };

        private static readonly List<Produit> _produits = new()
            {
                new()
                 {
                    Id = 1,
                    Nom = "Laptop Pro",
                    Description = "Ordinateur portable haute performance avec processeur Intel i7 et 16 Go de RAM",
                    Prix = 1299.99m,
                    QuantiteStock = 15,
                    DateCreation = DateTime.UtcNow.AddDays(-30),
                    CategorieId = 1,
                    Categorie = _categories[0]
                  },
                new()
                  {
                       Id = 2,
        Nom = "Souris Gaming",
        Description = "Souris optique avec capteur haute précision, 7 boutons programmables",
        Prix = 79.99m,
        QuantiteStock = 50,
        DateCreation = DateTime.UtcNow.AddDays(-15),
        CategorieId = 2,
        Categorie = _categories[1]
    },
    new()
    {
        Id = 3,
        Nom = "Clavier Mécanique",
        Description = "Clavier mécanique avec switches Cherry MX Blue, rétroéclairage RGB",
        Prix = 149.99m,
        QuantiteStock = 0,
        DateCreation = DateTime.UtcNow.AddDays(-60),
        CategorieId = 2,
        Categorie = _categories[1]
    },
    new()
    {
        Id = 4,
        Nom = "Écran 27\"",
        Description = "Écran 4K Ultra HD, 144 Hz, HDR10, temps de réponse 1ms",
        Prix = 399.99m,
        QuantiteStock = 3,
        DateCreation = DateTime.UtcNow.AddDays(-7),
        CategorieId = 3,
        Categorie = _categories[2]
    }
};

        public IActionResult Index()
        {
            var produitsViewModels = _produits.Select(p => p.ToListItem()).ToList();
            return View(produitsViewModels);
        }


        public IActionResult Details (int Id)
        {
            var Produit = _produits.FirstOrDefault(i => i.Id == Id);

            if (Produit == null) return NotFound();

            var ProduitDetailsViewModel = Produit.ToDetails();

            return View(ProduitDetailsViewModel);
        }


        [HttpGet]
        public IActionResult Create ()
        {
            var produitFormViewModel = new ProduitFormViewModel
            {
                CategoriesSelectList = new SelectList(_categories, "Id", "Nom")
            };

            return View(produitFormViewModel);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ProduitFormViewModel ProduitCree)
        {
            if (!ModelState.IsValid)
            {
                ProduitCree.CategoriesSelectList = new SelectList(_categories, "Id", "Nom");
                return View(ProduitCree);
            }

            var NouveauProduit = ProduitCree.ToModel();
            NouveauProduit.Id = _produits.Count > 0 ? _produits.Max(x => x.Id) + 1 : 1;

            NouveauProduit.DateCreation = DateTime.Now;
            NouveauProduit.Categorie = _categories.FirstOrDefault(c => c.Id == NouveauProduit.CategorieId);

            _produits.Add(NouveauProduit);

            TempData["Success"] = "Produit créé avec succès";
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit (int Id)
        {
            var ProduitAModifier = _produits.Find(p => p.Id == Id);

            if (ProduitAModifier == null) return NotFound();

            var ProduitAModifierViewModel = ProduitAModifier.ToFormViewModel();

            ProduitAModifierViewModel.CategoriesSelectList = new SelectList(_categories, "Id", "Nom", ProduitAModifier.CategorieId);

            return View(ProduitAModifierViewModel);
        }


        [HttpPost]
        public IActionResult Edit(int Id, ProduitFormViewModel ProduitModifie)
        {
            if (!ModelState.IsValid)
            {
                ProduitModifie.CategoriesSelectList = new SelectList(_categories, "Id", "Nom", ProduitModifie.CategorieId);

                return View(ProduitModifie);
            }

            var Produit = _produits.Find(p => p.Id == Id);

            if (Produit == null) return NotFound();

            var index = _produits.FindIndex(p =>  p.Id == Id);
            var produitEnBase = ProduitModifie.ToModel();

            Produit.Id = Id;
            Produit.DateCreation = produitEnBase.DateCreation;
            Produit.Categorie = _categories.FirstOrDefault(c => c.Id == Produit.CategorieId);

            _produits[index] = Produit;

            TempData["Succes"] = "Produit modifié avec succès";

            return RedirectToAction("Index");
        }


        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed (int id)
        {
            var produit = _produits.FirstOrDefault(p => p.Id == id);

            if (produit == null) return NotFound();

            _produits.RemoveAll(p  => p.Id == id);

            TempData["Succes"] = "Produit supprimé avec succès";

            return RedirectToAction("Index");
        }
    }
}
