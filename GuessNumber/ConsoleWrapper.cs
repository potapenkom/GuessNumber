using System;
using System.Collections.Generic;
using System.Text;

namespace GuessNumber
{
    public class ConsoleWrapper : IConsole
    {
        public int ReadLine()
        {
            int _userAnswer;
            Console.Write("Enter your answer: ");
            while (!int.TryParse(Console.ReadLine(), out _userAnswer))
            {
                Console.WriteLine("incorrect input, enter number 0 to 100 (inclusive).");
                Console.Write("Enter your answer: ");
            }
            return _userAnswer;
        }
    }
}
