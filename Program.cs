using Globals;


namespace SquishyRobotGame
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (Player.input != "exit")
            {
                Console.WriteLine("You are in the main room. You can go to the Escape Pods, Shuttle Bay, or Engine Room.");
                Console.WriteLine("Where do you want to go? (Escape Pods, Shuttle Bay, Engine Room)");
                Console.WriteLine("Type 'exit' to quit the game.");


                //Input
                Player.input = Console.ReadLine();
                Console.Clear();



                switch (Player.input.ToLower())
                {
                    case "escape pods":
                        Console.WriteLine("You choose the escape pods");
                        EscapePods.start();
                        break;
                    case "shuttle bay":
                        Console.WriteLine("You choose the shuttle bay");
                        ShuttleBay.start();
                        break;
                    case "engine room":
                        Console.WriteLine("You choose the engine room");
                        EngineRoom.start();
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }

            }

            









        }
    }
}
