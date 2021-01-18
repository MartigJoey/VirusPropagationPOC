<h1> Cahier des charges</h1>

# 1. Titre
Vius propagation
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
etc...), y introduire le virus et observer sa propagation. Il est possible d’affecter des mesures de sécurité, tel que le port du masque ou la distanciation pour observer la possible réduction de la propagation.
De réel données sont utilisées pour le taut de propagation ou autres éléments similaires.
L'affichage permet de voir en temps réel la propagation du virus et permet de visualiser chaque individu distinctement au besoin. Des graphiques sont aussi présent pour avoir une idée en chiffres de ce que signifie
l'affichage.
<br><br>
L'utilisateur a accès à de nombreux paramètre permettant de modifier la poplulation d'individus. Il peut créer plusieurs populations différentes dans la même simulation ayant des paramètres personnalisés ou identiques. Il est possible que les populations aient des contacts, il est aussi possible de les isolés. Les mesures contre le virus sont liées à la population et peuvent donc elles-aussi varié en fonction de la population.
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

# Preuve de concept
## matériel
Aucun nécessaire en plus de celui déjà présent dans les postes techniciens.
## Technologie
### Grand nombre d'entités
[Microsoft ASP.NET](https://docs.microsoft.com/en-us/aspnet/web-forms/overview/older-versions-getting-started/continuing-with-ef/maximizing-performance-with-the-entity-framework-in-an-asp-net-web-application)

### Propagation
En couplant un grand nombre d'entité avec une propagation liées à ces individus, je crains que les performances soient très impactées par la façon dont j'ai imaginé la propagation.
Je penses donner à chaque entités un position x et y qui servira à l'affichage et surtout à déterminer qui peut être impacté par le virus à proximité si l'entité est contaminée. La propagation en elle-même, sera donc basée sur la position des entités.

Une autre idée que j'ai, serait que la distance réel ne soit pas lié à la propagation mais uniquement aux pourcentages de chances. Une entité éloignée du virus pourrait donc l'attraper si elle est mal protégée. Le groupe d'entités posséderait donc une chance de contamination générale qui pourrait toucher n'importe quel entité. Cette chance de contamination varierait en fonction du nombre d'infecté ou du niveau d'infectiosité du virus. C'est moins précis et réaliste mais permettrait de simuler un plus grand nombre d'entité à la fois.

SQL
[https://visualstudiomagazine.com/articles/2018/03/19/dapper-orm.aspx](https://visualstudiomagazine.com/articles/2018/03/19/dapper-orm.aspx)

### Affichage

Utilisation du framework LiveCharts.
[Graphiques](https://lvcharts.net/App/notfound)

### Carte et graphiques

Concernant les graphiques et les cartes, j'utilise le packet NuGet LiveCharts. Il permet de créer des graphiques en courbes dynamique ainsi que de générer des cartes à l'aide de fichier xml. Les régions des cartes sont cliquables et personnalisable. Grâce à cette extension, je peux me concentrer sur le fond en laisser la form et le graphisme de côté. Ce paquet NuGet utilise le .Net Framework 4.5.

les données des cartes peuvent être téléchargée depuis ce git: <br>
[Maps.xml](https://github.com/Live-Charts/Live-Maps/tree/master/Maps)
![Maps.xml](Maquette.png)

# 12. Exigences

|Exigences|QQOQCCP|
|:-------:|:-----:|
|Modifier les paramètres|- **`Quoi`** ? Modifier les générals paramètres de la simulation<br>- **`Qui`** ? L'utilisateur<br>- **`Où`** ? Dans l'onglet paramètre de l'application<br>- **`Quand`** ? Avant de lancer une simulation<br>- **`Comment`** ? En sélectionnant les options proposée ou en inscrivant par exemple le nombre d'individus dans une population<br>- **`Combien`** ? <br>- **`Pourquoi`** ? Permettre à l'utilisateur de créer des simulations différentes<br>|
|Modifier la population|- **`Quoi`** ? Modifier les paramètres de la population comme par exemple sa résistance au virus<br>- **`Qui`** ? L'utilisateur<br>- **`Où`** ? Dans l'onglet paramètre de l'application<br>- **`Quand`** ? Avant de lancer une simulation et/ou lorsque la simulation est lancée pour certains paramètres<br>- **`Comment`** ? En sélectionnant les options proposée<br>- **`Combien`** ? <br>- **`Pourquoi`** ? Permettre à l'utilisateur de comparer différentes population en même temps et de la faire évoluer au besoin de la simulation<br>|
|Modifier le virus|- **`Quoi`** ? Modifier les paramètres tu virus comme par exemple sa dangerosité<br>- **`Qui`** ? L'utilisateur<br>- **`Où`** ? Dans l'onglet paramètre de l'application<br>- **`Quand`** ? Avant de lancer une simulation et/ou lorsque la simulation est lancée pour certains paramètres<br>- **`Comment`** ? En sélectionnant les options proposée<br>- **`Combien`** ? <br>- **`Pourquoi`** ? Pour permettre à l'utilisateur de personnaliser le virus et de voir les gestes barrières efficaces contre certains paternes<br>|
|Modifier l'affichage|- **`Quoi`** ? Modifier l'affichage comme par exemple quels graphiques seront affichés<br>- **`Qui`** ? L'utilisateur<br>- **`Où`** ? Dans l'onglet paramètre de l'application<br>- **`Quand`** ? Avant de lancer une simulation et/ou lorsque la simulation est lancée pour certains paramètres<br>- **`Comment`** ? En sélectionnant les options proposée<br>- **`Combien`** ? <br>- **`Pourquoi`** ? Pour permettre à l'utilisateur d'avoir un visuel intéressant ainsi que des données qui lui sont importantes<br>|
|Générer la population|- **`Quoi`** ? Générer la population avec les paramètres choisis par l'utilisateur<br>- **`Qui`** ? L'application<br>- **`Où`** ? En BackEnd et dans l'affichage, une fois que la génération est terminée<br>- **`Quand`** ? Lorsque l'utilisateur décide de lancer la simulation<br>- **`Comment`** ? En générant cahque individus demandé par l'utilisateur avec des valeurs aléatoires, tous en restant dans les limites définient par l'utilisateur<br>- **`Combien`** ? <br>- **`Pourquoi`** ? Car il est indispensable de simuler des individus pour une simulation de propagation de virus<br>|
|Générer le virus|- **`Quoi`** ? Générer le virus avec les paramètres choisis par l'utilisateur<br>- **`Qui`** ? L'application<br>- **`Où`** ? En BackEnd et dans l'affichage, une fois que la génération est terminée<br>- **`Quand`** ? Lorsque l'utilisateur décide de lancer la simulation<br>- **`Comment`** ? En assignant le virus à un ou plusieurs individus au démarage de la simulation<br>- **`Combien`** ? <br>- **`Pourquoi`** ? Car il est indispensable de simuler un virus dans une simulation de propagation de virus<br>|
|Afficher la simulation|- **`Quoi`** ? Afficher la population ainsi que le virus dans une carte et/ou dans les graphiques choisis par l'utilisateur<br>- **`Qui`** ? L'application<br>- **`Où`** ? Sur la page principale de l'application<br>- **`Quand`** ? Une fois que la simulation a fini d'être généré<br>- **`Comment`** ? En utilisant des graphiques et une carte permettant d'informer l'utilisateur sur le nombre d'infecté ou sur les données qu'il a choisi d'afficher<br>- **`Combien`** ? <br>- **`Pourquoi`** ? Car il est imporant d'avoir un retour en direct de ce qu'il se passe dans la simulation<br>|
|Le virus doit se propager|- **`Quoi`** ? Le virus se transmet d'un individu à un autre en fonction des paramètres choisis<br>- **`Qui`** ? L'application<br>- **`Où`** ? En backend ainsi que dans les graphique par extension<br>- **`Quand`** ? De façon aléatoir en fonction des paramètres choisis par l'utilisateur une fois que la simulation est lancée<br>- **`Comment`** ? La méthode est encore incertaine<br>- **`Combien`** ? <br>- **`Pourquoi`** ? Car il est indispensable de simuler la propagation d'un virus dans une simulation de propagation de virus<br>|
|Les individus sont affecté par le virus|- **`Quoi`** ? Les individus ont des symptômes, meurent, où se rétablissent dû au virus<br>- **`Qui`** ? L'application<br>- **`Où`** ? En backend et frontEnd<br>- **`Quand`** ? Lorsque la simulation est lancée. Arrive de façon aléatoir en fonction des paramètres de l'utilisateur<br>- **`Comment`** ? En réduisant leur santé d'une façon ou d'une autre ou simplement en supprimant l'entité infecté lorsqu'elle "meurt"<br>- **`Combien`** ? <br>- **`Pourquoi`** ? Car certains virus peuvent modifier le comportement ou l'état de santé d'une personne, il est important de le reproduire<br>|
|Les données sont sauvegardée dans la BDD|- **`Quoi`** ? Les données résultantes de la simulation tel que le nombre de rétablis sont sauvegardé dans une base de donnée local<br>- **`Qui`** ? La BDD<br>- **`Où`** ? <br>- **`Quand`** ? Lorsqu'une simulation se termine<br>- **`Comment`** ? En récupérant les données résultantes de la simulation et en les sauvegardant dans une Base de données local<br>- **`Combien`** ? <br>- **`Pourquoi`** ? Car certaines données peuvent être utilent et il est important de garder une trace de celle-ci<br>|
|Les hôpitaux se remplissent|- **`Quoi`** ? Les individus infecté sont traité dans les hôpitaux<br>- **`Qui`** ? L'application<br>- **`Où`** ? Backend, frontend<br>- **`Quand`** ? Lorsque des maladent souffrent de certains symptoms<br>- **`Comment`** ? Simplement en assignant certains malade aux hôpitaux<br>- **`Combien`** ? <br>- **`Pourquoi`** ? Car c'est une variable importante qui peut permettre à rendre le résultat plus réaliste<br>|
|Les hôpitaux ont une limite|- **`Quoi`** ? Les hôpitaux se remplissent jusqu'à une limite maximal et arrêtent de prendre des patients<br>- **`Qui`** ? L'application<br>- **`Où`** ? Backend, frontend<br>- **`Quand`** ? Lorsque la limite d'individus est trop grande dans un hôpital (valeur fixe)<br>- **`Comment`** ? Simplemen en donnant une valeur maximale de patient par hôpital<br>- **`Combien`** ? <br>- **`Pourquoi`** ? Car les hôpitaux ne peuvent prendre un nombre infinis de patients<br>|

<h1>Graphique radar pour le virus</h1>
https://www.google.com/search?q=simulation+individu-centr%C3%A9&safe=strict&hl=fr&sxsrf=ALeKk02i1JrfYG4BydYqWTTmyPzPVs2aHg:1608542929961&source=lnms&sa=X&ved=0ahUKEwiiyciv4d7tAhVR26QKHaOcBOIQ_AUICigA&biw=1920&bih=969&dpr=1

# Interactions
## Menu principal
- Affiche une préview de l'affichage de la simulation
- Btn Paramètres
  - Population
    - Remplace l'affichage actuel se situant à droite pour afficher les paramètres de la population
  - Virus
    - Remplace l'affichage actuel se situant à droite pour afficher les paramètres du virus
  - Affichage
    - Remplace l'affichage actuel se situant à droite pour afficher les paramètres de l'affichage
- Btn Lancer la simulation
  - Change l'affichage de la totalité de l'application, Affiche une barre de chargement indiquant l'état de création de la simulation.

## Population
Affiche une page avec les paramètres suivant :
- Changer le nom de la population
- Ajouter une population
  - Ajoute une population ayant les paramètres par défaut à la liste de populations et l'affiche
- Supprimer une population
  - Supprime la population sélectionnée et affiche la précédente
- Copier les paramètres
  - Copie les paramètres de la population actuelle en mémoire (Ou simplement un index)
- Coller les paramètres
  - Colle les paramètres copié dans la population sélectionnée (Ou clone la population copiée)
- Appliquer les paramètres à toutes les populations
  - Applique les paramètres de la population actuelle à toutes les populations crées

- Moyenne d'âge de la population
  - Permet de modifier la moyenne d'âge de la population de 1 à ~100
  - Permet de délimiter une limite d'âge maximal et minimal
  - Il peut y avoir plusieurs moyennes en choisissant quelle moyenne correspond à quel pourcentage de la population
  - Il est possible de le laisser en aléatoire
- Maladies impactant la population
  - Permet de sélectionner un vaste choix de maladies et d'y indiquer le nombre de la population "infectée"
  - Elles ne se propagent pas
- Nombre d'individus
  - Le nombre d'individus simulé dans une population
  - La limite n'est pas définie par le programme
  - L'utilisateur connaît les limites de sa machine
- Mesures
  - Permet de sélectionner plusieurs mesures
  - Les mesures ont un pourcentage d'éfficacité
  - Permet de réduire les chance de propagation du virus
    - Affecte différement le virus en fonction de la mesure
    - Pourrait totalement contrer un virus
  - Peut être modifier par l'utilisateur jusqu'à un niveau de 100% de protection
  - Appliquer uniquement sur certaines parties de la population
    - Infectés
    - Sains
    - À risques
- Hôpitaux
  - Comme pour les populations, il y a plusieurs hôpitaux avec les options :
    - Copier
    - Coller
    - Appliquer sur tout
  - Permet de modifier le nombre d'hôpitaux
  - Permet de mofifier le nombre de places
  - Stabilise les individus y étant admis
    - Réduit leurs chances de décès
  - Nécessite du personnel qui peut être infecté pour fonctionner
    - Mesures du personnel : 
      - Permet de sélectionner plusieurs mesures
      - Les mesures ont un pourcentage d'éfficacité
      - Permet de réduire les chance de propagation du virus
        - Affecte différement le virus en fonction de la mesure
        - Pourrait totalement contrer un virus
      - Peut être modifier par l'utilisateur jusqu'à un niveau de 100% de protection
- Btn annuler
  - Annule les modification faite à la population
  - Réaffiche les données précédemment affichée
- Btn sauvegarder
  - Sauvegarde les paramètres choisis par l'utilisateur
## Virus
[Moyen de transmissions](https://www.virologie-uclouvain.be/fr/chapitres/transmission-epidemiologie/transmission-des-virus)

Affiche une page avec les paramètres suivant :
- Effet sur le corps
  - Premet de sélectionner quels sont les effets du virus
  - Permet de modifier le pourcentage de propagation en fonction du symptôme (toux)
  - Les effets listé auront un effet sur la propagation
  - Les effets impactant le corps mais qui n'affectent pas la propagation, ou la vie de l'individus sont généralisés en laissant l'individu dans son foyer (réduction de chance de transmissions)
  - Les effets mortels nécessitant une hospitalisation 
- Moyens de transmissions
  - Permet à l'utilisateur de choisir quel mode de transmission le virus utilise ainsi que leur efficacité
  - Sont impacté par les symptômes (en incrémentant l'efficacité)
  - Sont impacté par les mesures (en décrémentant l'efficacité)
- Durée
  - Permet de définir la durée durant laquel le virus prend effet
- Asymptomatique
  - Permet de définir si oui ou non il y a des asymptomatiques
  - Permet de définir le pourcentage d'asymptomatiques

## Affichage
Affiche une page avec les paramètres suivant :
- Carte
  - Permet de sélectionner ou d'importer une carte au format xml
  - La carte s'affiche
  - Les régions s'affichent
    - Attributions des populations à chaque régions
  - Une seule par simulation
- Graphiques
  - Permet de sélectionner différents styles de graphiques à afficher
    - Permet de sélectionner une donnée au choix en X et en Y
    - Un exemple du graphique avec les données est affiché à côté de la barre de sélection
  - Plusieurs graphiques possibles à sélectionner

## Simulation
Affiche une page :
- Affichage d'une barre de chargement lors de la génération de la simulation
  - Évolue en fonction du nombre d'individus créé
- Affiche les graphiques sélectionné ainsi que la carte
  - Onglets permettant de sélectionner quel graphique afficher
  - Possibilité d'afficher jusqu'à 4 graphiques sur le même onglet
- S'actualise toutes les secondes
- Carte
  - La couleur des régions change en fonction du nombre d'infecté
  - En cliquant sur une région, une popup s'affiche
    - Nombre d'individus
    - Nombre d'infectés
    - Nombre de rétablis
    - État général
      - Hôpitaux
      - Mesures
- Modification des paramètres
  - Presque tous les parampètres sont accessibles en temps réel
    - les modification d'individus ne sont pas possible en temps réel
    - Ils sont modifiables mais nécessite un rechargement de la simulation
  - pause de la simulation

# 13. Livrables
- Mind Map
- Planning
- Rapport de projet
- Manuel utilisateur
- Journal de travail ou LogBook
- Résumé / Abstract

