# GDIM32 In Class Activities
## W1

### Activity 1
The advice that our table decided on was to find helpful resources online when you're stuck such as youtube and online documentation.

### Activity 2

1. 10
2. 2
3. Print "Hello World" to the console every frame
4. Monobehaviour
5. When the game is first loaded, print "x = 10" to the console. 
6. The method PrintMessage has one parameter, an integer x, and 10 is the passed in argument in this case. The purpose of "x = " + x is to print out x = [the actual value of x passed in as the argument], since whatever is in the "" is counted as a string, the x inside the "" doesn't actually refer to the value 10 passed in, while the x outside of the "" refers to the value 10, and then append it to the string through addition, then finally the Debug.Log prints out the x = 10 to the console. 
7. Translate is not called on an actual object, but a class.
8. _playerTransform

### Activity 3
[MG1 Breakdown Google Doc](https://docs.google.com/document/d/1xLpjOiC1mLK6nAbB_YaibtbYXvQONX3D-RQwwT5zzg4/edit?usp=sharing)

## W2

### Activity 1
![MG2 BreakDown Drawing](https://github.com/user-attachments/assets/541b50d6-cb96-425a-8dca-438d6cb05e55)

### Activity 2
[Commit for MG2 on Tuesday during class](https://github.com/UCI-GDIM32-W25/mg2-Weida758/commit/cf224ff410a9b3b90a0c280bb38f8db912403bec)
I believe I finished all the features needed for minigame 2: player jumping while on the ground, coin spawning at random intervals, coin destroying on player contact and UI updating, coin destroys itself after a set amount of time. 

## W3

### Activities 0-2
Andrew Hsur

### Activity 3


![MG3 BreakDown Drawing](https://github.com/user-attachments/assets/0bf0fd9f-7b58-4ea7-bdb8-13dd46924bf3)


## W4
### Activity 0

Lillian

Leandro
### Activity 1

Only the last locator object will have the locator component still intact, the other gameObjects with the locator component will automatically have the locator component destroyed.

### Activity 2 
![MG4 Breakdown](https://github.com/user-attachments/assets/ba679acd-4d14-4412-98e0-d3dadbde7193)


### Activity 3

[Commit for MG4 for the day](https://github.com/Weida758/GDIM32-HW4/commit/529a676567bccef025413bf532fa7beda66a17db)


I created the system that allows spawning intervals of the pipes and also spawning them at random heights. 

## W5
### Activity 1
I think the general design of the items in the scripts are fine, but I would probably change it to having an abstract Item class, then an abstract Weapon class that inherits from the Item class, so that common attributes like _durability can be placed in the Weapon class instead of declaring it on individual weapons that implement IBreakable, and common methods like damage can be created in the parent class Weapon too. The ElvenSword is a single exception that does not break despite being a weapon, so we can override the damage method and simply not reduce durability when attacking.

### Activity 2
The model in the W5demo2 are the scriptable objects EnemyStats and ItemW5Demo2, which are used in the enemy and player script respectively to represent the internal stat of the enemy and also the items in the player's inventory. The controller in the demo is the Player script, which detects input and moves the player based on the input received. The view is the dialogue UI and inventory UI.

### Activity 3

Scenario 1:

MVC with C# events


Scenario 2:

Scriptable objects for weapon & ability data, inheritance for weapon abstract class, MVC with C# events for handling the event of gunshots coming in contact with enemy. FSM for animation and movement modes like walking and running, 


Scenario 3:

Scriptable Objects for the objects that exist in the world, like plant, rock, seed, plant, etc. MVC where player receives input and react to the input for movement, view for the inventory, and model for the various data of the game where an example could be amount of seed in inventory. 

### Activity 4

Leo, Weida, Lillian

[Final Project Proposal First Draft](https://docs.google.com/document/d/1xISKeTxHcyg1ukxzz-i_5d-Cz9bvp_8rIGGyn6IEIXQ/edit?usp=sharing)


## W5

### GDW Talk
Cory Lanham: Narrative Writing

Most game writers most of the times aren’t the people behind the creative decisions in the game, it’s mostly the higher ups


Preproduction Order of Priority
-   High-Level Narrative Summary
-   Key plot points of the main storyline that’s not done in a vacuum

  
Setting and Characters
-   In conjunction with Design, Art, Animation
-   Understand the Scope
-   Detailed Story Outline
-   Level of Detail varies
-   Complete story from start to finish

Scene Descriptions, Gameplay objectives


Narrative Delivery Methods
- How the story is going to be told and how the player will interact with the story
- Sort out the databases
- Text database
- Asset Database (Perforce)
- Establish narrative script import pipeline


Production: Order of priority
- Writing Cinematic and Mission Scripts
- In collaboration with level design and leadership
- Implement and iterate with design
- Re-writing cinematic and mission scripts
- Project changing drastically


System Dialogue
- Dialogue barks
- Ambient dialogue
- Specialized dialogue systems

  
World Building and Lore
- Character / Setting description
- World History and timeline
- A lot of what is written here is not “Player facing”


UI/UX Text
- Item/Location Descriptions
- Tooltips
- Casting and Recording


Post Production to Ship: Order of tasks
- Marketing Materials
- Website Copy
- Traillers
-Non-Dialogue Text Revisions
- Proofreading
- Editing for clarity
- Localization
- Translation Notes
- Rewrites for Different markets



Breaking into the industry
- Look for work in another department
- QA is the most common
- In-House QA Team > Outsourced Team
- Internships
- Build portfolio by making a game, make a website or something to showcase your portfolio
- For unfinished projects, make sure to have a clear disclaimer that it is unfinished and make sure team members are cool with it. 


Networking
- IGDA/Other community meetups


Resources:
- Book: Video Game Storytelling (Skolnick)
- Book The Game Narrative Toolbox (Heussner, et al.)
- The Game Writing Guide (Megill)
- Website: gamejobs co

