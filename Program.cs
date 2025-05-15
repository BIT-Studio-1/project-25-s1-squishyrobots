using Globals;




namespace SquishyRobotGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player.location = "shuttle bay";



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


               
            } while (Player.input != "exit") ;












        }
    }
}
