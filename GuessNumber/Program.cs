using System;

namespace GuessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            do
            {
                var gameNew = new Game(random.Next(0, 100));
                while (gameNew.IsOver)
                {
                    var input = new ConsoleWrapper();
                    var message = gameNew.ProcessUserInput(input);
                    Console.WriteLine(message);
                }
                Console.WriteLine("Play more? Press 'Y'");
            }
            while (Console.ReadKey().KeyChar == 'Y');
        }
    }
}

