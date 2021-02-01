<h1> Cahier des charges</h1>

# 1. Titre
Covid propagation
# 2. Fonctionnalités
- Simulation
  - Population
    - Mesures
    - Hôpitaux
    - individus
      - Patient à risque
      - Âge
      - Décès dû au virus
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
- Carte
  - Région
    - Population unique
    - Hôpitaux et autres paramètres uniques
- Graphiques
  - Informations sur la population
    - Décès
    - Rétablissements
    - Infecté
    - Sains
  - Informations sur le virus
    - Dangerosité

## 2.1. Fonctionnalités aditionnels
- Carte mondiale
  - Transports
    - Avions
    - Bateaux
    - Aéroports et ports réel

# 3. Matériel et logiciels
- Pc techniciens
- Visual studio 2019
- Une connexion internet
- Github

# 4. Prérequis
- C#
- Visual studio 2019
- Dilemne du prisonnier

# 5. Descriptif complet du projet
## 5.1. Méthodologie
Scrum

## 5.2. Description de l’application
Simuler un grand nombre de personnes possédant tous des variables différentes (âge, résistance immunitaire,
etc...), y introduire le virus et observer sa propagation. Il est possible d’affecter des mesures de sécurité, tel que le port du masque ou la distanciation pour observer la possible réduction de la propagation.
L'affichage permet de voir en temps réel la propagation du virus et permet de visualiser chaque individu distinctement au besoin. Des graphiques sont aussi présent pour avoir une idée en chiffres de ce que signifie
l'affichage.
<br><br>
L'utilisateur a accès à de nombreux paramètre permettant de modifier la poplulation d'individus.
<br><br>
Le virus peut aussi être modifié par l'utilisateur. Son niveau de létalité ainsi que son ou ses moyens de propagations peuvent être modifié.
<br><br>
L'affichage est presque entièrement personnalisé par l'utilisateur. Il décide quel graphique ou carte est affiché. La carte peut contenir des régions. Ces régions possèdeent une population et change de couleur en fonction de leurs états (% d'infecté, de rétablis, etc...). Les graphiques eux sont des graphiques en courbes permettant l'affichage de plusieurs données. Leurs données sont totalement personalisables. Il peuvent afficher les données de toutes la populations, afficher les données de différentes populations, comparer celles-ci, visualiser l'avancement du virus, etc...

# 6. Protocols de tests
Ce projet étant en c#, je vais utiliser les tests unitaires intégré dans visual studio.<br>
Les tests unitaires ne garantissant pas qu'il n'y ai aucun bug dans l'application, je vais créer des scénarios que je testerais avant et après chaque implémentation de fonctionnalités. Ces scénarios auront pour but de couvrir un maximum de possiblités pour éviter l'appartitions de bug dû à une modification du code ou l'ajout d'une fonctionnalité. Ils permettent aussi de trouver d'éventuels des problèmes d'ergonomie en me plongeant à la place d'un utilisateur.

# 7. Persona
## 7.1. Utilisateur experimenté
![Perona experimenté](Persona_Ashley.png)
<p style="text-align: center">Figure 1: Persona experimenté</p>

## 7.2. Utilisateur inexpérimenté
![Perona inexpérimenté](Persona_Kanan.png)
<p style="text-align: center">Figure 2: Persona inexpérimenté</p>

# 8. User stories
## 8.1. Ashley
**En tant que** Ashley<br>
**Je veux** comparer différentes situations avec différente personnes en prenant des mesures identiques<br>
**Afin de** pouvoir observer les différences et déterminer quelle mesures est éfficace dans quelle situation.<br>

**scénarios**
Je crée sans soucis une situtations à l'aide de l'application. Pour ce faire, j'entre différents paramètres, tel que le nombre de personnes, les mesures prisent pour limiter la transmissions ainsi que d'autres paramètres. <br>
J'obsèrve la simulation et prend note des résultats.<br> 
Une fois terminée, j'en lance une autres avec certains paramètres différents et prends note des résultats.<br>
Je compare les résultats avec la simulation précédente et effectue ma conclusion.

## 8.2. Kanan
**En tant que** Kanan<br>
**Je veux** vérifier l'éfficacité de différentes mesures prisent pour éviter la propagation du covid<br>
**Afin de** afin de me donner une idée concrète et visuel de l'éfficacité de ses mesures.<br>

**scénarios**
Je lance l'application et cherche à créer une simulation. Une fois trouvé, je peux voir les mesures qui aparaissent clairement, d'autres paramètres sont disponibles mais je n'y touches pas.<br>
Une fois la simulation lancée, je vois un message m'indiquant que celle-ci commence.<br>
Des aides sont disponibles me permettant de comprendre les données qui sont affichées. <br>
Après avoir terminé cette simulation, j'en lance une autre en désactivant les mesures. <br>
Je relance la simulation et observe la différence entre les deux simulations. <br>

# 9. Diagramme d'activité
![Diagramme d'activité](DiagrammeDactivite.png)
<p style="text-align: center">Figure 3: Diagramme d'activité</p>

# 10. Planning
https://docs.google.com/spreadsheets/d/1tSpIbcDVvGnzMhEN71UDwPOxEy0oapQSSbxzjqXt3RA/edit?usp=sharing

# 11. Diagramme de classe initial
![Diagramme de classe initial](InitialClassDiagram.png)
<p style="text-align: center">Figure 4: Diagrame de classe initial</p>