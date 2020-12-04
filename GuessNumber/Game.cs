using System;
using System.Collections.Generic;
using System.Text;

namespace GuessNumber
{
    public class Game
    {
        private readonly int _correctAnswer;
        public bool IsOver = true;

        public Game(int CorrentAnswer)
        {
            _correctAnswer = CorrentAnswer;
        }

        public string ProcessUserInput(IConsole Wrapper)
        {
            string message = "You win!";
            int userAnswer = Wrapper.ReadLine();
            if (userAnswer == _correctAnswer)
            {
                IsOver = false;
            }
            else
            {
                message = userAnswer > _correctAnswer ? "Too High" : "Too Low";
            }
            return message;
        }
    }
}
