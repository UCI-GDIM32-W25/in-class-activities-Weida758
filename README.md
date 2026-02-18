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


## W6

### GDW Talk
#### Narrative Writing, Cory Lanham

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


#### Technical Art, Stephen Coan

What is Technical Art
- Tech artist work to remove the barrier between engineering and art, to make technology more accessible and optimized.


Sub Disciplines of Technical Art
- Character Tech Art
- Rigging & Skinning
- Animation tools


Tools Tech Art
- Asset management
- Standards and Conventions
- Art Import/Export
- Workflow simplification
- Automation and engine hookup


Runtime Tech Art
- Shaders
- Procedural Generation
- Optimization


Examples of Technical Art
- “Scene Footprints” analyzer
Environment memory was a bottleneck to shipping on switch
- Built a tool to presents environment by their memory footprint, breaks down the most expensive asset, and then warn artists if they’ve built a scene too large to ship on switch. 


FX Data Hookup Tooling
- A way to connect FX behavior to gameplay and did not want hard-coded behavior
- Extended existing design tools for creating spells with additional data for FX behavior


Character “Chromas”
- Character customization where color are customized


How to Become a Technical Artist
- Valuable Skills
- Strong communication skills
- Ability to break complex tasks down into more approachable steps
- Excitement about learning new things
- Passion for helping others achieve their passions


Stuff to learn about
- Shader editing in Unity or Unreal 
- Scripting for 3D modeling tools  (Maya/Blender/Houdini)
- The basics of runtime optimization
- The most important starting point is to learn shaders. Optimization and tools tech artist are the more complex roles, and the best way to learn about them is to read about it. 
- RenderDoc

## W7

### Activity 1
- State machine that determines the state that the duck is in based on whether the duck has a line of sight to the player or not. The duck is only in one state at a time and only the logic within that state is ran.
- Raycast itself only returns true or false, but it produces a variable hitinfo that provides information about what the raycast hit.
- Spherecast is like a raycast but instead of firing an arrow, it fires spheres for detection instead
- Vector is a majority part of getting these logical detections correct.

### Activity 2
Attendance: Lillian, Weida, Leandro

### Activity 3
![Week7FinalBreakdown](https://github.com/user-attachments/assets/30fef8fa-0310-4330-a2e2-a94f9985cc1c)

### Activity 4


[Google Doc for task breakdown](https://docs.google.com/document/d/1hls1AYtu9bNMllUslOCO5rB60zfJzVcmPYjtyw58uko/edit?usp=sharing)


### Activity 5


[Commit today for final](https://github.com/Weida758/GDIM32-Final/commit/97f3fa7ed2b1493a756176f11982db2e4503a2a5)




I imported some materials from the Unity Asset store and also created set up script for the statemachine.
