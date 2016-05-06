Modification général :
	Layers :
		-Layer Walkable
		-Layer Indestructible
		-Layer Destructible
		-Layer Tank
		-Layer Bullet

	Appliquer les layers aux entitées correspondantes.

Utilisation des scripts :
Script Bullet defini le gameobject comme étant un bullet.
BulletEffect permet de modifier le comportement du bullet

Necessaire d'ajouter l'effet BounceEffect même si vous ne voulez pas faire rebondir la balle (Bounce counter à 0 dans ce cas)


Cocher les cases pour trigger l'effet au moment voulu :
applyOnCollision : quand le bullet touche quelquechose (c'est pour ça que les layers sont importants)
applyOnTimer : au bout d'un certain temps, défini par le champ "timer". Attention ! Ne pas mettre un timer de 0 (si l'effet va etre realiser toutes les frames)
applyOnCreation : quand le bullet est créer
applyOnDestruction : quand le bullet est détruit


Pour creer un nouvel effet, faire hériter votre script de "Bullet effect" et implémenter la méthode Effect.
