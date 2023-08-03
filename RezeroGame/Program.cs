namespace RezeroGame;
class Program
{
    static void Main(string[] args)
    {
         // Create a new instance of the Gameplay class
            Gameplay game = new Gameplay();

            // Call methods to run various parts of the game
            game.PrintBackstory();
            game.StartGame();
            game.RunScenario1();
            game.RunScenario2();
            game.RunScenario3();
            game.RunScenario4();
            game.RunScenario5();
    }
}
