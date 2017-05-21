# WitchesPuzzle
I developed this project in order to solve the the Witches puzzle riddle.
For those of you which don't know what is the witches puzzle see image below:

![Alt text](/WitchesPuzzle.png?raw=true "The witches puzzle")

The main idea is to omplete the puzzle in a way that all witches in the middle of the puzzle are completed (head must be connected to the same tail color).

As you may calculate there are tons of options to try, in specific: 9! * (4 ^ 9)
I was lazy and decided to dedicate two hours for creating the code instead of solving the real puzzle...

At the current configuration there are 8 possible solutions. You can change the cards configuration as you want.
In addition, I ran it in debug, hence, I didn't need a graphic output, feel free to add it if you liked the solution.

In code I called:
  * The 3x3 matrix --> "Board".
  * Each piece is called WitchCard.
  
The rest is simple clean code...
