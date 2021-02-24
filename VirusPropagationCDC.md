<h1> Cahier des charges</h1>

# 1. `Titre`
Virus propagation
# 2. `Fonctionnalités`
- Simulation
  - Population
    - Mesures
    - Hôpitaux
    - individus
      - Patient à risque
      - Âge
      - Décès dû au virus
      - Famille
      - Cercle d'amis
      - "Vie" *`Calendrier`*
  - Virus
    - propagation
    - effets sur les individus
      - De “Aucun”
      - À “Grave”
  - Hôpitaux
    - Places limitée
  - Mesure de sécuritées
    - Port du masque
    - Quarantaine
    - Confinement global
    - Distanciation
- Graphiques
  - Informations sur la population
    - Décès
    - Rétablissements
    - Infecté
    - Sains
  - Informations sur le virus
    - Dangerosité

## 2.1. `Fonctionnalités aditionnels`
- Carte mondiale
  - Transports
    - Avions
    - Bateaux
    - Aéroports et ports réel

# 3. `Matériel et logiciels`
- Pc techniciens
- Visual studio 2019
- Une connexion internet
- Github

# 4. `Prérequis`
- C#
- Visual studio 2019
- Dilemne du prisonnier

# 5. `Descriptif complet du projet`
## 5.1. `Méthodologie`
Scrum

## 5.2. `Description de l’application`
Simuler un grand nombre de personnes possédant toutes des variables différentes (âge, résistance immunitaire,
etc...), y introduire le virus et observer sa propagation. Il est possible d’affecter des mesures de sécurité, tel que le port du masque ou la distanciation pour observer la possible réduction de la propagation.
L'affichage permet de voir en temps réel la propagation du virus et permet de visualiser chaque individu distinctement au besoin. Des graphiques sont aussi présents pour avoir une idée en chiffres de ce que signifie
l'affichage.

### 5.2.1. `Graphique`
Les données des graphiques sont choisis par l'utilisateur et donc personnalisable. Plusieurs graphiques peuvent être affiché en même temps. Leur position est définie par l'utilisateur au sein de la page de l'application.<br>
L'interface graphique est fournie par [LiveChart](https://lvcharts.net/App/examples/wpf/start). Les données sont directement fournies par l'application ainsi que les échelles de grandeurs qui sont ajustée automatiquement.
Les graphiques à courbes et en forme camembert sont disponibles.

### 5.2.2. `propagation`
La propagation se fait à l'aide de calcul et de différente variables. 1000 m^2 contenant 10 à l'intérieur aura de faible chance de transmettre le virus. Le même nombre de personnes dans un espace clos de 10 m^2 aura des résultats totalement différents.<br> 
La température est prise est compte ainsi que les mesures tel que le masque. Le masque réduit les chances de transmettres le virus. La température elle fait varier la durée de vie du virus à l'extérieur d'un hôte.
La complexité de ce type de calcul étant d'une difficulté largement supérieur aux compétences aquises en temps que technicien, je me base sur cette fiche excel réalisée par des professionel. Elle est très bien documentée et sourcée. 

