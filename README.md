# SimpleGameLib

<table>
<tbody>
<tr>
<td><a href="#item">Item</a></td>
<td><a href="#potion">Potion</a></td>
</tr>
<tr>
<td><a href="#potionforce">PotionForce</a></td>
<td><a href="#potionsoin">PotionSoin</a></td>
</tr>
<tr>
<td><a href="#amonstre">AMonstre</a></td>
<td><a href="#gobelin">Gobelin</a></td>
</tr>
<tr>
<td><a href="#orc">Orc</a></td>
<td><a href="#player">Player</a></td>
</tr>
<tr>
<td><a href="#commonui">CommonUI</a></td>
</tr>
</tbody>
</table>


## Item

Interface de création d'un Item

### getDescription

Affiche sur la sortie console la decription de l'item


## Potion

Classe absraite permettant de créer des potions. Un potion peut être bu et rendra alors une quantité rendu d'un certains paramètre du personnage qui bois la potion

### Constructor(r)

Initialisation de la potion

| Name | Description |
| ---- | ----------- |
| r | *System.Int32*<br>quantité que rendra la potion |

### applyEffect(player)

applique l'effet de la potion

| Name | Description |
| ---- | ----------- |
| player | *SimpleGameLib.Player*<br> |

### getDescription

Affiche les paramètres de la potion sur la sortie console

### getPotionType

Retourne le type de potion Soin/Force/Résistance etc...

#### Returns

String

### rendu

Quantité rendu par la potion


## PotionForce

Potion de force

### Constructor(fr)

Constructeur de la potion de force

| Name | Description |
| ---- | ----------- |
| fr | *System.Int32*<br>Force que rendra la potion |

### applyEffect(player)

Rends de la force au joueur

| Name | Description |
| ---- | ----------- |
| player | *SimpleGameLib.Player*<br>Joueur qui boit la potion |

### getPotionType

Donne le type de potion, ici Force

#### Returns

String


## PotionSoin

Potion de soin Un potion de soin rends des PV au joueurs

### Constructor(pr)

Constructeur de la potion de soin

| Name | Description |
| ---- | ----------- |
| pr | *System.Int32*<br>Point de vie rendu par la potion |

### applyEffect(player)

Rends des PV au joueurs

| Name | Description |
| ---- | ----------- |
| player | *SimpleGameLib.Player*<br>Joueur qui bois la potion |

### getPotionType

Donne le type de potion, ici Soin

#### Returns

String


## AMonstre

Classe abstraite pour configurer les Monstres

### Constructor(f)

Constructeur d'un monstre basique

| Name | Description |
| ---- | ----------- |
| f | *System.Int32*<br>force du monstre |

### Attack(player)

Attaque un joueur Dans tous les cas, le joueur prends un coup. Des effets peuvent être rajouter suivant le monstre

| Name | Description |
| ---- | ----------- |
| player | *SimpleGameLib.Player*<br>Joueur à attaquer |

### defend

Permet au monstre de se positionner en mode défense Le mode défense divise par 2 les dégat de la prochaine attaque subit

### force

Force du monstres, Aucune valeur par défauts La valeur change en fonction du type de monstre

### getDescription

Affiche le type, les PV et la force du monstre sur la console

### getMonsterType

Returne le type de monstre

#### Returns

String

### isAlive

Permets de savoir si le monstre est en vie ou pas

#### Returns

bool

### pv

Point de vie des monstres, 100 par défauts

### takeHit(deg)

Le monstre reçoit un coup En prennant un coup, sa vie va baisser

| Name | Description |
| ---- | ----------- |
| deg | *System.Int32*<br>degat pris par le monstre |


## Gobelin

Classe gobelin Le gobelin n'a pas un grande force mais sa force augmente a chaque tour pour un maximum de 20

### Constructor

Constructeur d'un gobelin Force de base : 10

### Attack(player)

Attaque un joueur A chaque attaque, sa force augmente de 1 Sa force augmente tant qu'elle est inférieur à 20

| Name | Description |
| ---- | ----------- |
| player | *SimpleGameLib.Player*<br>Joueur attaquer |

### getMonsterType

Retourne Gobelin

#### Returns

String


## Orc

Classe Orc L'orc est très fort mais perds un peu de vie à chaque coup

### Constructor

Constructeur de Orc Force de base : 30

### Attack(player)

Attaque un joueur A chaque attaque, l'orc perds 5 points de vie

| Name | Description |
| ---- | ----------- |
| player | *SimpleGameLib.Player*<br>Joueur attaqué |

### getMonsterType

Retourne Orc

#### Returns

String


## Player

Classe permettant de modéliser un joueur

### Constructor(name)

Constructeur de Player Force de base : 20 PV de base : 100

| Name | Description |
| ---- | ----------- |
| name | *System.String*<br>Nom du joueur |

### addForce(f)

Ajoute de la force au joueur

| Name | Description |
| ---- | ----------- |
| f | *System.Int32*<br>nombre de point de force à ajouter |

### addPv(pv)

Ajoute des PV au joueur

| Name | Description |
| ---- | ----------- |
| pv | *System.Int32*<br>nombre de PV à ajouter |

### defend

Se mets en position défensive En position défensive, les dégat recut lors de la prochaine attaque son diviser par 2

### drinkPotion(potion)

Permets de boire une potion

| Name | Description |
| ---- | ----------- |
| potion | *SimpleGameLib.Item.Potion.Potion*<br>Potion à boire |

### getDescription

Affiche le nom et les caractéristiques du joueurs sur la console

### isAlive

Permet de savoir si le joueur est encore vivant

#### Returns



### NormalAttack(monstre)

Attaque normale

| Name | Description |
| ---- | ----------- |
| monstre | *SimpleGameLib.Monstre.AMonstre*<br>Monstre a attaqué |

### takeHit(deg)

Le joueur prends un coup qui vas faire baisser ses PV

| Name | Description |
| ---- | ----------- |
| deg | *System.Int32*<br>dégat recut |


## CommonUI

Mets en place des outils pour améliorer l'affichage en console

### clearScreen

Efface les messages écrit sur la console

### IntervalInput(min, max)

Permet de saisir une valeur comprise entre deux valeurs

| Name | Description |
| ---- | ----------- |
| min | *System.Int32*<br>Borne minimale de l'intervalle |
| max | *System.Int32*<br>Borne maximale de l'intervalle |

#### Returns



### waitForKey(msg, key)

Permet d'attendre l'appuie de l'utilisateur sur une touche

| Name | Description |
| ---- | ----------- |
| msg | *System.String*<br>Message affiché pour informé l'utilisateur\n Par défaut: Press Enter to continue |
| key | *System.ConsoleKey*<br>Touche sur laquelle il faut appuyer\n Par défaut: ConsoleKey.Enter |
