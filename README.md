# in-class-activities
## Devlogs
### W1
Write your W1 activity Devlog here.
"Hello world!"
### W2
Create future Devlog sub-headers with the three # symbols, then write your Devlogs below them.
### Question 1
Why are the r, g, and b variables floats instead of ints, bools, or strings?
It's because if they were static integers there wouldn't be color range. Bools are true or false arguements so that just wouldn't make sense on colors. Also strings are just for dialogue.
### Question 2
Why is the _bounce variable an int instead of a float, bool, or string?
This is because it's an integer. The code can't calculate for half a bounce or .5 of a bounce. It's one bounce at a time, or one whole number at a time.
### Question 3
The error you got after Step 4 of Part 2 told you something useful about why that line of code was broken- what was it?
Not going to lie I kind of worked past it so I don't remember the exact error. I went back and fixed some compiler errors I saw in the console and they were things like missing semi-colons, "f" floats after numbers, improper variable spelling. Also I had an issue with the blue rgb value not changing from  0, which I was able to see in the console, so I altered some of the code.
### W3
Table 18:

### Question 3
Using UnityEngine;

public class SetLightDimness : Monobehavior

public void Update()

private void SetLightDimness (float sanity) {
    float light = 100 * sanity;
}
### W4
line 5 sets the move speed, line 22 sets the inputs attributes like speed and the time between each frame activation. 25 changes the positioning based off of the input vertically.
    move speed is a member variable, and the type is float
    line 25's transform is a Component
    transform is calling a method translate
    the method parameters are (0,0,translation)

### What solution did you come up with for the collider activity, and why? and which object(s) did you check Is Trigger on?

In physics a rigid body is a piece of mass that reacts to external forces. cat and ball are rigid bodies. The Goal keeps track of points, which is on trigger




### MonoBehavior coding activity
1.CLasses are a subbranch/name/action to a script, the script is a component to an object, and the opject goes into the scene, etc. Methods and members are just even smaller branches that go into the classes that "tell" the class what it does. MonoBehavior enacts it or tells unity that it "does" this thing. I think of it as a Matryoshka doll. The classes keep getting nested within each other.
2.There  is no cap to the brightness or color increase. I think it just goes to white.
## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 