[Fiche excel](https://docs.google.com/spreadsheets/d/1ZWG4LslRBUjMC00Rsi65TKmfVJyzVUf2)

### 5.2.3. `Population`
La population est constituée d'objets C# généré partiellement aléatoirement en fonction des paramètre de la simulation. Ils informent la simulation en cas de changement d'état (sain, infecté, etc...). Des itérations sont faites dans la simulation pour calculer si un individu est infecté ou non durant le temps écoulé. Il a un planning simple à suivre dans sa journée qui peut être consitituée de par exemple:
- Être dans son habitation
- Prendre le bus
- Travailler
- Prendre le bus
- Faire les courses dans un supermarché
- Prendre le bus
- Et finalement rentrer chez sois

Se planning est différent en fonction des individus même si vaguement le même. Durant sa journée, il croisera d'autre individu et à chaque itération il aura des chances d'être infecté si des personnes aux alentours le sont. En fonction du lieu il rencontrera des personnes différentes, parfois les même comme dans son travail où ses collègues sont fixes. Dans le bus des variations seront possibles. Son cercle d'amis ainsi que sa famille lorsqu'il se trouve dans son habitation seront les individus risquant de le contaminer.

# 6. `Protocols de tests`
Ce projet étant en c#, je vais utiliser les tests unitaires intégré dans visual studio.<br>
Les tests unitaires ne garantissant pas qu'il n'y ai aucun bug dans l'application, je vais créer des scénarios que je testerais avant et après chaque implémentation de fonctionnalités. Ces scénarios auront pour but de couvrir un maximum de possiblités pour éviter l'appartitions de bug dû à une modification du code ou l'ajout d'une fonctionnalité. Ils permettent aussi de trouver d'éventuels des problèmes d'ergonomie en me plongeant à la place d'un utilisateur.

# 7. `Persona`
## 7.1. `Utilisateur experimenté`
![Perona experimenté](Persona_Ashley.png)
<p style="text-align: center">Figure 1: Persona experimenté</p>

## 7.2. `Utilisateur inexpérimenté`
![Perona inexpérimenté](Persona_Kanan.png)
<p style="text-align: center">Figure 2: Persona inexpérimenté</p>

# 8. `User stories`
## 8.1. `Ashley`
**En tant que** Ashley<br>
**Je veux** comparer différentes situations avec différente personnes en prenant des mesures identiques<br>
**Afin de** pouvoir observer les différences et déterminer quelle mesures est éfficace dans quelle situation.<br>

**scénarios**
Je crée sans soucis une situtations à l'aide de l'application. Pour ce faire, j'entre différents paramètres, tel que le nombre de personnes, les mesures prisent pour limiter la transmissions ainsi que d'autres paramètres. <br>
J'obsèrve la simulation et prend note des résultats.<br> 
Une fois terminée, j'en lance une autres avec certains paramètres différents et prends note des résultats.<br>
Je compare les résultats avec la simulation précédente et effectue ma conclusion.

## 8.2. `Kanan`
**En tant que** Kanan<br>
**Je veux** vérifier l'éfficacité de différentes mesures prisent pour éviter la propagation du covid<br>
**Afin de** afin de me donner une idée concrète et visuel de l'éfficacité de ses mesures.<br>

**scénarios**
Je lance l'application et cherche à créer une simulation. Une fois trouvé, je peux voir les mesures qui aparaissent clairement, d'autres paramètres sont disponibles mais je n'y touches pas.<br>
Une fois la simulation lancée, je vois un message m'indiquant que celle-ci commence.<br>
Des aides sont disponibles me permettant de comprendre les données qui sont affichées. <br>
Après avoir terminé cette simulation, j'en lance une autre en désactivant les mesures. <br>
Je relance la simulation et observe la différence entre les deux simulations. <br>

# 9. `Diagramme d'activité`
![Diagramme d'activité](DiagrammeDactivite.png)
<p style="text-align: center">Figure 3: Diagramme d'activité</p>

# 10. `Planning`
https://docs.google.com/spreadsheets/d/1tSpIbcDVvGnzMhEN71UDwPOxEy0oapQSSbxzjqXt3RA/edit?usp=sharing

# 11. `Diagramme de classe initial`
![Diagramme de classe initial](InitialClassDiagram.png)
<p style="text-align: center">Figure 4: Diagrame de classe initial</p>

# 12. `Interactions`
## 12.1. `Menu principal`
- Affiche un preview de l'affichage de la simulation
- Btn Paramètres
  - Population
    - Remplace l'affichage actuel se situant à droite pour afficher les paramètres de la population
  - Virus
    - Remplace l'affichage actuel se situant à droite pour afficher les paramètres du virus
  - Affichage
    - Remplace l'affichage actuel se situant à droite pour afficher les paramètres de l'affichage
- Btn lancer la simulation
  - Change l'affichage de la totalité de l'application, affiche une barre de chargement indiquant l'état de création de la simulation.

## 12.2. `Population`
Affiche une page avec les paramètres suivant :
- Écoles / lieux de travail
  - Différentes selon l'âge
  - Zone de transmission
- Familles / Cercles d'amis
  - Transmission
- Moyenne d'âge de la population
  - Permet de modifier la moyenne d'âge de la population de 1 à ~100
  - Permet de délimiter une limite d'âge maximal et minimal
  - Il est possible de le laisser par défaut
- Nombre d'individus
  - Le nombre d'individus simulé dans une population
  - La limite n'est pas définie par le programme
  - L'utilisateur connaît les limites de sa machine
- Mesures
  - Permet de sélectionner plusieurs mesures
  - Les mesures ont un pourcentage d'efficacité
  - Permet de réduire les chances de propagation du virus
    - Affecte différemment le virus en fonction de la mesure
    - Pourrait totalement contrer un virus
  - Peut être modifier par l'utilisateur jusqu'à un niveau de 100% de protection
  - Valeur par défaut défini par des études sur le sujet
  - Appliquer uniquement sur certaines parties de la population
    - Infectés
    - Sains
    - À risques
- Cercle social
  - Ami
  - Famille
  - Collègues
  - ...
  - Transmissions accru
  - Rencontres inclussent dans le planning journalier des individus
- Hôpitaux
  - Il y a plusieurs hôpitaux avec les options :
    - Copier
    - Coller
    - Appliquer sur tout
  - Permet de modifier le nombre d'hôpitaux
  - Permet de modifier le nombre de places
  - Stabilise les individus y étant admis
    - Réduit leurs chances de décès
  - Nécessite du personnel qui peut être infecté pour fonctionner
    - Mesures du personnel : 
      - Permet de sélectionner plusieurs mesures
      - Les mesures ont un pourcentage d'efficacité
      - Permet de réduire les chances de propagation du virus
        - Affecte différemment le virus en fonction de la mesure
        - Pourrait totalement contrer un virus
      - Peut être modifier par l'utilisateur jusqu'à un niveau de 100% de protection
- Btn annuler
  - Annule les modifications faites à l'hôpital
  - Réaffiche les données précédemment affichées
- Btn sauvegarder
  - Sauvegarde les paramètres choisis par l'utilisateur
## 12.3. `Virus`
Affiche une page avec les paramètres suivant :
- Effet sur le corps
  - Permet de modifier le pourcentage de propagation en fonction du symptôme (toux)
  - Les effets mortels nécessitant une hospitalisation 
- Moyens de transmissions
  - Sont impacté par les symptômes (en incrémentant l'efficacité)
  - Sont impacté par les mesures (en décrémentant l'efficacité)
- Durée
  - Permet de définir la durée durant laquelle le virus prend effet
- Asymptomatique
  - Permet de définir si oui ou non il y a des asymptomatiques
  - Permet de définir le pourcentage d'asymptomatiques

## 12.4. `Affichage`
Affiche une page avec les paramètres suivant :
- Graphiques
  - Permet de sélectionner différents styles de graphiques à afficher
    - Permet de sélectionner une donnée au choix en X et en Y
    - Un exemple du graphique avec les données est affiché à côté de la barre de sélection
  - Plusieurs graphiques possibles à sélectionner
- Affichage d'une "carte" permettant une visualisation plus simple

## 12.5. `Simulation`
Affiche une page :
- Affichage d'une barre de chargement lors de la génération de la simulation
  - Évolue en fonction du nombre d'individus créé
- Affiche les graphiques sélectionnés
  - Onglets permettant de sélectionner quel graphique affiché
  - Possibilité d'afficher jusqu'à 4 graphiques sur le même onglet
- S'actualise toutes les secondes (environ)
