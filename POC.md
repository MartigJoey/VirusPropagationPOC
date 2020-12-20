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
#### Graphiques

Utilisation du framework LiveCharts.
[Graphiques](https://lvcharts.net/App/notfound)

### Carte

#### Template
#### Données
les données des cartes peuvent être téléchargée depuis ce git
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
