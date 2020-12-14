<h1> Cahier des charges</h1>

# 1. Titre
Covid propagation
# 2. Fonctionnalités
- Simulation
  - individus
    - uniques
    - Système immunitaire
      - organes
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
  - Modifications en temps réel
    - Virus
    - Populations
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
etc...), y introduire le covid et observer la propagation du virus. Il est possible d’affecter des mesures de
sécurité, tel que le port du masque ou la distanciation pour observer la possible réduction de la propagation.
De réel données sont utilisées pour le taut de propagation ou autres éléments similaires.
L'affichage permet de voir en temps réel la propagation du virus et permet de visualiser chaque individue
distinctement au besoin. Des graphiques sont aussi présent pour avoir une idée en chiffres de ce que signifie
l'affichage.


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
![Diagramme de classe initial](Classes.png)
<p style="text-align: center">Figure 4: Diagrame de classe initial</p>

# 12. Exigences

|Exigences|QQOQCCP|
|:-------:|:-----:|
|Modifier les paramètres|- Quoi ? Modifier les générals paramètres de la simulation<br>- Qui ? L'utilisateur<br>-Où ? Dans l'onglet paramètre de l'application<br>- Quand ? Avant de lancer une simulation<br>- Comment ? En sélectionnant les options proposée ou en inscrivant par exemple le nombre d'individus dans une population<br>- Combien ? <br>- Pourquoi ? Permettre à l'utilisateur de créer des simulations différentes<br>|

|Modifier la population|- Quoi ? Modifier les paramètres de la population comme par exemple sa résistance au virus<br>- Qui ? L'utilisateur<br>-Où ? Dans l'onglet paramètre de l'application<br>- Quand ? Avant de lancer une simulation et/ou lorsque la simulation est lancée pour certains paramètres<br>- Comment ? En sélectionnant les options proposée<br>- Combien ? <br>- Pourquoi ? Permettre à l'utilisateur de comparer différentes population en même temps et de la faire évoluer au besoin de la simulation<br>|

|Modifier le virus|- Quoi ? Modifier les paramètres tu virus comme par exemple sa dangerosité<br>- Qui ? L'utilisateur<br>-Où ? Dans l'onglet paramètre de l'application<br>- Quand ? Avant de lancer une simulation et/ou lorsque la simulation est lancée pour certains paramètres<br>- Comment ? En sélectionnant les options proposée<br>- Combien ? <br>- Pourquoi ? Pour permettre à l'utilisateur de personnaliser le virus et de voir les gestes barrières efficaces contre certains paternes<br>|

|Modifier l'affichage|- Quoi ? Modifier l'affichage comme par exemple quels graphiques seront affichés<br>- Qui ? L'utilisateur<br>-Où ? Dans l'onglet paramètre de l'application<br>- Quand ? Avant de lancer une simulation et/ou lorsque la simulation est lancée pour certains paramètres<br>- Comment ? En sélectionnant les options proposée<br>- Combien ? <br>- Pourquoi ? Pour permettre à l'utilisateur d'avoir un visuel intéressant ainsi que des données qui lui sont importantes<br>|

|Générer la population|- Quoi ? Générer la population avec les paramètres choisis par l'utilisateur<br>- Qui ? L'application<br>-Où ? En BackEnd et dans l'affichage, une fois que la génération est terminée<br>- Quand ? Lorsque l'utilisateur décide de lancer la simulation<br>- Comment ? En générant cahque individus demandé par l'utilisateur avec des valeurs aléatoires, tous en restant dans les limites définient par l'utilisateur<br>- Combien ? <br>- Pourquoi ? Car il est indispensable de simuler des individus pour une simulation de propagation de virus<br>|

|Générer le virus|- Quoi ? Générer le virus avec les paramètres choisis par l'utilisateur<br>- Qui ? L'application<br>-Où ? En BackEnd et dans l'affichage, une fois que la génération est terminée<br>- Quand ? Lorsque l'utilisateur décide de lancer la simulation<br>- Comment ? En assignant le virus à un ou plusieurs individus au démarage de la simulation<br>- Combien ? <br>- Pourquoi ? Car il est indispensable de simuler un virus dans une simulation de propagation de virus<br>|

|Afficher la simulation|- Quoi ? Afficher la population ainsi que le virus dans une carte et/ou dans les graphiques choisis par l'utilisateur<br>- Qui ? L'application<br>-Où ? Sur la page principale de l'application<br>- Quand ? Une fois que la simulation a fini d'être généré<br>- Comment ? En utilisant des graphiques et une carte permettant d'informer l'utilisateur sur le nombre d'infecté ou sur les données qu'il a choisi d'afficher<br>- Combien ? <br>- Pourquoi ? Car il est imporant d'avoir un retour en direct de ce qu'il se passe dans la simulation<br>|

|Le virus doit se propager|- Quoi ? Le virus se transmet d'un individu à un autre en fonction des paramètres choisis<br>- Qui ? L'application<br>-Où ? En backend ainsi que dans les graphique par extension<br>- Quand ? De façon aléatoir en fonction des paramètres choisis par l'utilisateur une fois que la simulation est lancée<br>- Comment ? La méthode est encore incertaine<br>- Combien ? <br>- Pourquoi ? Car il est indispensable de simuler la propagation d'un virus dans une simulation de propagation de virus<br>|

|Les individus sont affecté par le virus|- Quoi ? Les individus ont des symptômes, meurent, où se rétablissent dû au virus<br>- Qui ? L'application<br>-Où ? En backend et frontEnd<br>- Quand ? Lorsque la simulation est lancée. Arrive de façon aléatoir en fonction des paramètres de l'utilisateur<br>- Comment ? En réduisant leur santé d'une façon ou d'une autre ou simplement en supprimant l'entité infecté lorsqu'elle "meurt"<br>- Combien ? <br>- Pourquoi ? Car certains virus peuvent modifier le comportement ou l'état de santé d'une personne, il est important de le reproduire<br>|

|Les données sont sauvegardée dans la BDD|- Quoi ? Les données résultantes de la simulation tel que le nombre de rétablis sont sauvegardé dans une base de donnée local<br>- Qui ? La BDD<br>-Où ? <br>- Quand ? Lorsqu'une simulation se termine<br>- Comment ? En récupérant les données résultantes de la simulation et en les sauvegardant dans une Base de données local<br>- Combien ? <br>- Pourquoi ? Car certaines données peuvent être utilent et il est important de garder une trace de celle-ci<br>|

|Les hôpitaux se remplissent|- Quoi ? Les individus infecté sont traité dans les hôpitaux<br>- Qui ? L'application<br>-Où ? Backend, frontend<br>- Quand ? Lorsque des maladent souffrent de certains symptoms<br>- Comment ? Simplement en assignant certains malade aux hôpitaux<br>- Combien ? <br>- Pourquoi ? Car c'est une variable importante qui peut permettre à rendre le résultat plus réaliste<br>|

|Les hôpitaux ont une limite|- Quoi ? Les hôpitaux se remplissent jusqu'à une limite maximal et arrêtent de prendre des patients<br>- Qui ? L'application<br>-Où ? Backend, frontend<br>- Quand ? Lorsque la limite d'individus est trop grande dans un hôpital (valeur fixe)<br>- Comment ? Simplemen en donnant une valeur maximale de patient par hôpital<br>- Combien ? <br>- Pourquoi ? Car les hôpitaux ne peuvent prendre un nombre infinis de patients<br>|

# 13. Livrables
- Mind Map
- Planning
- Rapport de projet
- Manuel utilisateur
- Journal de travail ou LogBook
- Résumé / Abstract

