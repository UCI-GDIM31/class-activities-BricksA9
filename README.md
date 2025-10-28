# in-class-activities
## Devlogs
### W1
Added cat movement and changed the view to first person :D

### W2
1. Why are the r, g, and b variables floats instead of ints, bools, or strings?\
they're floats because they represent the numerical value of a specific color. Combined, they make up a color on the color spectrum. Ints wouldn't be precise enough, 
while bools can basically store only black and white (false/true).
Strings can store characters, which would probably work better in a hexadecimal system where only one variable is controlling the final color.
2. Why is the _bounce variable an int instead of a float, bool, or string?\
It's an int because you can't have 0.2 of a bounce; it must always be finished in order to count as a bounce.
3. The error you got after Step 4 of Part 2 told you something useful about why that line of code was broken- what was it?\
It was missing a semicolon.

### W3
Method Discussion Activity
1. The method will take an integer called sanity (or whatever the sanity level variable is called), 
and then change the brightness variable (again, whatever it’s actually called).

Monobehavior Coding Activity
1. A skinwalker (the component), depending on the type of skin they're wearing (classes), will behave differently. 
The skin will tell the skinwalker how to behave. The traits of the skin (color, texture, etc) will change the behavior type. 
The methods change the behavior, while the variables change the appearance of the skin.
2. There's no upper limit to how many times the ball can increase in brightness.

### W4

Line 5: a variable for movement speed that can be changed in the component (inside the inspector)\
Line 22: it grabs the difference in how much the cat has moved since the last frame\
Line 25: Actually changes the location (the z axis) of the cat

Line 17: The initialization of a variable that stores whether the cat is on the ground or not. Used to prevent unwanted double-jumping\
Line 28: an if statement to see whether there is an input from the space key (from the physical keyboard) and if cat is on the ground. If both are true then the code block inside runs.\
Line 32: line that updates the status of the cat, in terms of its groundedness, so that it’s no longer ‘on the ground’ because it’s currently jumping.

Table #14
What solution did you come up with for the collider activity, and why? Specifically- which objects did you add Rigidbodies to, and which object(s) did you check Is Trigger on?\
We added rigidbodies to the cat and the ball, and Is Trigger was checked on the goal.
IF your game did not work perfectly the first time you tested it, talk about what you had to fix.\
We didn’t have the rigidbody on the cat, and didn’t have the Is Trigger checked for the goal.


### W5
Activity 1:\
Question: getcomponent() – is it like a universal function that can be called like 
class.object.function() in c++?
Yes–but it must only be within an object that has the script with the component you’re looking for.

Activity 2:\
What member variable(s) does this class need?\
The class needs a variable to track the target object's location, and one that can be customized in the 
What method(s) does this class need? Should it be something that Unity provides (like Start(), Update(), or a collision method), or one you write?\
It only needs the Start and Update methods from Unity.
What should the method(s) do?\
The Start method grabs the Navmesh component from the Deer object, and the Update method constantly grabs the position of the target object and calls the
Navmesh agent to move the deer towards the target object.

### W6


### W7


### W8


### W9


### W10


### W11

## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 