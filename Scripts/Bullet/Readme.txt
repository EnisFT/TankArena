Modification g�n�ral :
	Layers :
		-Layer Walkable
		-Layer Indestructible
		-Layer Destructible
		-Layer Tank
		-Layer Bullet

	Appliquer les layers aux entit�es correspondantes.

Utilisation des scripts :
Script Bullet defini le gameobject comme �tant un bullet.
BulletEffect permet de modifier le comportement du bullet

Necessaire d'ajouter l'effet BounceEffect m�me si vous ne voulez pas faire rebondir la balle (Bounce counter � 0 dans ce cas)


Cocher les cases pour trigger l'effet au moment voulu :
applyOnCollision : quand le bullet touche quelquechose (c'est pour �a que les layers sont importants)
applyOnTimer : au bout d'un certain temps, d�fini par le champ "timer". Attention ! Ne pas mettre un timer de 0 (si l'effet va etre realiser toutes les frames)
applyOnCreation : quand le bullet est cr�er
applyOnDestruction : quand le bullet est d�truit


Pour creer un nouvel effet, faire h�riter votre script de "Bullet effect" et impl�menter la m�thode Effect.
