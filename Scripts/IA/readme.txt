Comportement des IA:

	IA lvl 1: Avance vers un tank ennemi, attend un peu avant de tirer.

	IA lvl 2: Avance vers un tank ennemi, tire dès qu'elle peut.

	IA lvl 3: Avance vers un tank ennemi, tire en faisant un rebond.

	IA lvl 4: Avance vers un tank ennemi, tire sur la trajectoire de sa cible.

	IA lvl 5: Avance vers un tank ennemi, tire en faisant un rebond sur la trajectoire de sa cible.

	IA lvl X: Reste sur place, incante pendant 3 secondes avant de lancer un KAMEHAMEHAAAAAAAAAAAAAA!!

Remarque: Un IA de lvl 3 peut très bien tirer sans faire de rebond si cela est plus efficace ( si il n'y a pas d'obstacle )

------------------------------------------------------------------------------------------------------
Utilisation des scripts:

	-iaMove.cs: Description: Sert à faire bouger le tank de l'IA
                    -----------------------------------------------
		    Emplacement: Mettre simplement sur le tank

------------------------------------------------------------------------------------------------------

	-iaCanonMove.cs: Description: Sert à faire tourner la tourelle du tank de l'Ia
                         ------------------------------------------------------------
                         Emplacement: Mettre sur la tourelle => tank.GetChild(1)

------------------------------------------------------------------------------------------------------

	-iaCanonFire.cs: Description: Sert à tirer un obus (bullet) à partir du bout du canon de l'IA
                         ----------------------------------------------------------------------
                         Emplacement: Mettre sur la sortie du canon => tank.GetChild(1).GetChild(1)

------------------------------------------------------------------------------------------------------

	-createIA: Description: Sert à créer un IA en lui attachant les scripts et en définissant
                                son lvl
                   ----------------------------------------------------------------------
                   Emplacement: Mettre sur un GameObject (à décider)
