### Objectif 

Standardiser l'apparence des boutons (créer / enregistrer / modifier)


### Classes essentielles 

- base : 'btn'
- variantes : 'btn-primary', 'btn-secondary', 'btn-warning', 'btn-danger'
- contours : 'btn-outline-primary'
- tailles : 'btn-sm', 'btn-xxl' 
- désactivé : 'disabled' | sur le button, pas sur la classe


### Exemples 

```html
<button class="btn btn-primary">Button bleu</button>
<button class="btn btn-danger" disabled>Supprimer</button>
```


### Barre d'actions 

```html
<div class="d-flex gap-2 flex-wrap">
    <a class="btn btn-primary" href="#">Créer</a>
    <a class="btn btn-outline-warning" href="#">Modifier</a>
    <button class="btn btn-danger">Supprimer</button>
    <a class="btn btn-danger" href="#">Retour</a>
</div>
```
