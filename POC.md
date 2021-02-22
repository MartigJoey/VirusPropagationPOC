# Preuve de concept
## matériel
Aucun nécessaire en plus de celui déjà présent dans les postes techniciens.
## Technologie
### Grand nombre d'entités
[Microsoft ASP.NET](https://docs.microsoft.com/en-us/aspnet/web-forms/overview/older-versions-getting-started/continuing-with-ef/maximizing-performance-with-the-entity-framework-in-an-asp-net-web-application)

### Propagation

La propagation se fera entre individus se trouvant dans un même lieu. Suivant les chances d'infection qui seront définient par le virus, les mesures ainsi que par le nombre d'individus infecté dans un espace, les chances d'infection diminueront ou augmenteront à chaque itérations. 

~~SQL
[https://visualstudiomagazine.com/articles/2018/03/19/dapper-orm.aspx](https://visualstudiomagazine.com/articles/2018/03/19/dapper-orm.aspx)~~

Possible source de données <br>
~~[Map](https://covid19risk.biosci.gatech.edu/)~~

[Simulation de molécules](https://link.springer.com/article/10.1007/s00466-020-01881-7)

[Propagation niveau de pays](https://www.sciencedirect.com/science/article/pii/S2468042720300087)

[Efficacité masque](https://aip.scitation.org/doi/10.1063/10.0002919)
[-Source](https://aip.scitation.org/doi/10.1063/5.0035414)
<br>
<br>
Source des données mathématique concernant la propagation :

[Simulation mathématique (excel) de différent lieux et paramétrable](https://drive.google.com/file/d/1ZWG4LslRBUjMC00Rsi65TKmfVJyzVUf2/view?usp=sharing)
### Difficultées

#### Structure
La plus grosse difficulté du projet est d'après moi la structure de la simulation. Créer une structure cohérente et suffisamment complexe pour la simulation.

#### Calculer le nombre de reproductions

Calculer de réelles données telles que le nombre de reproductions et recevoir des chiffres cohérents semble aussi être une grosse difficulté.
[Re](https://www.covid19.admin.ch/fr/repro/val)

#### Interface graphique

Les graphiques en eux même ne me semblent pas être un problème vu la simplicité d'utilisation, par contre, pour avoir un affichage permettant de réellement visualiser les individus ainsi que les lieus. Réaliser une version bêta ne me semble pas compliqué, mais avoir quelque chose de cohérent dans la manière de se déplacer me semble impossible dans le temps imparti par le travail de diplôme.

![Interface utilisateur](MaquetteDesign.png)

### Affichage

Utilisation du framework LiveCharts.
[Graphiques](https://lvcharts.net/App/examples/wpf/start)

Graphique radar pour le virus:

[Radar](https://www.google.com/search?q=graphique+radar&tbm=isch&ved=2ahUKEwiBrPbShf3uAhVBexoKHXafBQQQ2-cCegQIABAA&oq=graphique+radar&gs_lcp=CgNpbWcQARgAMgIIADICCAAyAggAMgIIADICCAAyAggAMgIIADICCAAyAggAMgIIADoFCAAQsQM6BAgAEEM6BAgAEAM6BAgAEApQ9h1Yrz1g8j5oAHAAeACAAXuIAdkGkgEEMTMuMZgBAKABAaoBC2d3cy13aXotaW1nwAEB&sclient=img&ei=QmczYIGDG8H2afa-liA&bih=969&biw=1920&safe=strict&hl=fr)

### Graphiques

Concernant les graphiques, j'utilise le packet NuGet LiveCharts. Il permet de créer des graphiques en courbes dynamiques. Grâce à cette extension, je peux me concentrer sur le fond en laisser la form et le graphisme de côté. Ce paquet NuGet utilise le .Net Framework 4.5.

~~les données des cartes peuvent être téléchargées depuis ce git: <br>
[Maps.xml](https://github.com/Live-Charts/Live-Maps/tree/master/Maps)~~
![Maps.xml](Maquette.png)

# 12. Exigences

|Exigences|QQOQCCP|
|:-------:|:-----:|
|Modifier les paramètres|- **`Quoi`** ? Modifier les généraux paramètres de la simulation<br>- **`Qui`** ? L'utilisateur<br>- **`Où`** ? Dans l'onglet paramètre de l'application<br>- **`Quand`** ? Avant de lancer une simulation<br>- **`Comment`** ? En sélectionnant les options proposées ou en inscrivant par exemple le nombre d'individus dans une population<br>- **`Combien`** ? <br>- **`Pourquoi`** ? Permettre à l'utilisateur de créer des simulations différentes<br>|
|Modifier la population|- **`Quoi`** ? Modifier les paramètres de la population comme par exemple sa résistance au virus<br>- **`Qui`** ? L'utilisateur<br>- **`Où`** ? Dans l'onglet paramètre de l'application<br>- **`Quand`** ? Avant de lancer une simulation et/ou lorsque la simulation est lancée pour certains paramètres<br>- **`Comment`** ? En sélectionnant les options proposées<br>- **`Combien`** ? <br>- **`Pourquoi`** ? Permettre à l'utilisateur de comparer différentes population en même temps et de la faire évoluer au besoin de la simulation<br>|
|Modifier le virus|- **`Quoi`** ? Modifier les paramètres tu virus comme par exemple sa dangerosité<br>- **`Qui`** ? L'utilisateur<br>- **`Où`** ? Dans l'onglet paramètre de l'application<br>- **`Quand`** ? Avant de lancer une simulation et/ou lorsque la simulation est lancée pour certains paramètres<br>- **`Comment`** ? En sélectionnant les options proposées<br>- **`Combien`** ? <br>- **`Pourquoi`** ? Pour permettre à l'utilisateur de personnaliser le virus et de voir les gestes barrières efficaces contre certains paternes<br>|
|Modifier l'affichage|- **`Quoi`** ? Modifier l'affichage comme par exemple quels graphiques seront affichés<br>- **`Qui`** ? L'utilisateur<br>- **`Où`** ? Dans l'onglet paramètre de l'application<br>- **`Quand`** ? Avant de lancer une simulation et/ou lorsque la simulation est lancée pour certains paramètres<br>- **`Comment`** ? En sélectionnant les options proposées<br>- **`Combien`** ? <br>- **`Pourquoi`** ? Pour permettre à l'utilisateur d'avoir un visuel intéressant ainsi que des données qui lui sont importantes<br>|
|Générer la population|- **`Quoi`** ? Générer la population avec les paramètres choisis par l'utilisateur<br>- **`Qui`** ? L'application<br>- **`Où`** ? En BackEnd et dans l'affichage, une fois que la génération est terminée<br>- **`Quand`** ? Lorsque l'utilisateur décide de lancer la simulation<br>- **`Comment`** ? En générant chaque individu demandé par l'utilisateur avec des valeurs aléatoires, tous en restant dans les limites définies par l'utilisateur<br>- **`Combien`** ? <br>- **`Pourquoi`** ? Car il est indispensable de simuler des individus pour une simulation de propagation de virus<br>|
|Générer le virus|- **`Quoi`** ? Générer le virus avec les paramètres choisis par l'utilisateur<br>- **`Qui`** ? L'application<br>- **`Où`** ? En BackEnd et dans l'affichage, une fois que la génération est terminée<br>- **`Quand`** ? Lorsque l'utilisateur décide de lancer la simulation<br>- **`Comment`** ? En assignant le virus à un ou plusieurs individus au démarrage de la simulation<br>- **`Combien`** ? <br>- **`Pourquoi`** ? Car il est indispensable de simuler un virus dans une simulation de propagation de virus<br>|
|Afficher la simulation|- **`Quoi`** ? Afficher la population ainsi que le virus dans une interface graphique et/ou dans les graphiques choisis par l'utilisateur<br>- **`Qui`** ? L'application<br>- **`Où`** ? Sur la page principale de l'application<br>- **`Quand`** ? Une fois que la simulation a fini d'être générée<br>- **`Comment`** ? En utilisant des graphiques et une interface graphique permettant d'informer l'utilisateur sur le nombre d'infectés ou sur les données qu'il a choisi d'afficher<br>- **`Combien`** ? <br>- **`Pourquoi`** ? Car il est imporant d'avoir un retour en direct de ce qu'il se passe dans la simulation<br>|
|Le virus doit se propager|- **`Quoi`** ? Le virus se transmet d'un individu à un autre en fonction des paramètres choisis<br>- **`Qui`** ? L'application<br>- **`Où`** ? En backend ainsi que dans les graphiques par extension<br>- **`Quand`** ? De façon aléatoire en fonction des paramètres choisis par l'utilisateur une fois que la simulation est lancée<br>- **`Comment`** ? La méthode est encore incertaine<br>- **`Combien`** ? <br>- **`Pourquoi`** ? Car il est indispensable de simuler la propagation d'un virus dans une simulation de propagation de virus<br>|
|Les individus sont affectés par le virus|- **`Quoi`** ? Les individus ont des symptômes, meurent, où se rétablissent dû au virus<br>- **`Qui`** ? L'application<br>- **`Où`** ? En backend et frontEnd<br>- **`Quand`** ? Lorsque la simulation est lancée. Arrive de façon aléatoire en fonction des paramètres de l'utilisateur<br>- **`Comment`** ? En réduisant leur santé d'une façon ou d'une autre ou simplement en supprimant l'entité infectée lorsqu'elle "meurt"<br>- **`Combien`** ? <br>- **`Pourquoi`** ? Car certains virus peuvent modifier le comportement ou l'état de santé d'une personne, il est important de le reproduire<br>|
|Les données sont sauvegardées dans la BDD|- **`Quoi`** ? Les données résultantes de la simulation tel que le nombre de rétablis sont sauvegardées dans une base de données locale<br>- **`Qui`** ? La BDD<br>- **`Où`** ? <br>- **`Quand`** ? Lorsqu'une simulation se termine<br>- **`Comment`** ? En récupérant les données résultantes de la simulation et en les sauvegardant dans une Base de données local<br>- **`Combien`** ? <br>- **`Pourquoi`** ? Car certaines données peuvent être utiles et il est important de garder une trace de celle-ci<br>|
|Les hôpitaux se remplissent|- **`Quoi`** ? Les individus infectés sont traités dans les hôpitaux<br>- **`Qui`** ? L'application<br>- **`Où`** ? Backend, frontend<br>- **`Quand`** ? Lorsque des maladent souffrent de certains symptômes<br>- **`Comment`** ? Simplement en assignant certains malades aux hôpitaux<br>- **`Combien`** ? <br>- **`Pourquoi`** ? Car c'est une variable importante qui peut permettre à rendre le résultat plus réaliste<br>|
|Les hôpitaux ont une limite|- **`Quoi`** ? Les hôpitaux se remplissent jusqu'à une limite maximale et arrêtent de prendre des patients<br>- **`Qui`** ? L'application<br>- **`Où`** ? Backend, frontend<br>- **`Quand`** ? Lorsque la limite d'individus est trop grande dans un hôpital (valeur fixe)<br>- **`Comment`** ? Simplement en donnant une valeur maximale de patient par hôpital<br>- **`Combien`** ? <br>- **`Pourquoi`** ? Car les hôpitaux ne peuvent prendre un nombre infini de patients<br>|

# Interactions
## Menu principal
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

## Population
Affiche une page avec les paramètres suivant :
- Écoles
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
- Hôpitaux / écoles / lieux de travail
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
## Virus
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

## Affichage
Affiche une page avec les paramètres suivant :
- Graphiques
  - Permet de sélectionner différents styles de graphiques à afficher
    - Permet de sélectionner une donnée au choix en X et en Y
    - Un exemple du graphique avec les données est affiché à côté de la barre de sélection
  - Plusieurs graphiques possibles à sélectionner
- Affichage d'une "carte" permettant une visualisation plus simple

## Simulation
Affiche une page :
- Affichage d'une barre de chargement lors de la génération de la simulation
  - Évolue en fonction du nombre d'individus créé
- Affiche les graphiques sélectionnés
  - Onglets permettant de sélectionner quel graphique affiché
  - Possibilité d'afficher jusqu'à 4 graphiques sur le même onglet
- S'actualise toutes les secondes (environ)
