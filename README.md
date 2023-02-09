# RockPaperScissors-shorter

This is a rock-paper-scissors game implemented in C#. It is and does the same as the other RockPaperScissors I uploaded, 
but in my opinion I used a long code of ifs/else ifs and its size could be shorten significantely.
For that I used a "Func" type to reference a method that takes 2 strings as paramether and returns a string. In this case, the delegate 'game' is assigned to a lambda expression that implements the logic for playing a game of Rock, Paper, Scissors between two players, player A and player B. The 'game' delegate takes two string arguments, playerA and playerB, representing the choices made by player A and player B respectively, and returns a string indicating the result of the round.

## Usage
Clone the repository to your local machine
Open the solution in Visual Studio
Run the program in the console
Enter the number of rounds you would like the game to play.
The result will be a game of random choices between Player A and Player B, after which one will win the game.

## Gameplay
The game starts by asking the user to input the number of rounds to be played. 
The input must be an odd number, otherwise, the user will be prompted to input an odd number. 
The game has two players, Player A and Player B. Both players choose one of the options, rock, paper, or scissors, randomly. 
The outcome of each round is displayed, and the score of each player is also updated after each round. 
The game ends if either Player A or Player B wins a number of consecutive rounds that is more than half of the total number of rounds to be played. 
At the end of the game, the final score of each player is displayed.
