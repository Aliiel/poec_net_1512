### Objectif 

Avoir une barre de nav normalement horizontalement sur un grand écran & se replier en burger sur mobile 


### Classes essentielles

'navbar' => active le style navbar 
'navbar-expand-lg' => depuis le menu à partir d'un écran large 
'navbar-brand' => styliser le nom / logo de l'appli 
'navbar-toggler' + 'data-bs-target' => ouvrir ou fermer la zone collapse qui a un id
'collapse' => rendre la zone repliable 
'navbar-collapse' => adapte au style de l'écran 
'navbar-nav' => stylise la liste 
'nav-item' => structure l'item
'nav-link' => stylise le lien 


### Exemple 

```html
<nav class="navbar navbar-expand-lg bg-body-tertiary border-bottom">
  <div class="container">
    <a class="navbar-brand" href="#">MonApp</a>
 
    <button class="navbar-toggler" type="button"
            data-bs-toggle="collapse" data-bs-target="#mainNavbar"
            aria-controls="mainNavbar" aria-expanded="false" aria-label="Menu">
      <span class="navbar-toggler-icon"></span>
    </button>
 
    <div class="collapse navbar-collapse" id="mainNavbar">
      <ul class="navbar-nav me-auto mb-2 mb-lg-0">
        <li class="nav-item"><a class="nav-link active" href="#">Accueil</a></li>
        <li class="nav-item"><a class="nav-link" href="#">Liste</a></li>
        <li class="nav-item"><a class="nav-link" href="#">Créer</a></li>
      </ul>
 
      <div class="d-flex gap-2">
        <a class="btn btn-outline-secondary" href="#">Connexion</a>
      </div>
    </div>
  </div>
</nav>
```

 