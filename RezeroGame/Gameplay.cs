public class Gameplay
{
    // instance variables here
    private int correctChoice;
    private int returnByDeath;

    public void PrintBackstory()
    {
        // Print Backstory to user 
        Console.WriteLine("Welcome to the world of Re:Zero - Starting life in another world!");
        Console.WriteLine("You are Subaru Natsuki, a young man who finds himself transported to a magical world filled with danger and intrigue.");
        Console.WriteLine("Armed only with his wits and a newfound power to return from death, Subaru must navigate this strange new world and uncover the dangers that lie within.");
        Console.WriteLine(" ");

        Console.WriteLine("You will face a variety of challenges in your journey, from fierce battles to complex social interactions with the people of this world.");
        Console.WriteLine("Your choices will have consequences, so be careful as you make decisions that could alter the course of your adventure.");
        Console.WriteLine("Will you be able to survive and thrive in this new world, or will you meet an untimely end?");
        Console.WriteLine("The fate of Subaru and the world of Re:Zero is in your hands.");
        Console.WriteLine(" ");

        Console.WriteLine("Are you ready to take on this challenge?");
        Console.WriteLine(" ");
    }
    public void StartGame()
    {
            string startGame;
            bool validInput = false;
            
        //Ask to start the game
        while (!validInput)
            {
                Console.WriteLine("yes or no");
                startGame = Console.ReadLine().ToLower();
                if (startGame == "yes")
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Let the adventure begin!");
                    Console.WriteLine(" ");
                    validInput = true;
                    correctChoice = 1;
                }
                else if (startGame == "no")
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Comeback next time!");
                    Console.WriteLine(" ");
                    validInput = true;
                }
                else
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Inavlid Selection");
                    Console.Write(" ");
                }
            }
        }
    public void RunScenario1()
    {
        while (true) // infinite loop
        {
            try
            {
                Console.Clear();
                Console.WriteLine("As Subaru shopping in a convenience store, he blinks and finds himself in a different world.");
                Console.WriteLine("However, his arrival is not met with a warm welcome as he is immediately attacked by three big men.");
                Console.WriteLine(" ");
                Console.WriteLine("Two options... run away or fight back");

                string choice1 = Console.ReadLine().ToLower();
                //run away - successful choice
                if (choice1 == "run away")
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Just as it seems like all hope is lost, a beautfiul woman with long-silvered hair comes to his rescue.");
                    Console.WriteLine(" ");
                    Thread.Sleep(5000);
                    correctChoice = 2;
                    returnByDeath = 0;
                    break; // exit the infinite loop
                }
                //fight back - bad choice
                else if (choice1 == "fight back")
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("You are dead. The men overwhelmed you with physical strength.");
                    Console.WriteLine(" ");
                    Console.WriteLine("By the ability of return by death, you are reborn...");
                    Console.WriteLine(" ");
                    Thread.Sleep(3000);
                    returnByDeath = 2;
                }
                //Invalid Input 
                else
                {
                    throw new Exception("Invalid input. Write either run away or fight back");
                }
            }
            //Catch Exception
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Thread.Sleep(2000);
            }
        }
    }

    public void RunScenario2()
    {
        //Scenario 2 - "The start of the Insignia Quest"
        while (correctChoice == 2 || returnByDeath == 2)
        {
            Console.Clear();
            Console.WriteLine("After she valiantly defeats the enemys with magical powers, she introduces herself as Emilia.");
            Console.WriteLine("Along with her strange cat-like creature named Puck, they take Subaru to try and recover an insignia that was stolen from them by a young thief named Felt.");
            Console.WriteLine(" ");
            Console.WriteLine("Emilia: Subaru, we need to get that insignia back. It's very important to me.");
            Console.WriteLine(" ");

            //Prompt the player for a choice: Informing the player that they need to make a decision.
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1. Ask about the insignia.");
            Console.WriteLine("2. Ask about Felt.");

            string choice2 = Console.ReadLine();

            switch (choice2)
            {
                //Case 1: Asking about the insignia
                case "1":
                    Console.WriteLine(" ");
                    Console.WriteLine("Subaru: Emilia, can you tell me more about the insignia and why it's so important?");
                    Console.WriteLine(" ");
                    Console.WriteLine("Emilia: Of course. This insignia is a symbol of my candidacy for the royal selection, a contest to determine the next ruler of this kingdom.");
                    Console.WriteLine("Emilia: Without it, my chances of winning are greatly reduced.");
                    Console.WriteLine(" ");
                    Thread.Sleep(7000);
                    correctChoice = 3;
                    break;
                //Case 2: Asking about Felt.
                case "2":
                    Console.WriteLine(" ");
                    Console.WriteLine("Subaru: Who is Felt and why did she steal the insignia?");
                    Console.WriteLine(" ");
                    Console.WriteLine("Emilia: Felt is a young thief who works with a gang of bandits.");
                    Console.WriteLine("Emilia: She stole the insignia from me, and we need to get it back before she can use it for her own purposes.");
                    Console.WriteLine(" ");
                    Thread.Sleep(7000);
                    correctChoice = 3;
                    break;
                //Default case: Invalid input
                default:
                    Console.WriteLine(" ");
                    Console.WriteLine("Invalid input. Please enter either 1 or 2.");
                    Thread.Sleep(3000);
                    Console.WriteLine(" ");
                    break;
            }
        }
    }
    public void RunScenario3()
    {
        //Scenario 3 - "Confronting Felt for the Insignia"
        while (correctChoice == 3 || returnByDeath == 3)
        {
            Console.Clear();
            Console.WriteLine("Subaru, Emilia, and Puck arrive at Felt's hideout, where they find her and a man named Reinhard.");
            Console.WriteLine("Reinhard is a knight of the kingdom, and he is also looking for the stolen insignia.");
            Console.WriteLine(" ");
            Console.WriteLine("Felt: So you've come for the insignia, huh?");
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1. Challenge Felt to a battle for the insignia.");
            Console.WriteLine("2. Try to negotiate with Felt.");
            string choice3 = Console.ReadLine();

            switch (choice3)
            {
                //Case: 1 Challenge Felt to a match
                case "1":
                    Console.WriteLine(" ");
                    Console.WriteLine("Subaru: Felt, I challenge you to a battle! If we win, you must give us the insignia.");
                    Console.WriteLine(" ");
                    Console.WriteLine("Felt: Alright, I accept your challenge! Let's see what you've got.");
                    Console.WriteLine(" ");
                    Thread.Sleep(5000);
                    correctChoice = 4;
                    break;
                //Case 2: Try to Negotiate with Felt
                case "2":
                    Console.WriteLine(" ");
                    Console.WriteLine("Subaru: Felt, can we try to work out a deal? If you give us the insignia, we can help you in some way.");
                    Console.WriteLine(" ");
                    Console.WriteLine("Felt: Hmph, you've got some nerve. But fine, I'll give you a chance to prove yourself.");
                    Console.WriteLine(" ");
                    Thread.Sleep(5000);
                    correctChoice = 4;
                    break;
                //Default case: Invalid input
                default:
                    Console.WriteLine(" ");
                    Console.WriteLine("Invalid input. Please enter either 1 or 2.");
                    Thread.Sleep(3000);
                    Console.WriteLine(" ");
                    break;
            }
        }
    }
    public void RunScenario4()
    {
        //Scenario 4 - Boss Fight (Elemental Clash)
        while (correctChoice == 4 || returnByDeath == 4)
        {
            // Loop until winning the battle or Subaru returns by death
            Console.Clear();
            Console.WriteLine("The boss fight against Felt begins.");
            Console.WriteLine("You will face Felt in a game called Elemental Clash");
            Console.WriteLine("Fire beats Earth, Water beats Fire, and Earth beats Water.");
            Console.WriteLine(" ");

            //Arrays used in the game 
            string[] choices = { "Fire", "Water", "Earth" };
            string[,] roundOutcomeMessages = {
                { "It's a draw!", "You lost!", "You won!" },
                { "You won!", "It's a draw!", "You lost!" },
                { "You lost!", "You won!", "It's a draw!" }};

            int[,] resultsMatrix = { { 0, -1, 1 }, { 1, 0, -1 }, { -1, 1, 0 } }; // 0: draw, 1: player wins, -1: player loses

            //variables used
            int playerScore = 0;
            int enemyScore = 0;

            for (int i = 0; i < 3; i++)
            {
                //prompt the player for their move
                Console.WriteLine("Round " + (i + 1));
                Console.WriteLine("Select your move against the enemy:");

                //display the available moves for the player
                for (int j = 0; j < choices.Length; j++)
                {
                    Console.WriteLine((j + 1) + ". " + choices[j]);
                }

                //read players input for their choice and validate it
                string playerInput = Console.ReadLine();
                int.TryParse(playerInput, out int playerChoice);
                if (playerChoice < 1 || playerChoice > 3)
                {
                    Console.Clear();
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 3.");
                    i--;
                    continue;
                }

                //Determine the enemy's choice and display the round outcome
                int enemyChoice = GetRandomChoice();
                int result = resultsMatrix[playerChoice - 1, enemyChoice - 1];
                Console.WriteLine("Felt chose " + choices[enemyChoice - 1] + ".");
                Console.WriteLine(roundOutcomeMessages[playerChoice - 1, enemyChoice - 1]);
                Console.WriteLine(" ");

                //Update the score based on the round outcome
                if (result == 1)
                {
                    playerScore++;
                }
                else if (result == -1)
                {
                    enemyScore++;
                }
            }
            //Compare the final scores and display the outcome
            int finalResult = CompareScores(playerScore, enemyScore);
            DisplayFinalResult(finalResult);

            //Tie but you still die. Sorry. hahaha.
            if (finalResult == 0)
            {
                Console.WriteLine("Felt: Don't waste my time. Mutt!");
                Thread.Sleep(2000);
                Console.WriteLine(" ");
                Console.WriteLine("* Felt uses Cor Leonis Poison on you *");
                Console.WriteLine("It is a witch's cult ability, making it impossible to recover from.");
                Console.WriteLine("You slowly die from it's effects.");
                Console.WriteLine(" ");
                Console.WriteLine("By the ability of return by death, you are reborn...");
                Thread.Sleep(5000);
                returnByDeath = 4;
            }
            //User wins
            if (finalResult == 1)
            {
                correctChoice = 5;
                returnByDeath = 0;
            }
            //User loses
            else if (finalResult == -1)
            {
                Console.WriteLine("Felt: Haha this is all you had!");
                Console.WriteLine(" ");
                Console.WriteLine("* Felt uses Divine Protection of Wind Induced Death *");
                Console.WriteLine("* Your head split in two *");
                Console.WriteLine(" ");
                Thread.Sleep(4000);
                Console.WriteLine("By the ability of return by death, you are reborn...");
                Thread.Sleep(3000);
                Console.WriteLine(" ");
                returnByDeath = 4;
            }
        }
    }
    public void RunScenario5()
    {
        // Scenario 5 - The Final Scenario - "Win the game"
        // This loop runs when the correctChoice variable equals 5
        while (correctChoice == 5)
        {
            Console.Clear();
            Console.WriteLine("Congratulations, Subaru! You've successfully retrieved Emilia's insignia and defeated Felt.");
            Console.WriteLine("Thanks to your efforts, Emilia can now participate in the royal selection and the adventure continues.");
            Console.WriteLine(" ");
            Console.WriteLine("Thank you for playing Re:Zero - Starting life in another world!");
            Console.WriteLine(" ");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
            break;
        }
    }
    //Enemy random choice
    private static int GetRandomChoice()
    {
        Random random = new Random();
        return random.Next(1, 4);
    }

    private static int CompareScores(int playerScore, int enemyScore)
    {
        //This function compares the player's score with the enemy's score and returns 1 if the player wins, -1 if the enemy wins, or 0 if it's a tie
        //The player still technically loses if its a tie as they die
        if (playerScore > enemyScore)
        {
            return 1;
        }
        else if (playerScore < enemyScore)
        {
            return -1;
        }
        else
        {
            return 0;
        }
    }
    private void DisplayFinalResult(int result)
    {
        // This function displays the final result of the game based on the result
        // returned by the CompareScores function
        if (result == 0)
            {
                Console.WriteLine("The final result is a draw!");
                Thread.Sleep(3000);
            }
            else if (result == 1)
            {
                Console.WriteLine("You won the boss fight against Felt!");
                Thread.Sleep(3000);
            }
            else if (result == -1)
            {
                Console.WriteLine("You lost the boss fight against Felt!");
                Thread.Sleep(3000);
            }
            Console.WriteLine(" ");
    }
}