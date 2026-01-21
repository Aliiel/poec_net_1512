### Objectif
Afficher un message clair à l'utilisateur après une action (enregistrement, suppression, erreur)

En MVC, c'est le comportement à avoir lorsqu'on créé, modifie, supprime une ressource (success ou erreurs)


### Variantes 
- 'alert-success' => succès  vert 
- 'alert-danger' => erreur rouge 
- 'alert-warning' => avertissement orange 
- 'alert-info' => information bleue 


### Exemple 

```html
<div class="alert alert-succes" role="alert">Enregistrement réussi !</div>
```

```html alert avec un lien
<div class="alert alert-succes" role="alert">
    Nouveau : <a href="#" class="alert-link"> Voir les nouveautés </a>

</div>
```
### 