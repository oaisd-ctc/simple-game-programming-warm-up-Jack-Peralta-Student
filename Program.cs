using System;

class program
{
    int playerPoints = 0;
    int rivalPoints = 0;

    public static void Main(string[] args)
    {
        program game = new program();
        game.Introduction();
        game.Start();
    }

    public void Introduction() //It will create a paragraph explaing how the game will be like.
    {
        Console.WriteLine("Dice Game");
        Console.WriteLine(" ");
        Console.WriteLine("In this game you and a computer Rival will play 10 rounds where you will each roll a 6-sided dice,");
        Console.WriteLine("and the player with the highest dice value will win the round. The player who wins the most rounds wins the game. Good luck!");
        Console.WriteLine(" ");
        Console.WriteLine(" ");
    }

    public void Start() //The following code will run the game for 10 rounds!
    {
        Console.WriteLine("Press any key to start...");
        Console.ReadKey(true);

        Random rnd = new Random();

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Round {i + 1}");

            int playerRoll = rnd.Next(1, 7);
            int rivalRoll = rnd.Next(1, 7);

            Console.WriteLine($"You rolled: {playerRoll}");
            Console.WriteLine($"Rival rolled: {rivalRoll}");

            Console.WriteLine("The score is now - You : " + playerPoints + " Rival : " + rivalPoints); //This part will print the scores for each round.

            Console.WriteLine("Press any key to start...");
            Console.ReadKey(true);

            if (playerRoll > rivalRoll)
            {
                Console.WriteLine("You won this round");
                playerPoints++;
            }
            else if (playerRoll < rivalRoll)
            {
                Console.WriteLine("The Rival won this round.");
                rivalPoints++;
            }
            else
            {
                Console.WriteLine("This round is a draw!");

            }

            Console.WriteLine();
        }

        // Final scores
        Console.WriteLine("Game Over!");
        Console.WriteLine($"Your total score: {playerPoints}");
        Console.WriteLine($"Rival's total score: {rivalPoints}");

        // Determine the winner
        if (playerPoints > rivalPoints)
        {
            Console.WriteLine("Congratulations! You win the game!");
        }
        else if (playerPoints < rivalPoints)
        {
            Console.WriteLine("Sorry, you lost the game. Better luck next time!");
        }
        else
        {
            Console.WriteLine("Tie game!");
        }
    }

}