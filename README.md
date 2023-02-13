# ConsoleRPG

## Background
"ConsoleRPG" is an assignment from the Accelerated Learning course in Fullstack .Net developer (Noroff). ConsoleRPG is an console application wroten in C# and utilize Unit Tests, GIT usage, and CI/CD.  

## Description
The console application do not focus on a playable application, but more illustrate the fundamentals of C# and Unit tests. There shall be a abstract class "Hero", which there is four classes (Mage, Ranger, Rogue and Warrior). The constructor of the hero should only be based on a name, but should contain level, states and equipment slots.
The hero have methods to level up, equip weapon and armor to specific slots (head, weapon, body and legs). The states is based on the Three-Stat System (Strength, Dexterity and Intelligence), where starting states varies on the class. When hero level up, the hero's states increases, also depend on the class.
Beside of the states of the hero built on the level and class type, armor can give attributes bonuses. There is different kind of armors and weapons, where each class have defined which of them the class have proficiency to.

**States depending on the level and class type:**
| X= Hero.level | Strength | Dexterity | Intelligent |
| ------------- | -------- | --------- | ----------- |
| Mage          |    X     |     X     |    5X+3     |
| Ranger        |    X     |    5X+2   |     X       |
| Rogue         |    X+1   |    4X+2   |     X       |
| Warrior       |   3X+2   |    2X     |     X       |

**Allowed Weapons and armor depending on the class type:**
|    Allowed    |       Weapons      |     Armors    |
| ------------- | ------------------ | ------------- |
| Mage          | Staff, Wand        | Cloth         |
| Ranger        | Bow                | Leather, Mail |
| Rogue         | Dagger, Sword      | Leather, Mail |
| Warrior       | Axe, Hammer, Sword | Mail, Plate   |


**Total States:**

$$X = Class_X(level) + (\sum Armor_{X}\text{, } \forall  Armor_{slots}  )$$

where $X=[strength, dexterity, intelligent]$

**Hero Damage**
$$Damage= Max(1,W)*(1+\frac{C}{100})$$

Where $W = $ damage from equipped weapon and unequipped give 1 dmg. The $C$ note the class damage attribute, where:

|       | Warrior  | Mage         | Ranger    | Rogue     |
| ----- | -------- | ------------ | --------- | --------- |
| **C** | Strength | Intelligence | Dexterity | Dexterity |

**Hero Display**
The hero can display information: name, class, level, Total states and damage.

## Components tree
To begin the implementation of the application, there have been developed a class interaction diagram to show the interaction between classes.The class interaction diagram can be found in the ClassInteractionDiagram.pdf. 
As the diagram is created before any code is written and will not be updated (as it will be part of the overall grade), the code may vary some degree from the diagram. The diagram also contain the calculation on some of the metodes.
## Status of the Project
Only one week for the project and should be completed the 17. February 2023.
## Git Commits
This means the commit message should be structured as follows:

    <type>: <description>

where \<types> used can be:
 - fix (the correlates with PATCH in Semantic versioning)
 - feat (the correlates with MINOR in Semantic versioning)
 - docs
 - style
 - refactor
 - test

In addition, there is possible to apply the "!" as suffix of the type to indicate breaking API changes (the correlates with MAJOR in Semantic versioning).

The \<description> should be meaningful in such a way that it solely can explain the commit and the commit should only cover small additions.
