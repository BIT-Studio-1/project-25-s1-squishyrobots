using Globals;




namespace SquishyRobotGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player.location = "shuttle bay";

            Console.WriteLine("" +
                "Welcome to the Squishy Robot Game\n" +
                "\t - inventory\n" +
                "\t - rules\n");

            do
            {
                Console.ForegroundColor = ConsoleColor.Gray;

                switch (Player.location)
                {
                    case "shuttle bay":
                        ShuttleBay.start();
                        break;
                    case "escape pods":
                        EscapePods.start();
                        break;
                    case "engine room":
                        EngineRoom.start();
                        break;
                }

                // do while !exit:
                //      query player
                // if exit, then leave room loop.






               
            } while (Player.input != "exit") ;












        }
    }
}
