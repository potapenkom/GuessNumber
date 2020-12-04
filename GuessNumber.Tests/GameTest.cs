using NUnit.Framework;

namespace GuessNumber.Tests
{
    public class TestConsoleWrapper10 : IConsole
    {
        public int ReadLine()
        {
            return 10;
        }
    }

    public class TestConsoleWrapper99 : IConsole
    {
        public int ReadLine()
        {
            return 99;
        }
    }

    public class TestConsoleWrapper100 : IConsole
    {
        public int ReadLine()
        {
            return 100;
        }
    }


    [TestFixture]
    public class GameTest
    {

        [Test]
        public void Test_Method_With_UserAnswer_10_CurrentAnswer_99()
        {
            int CorrentAnswer = 99;
            Game game = new Game(CorrentAnswer);
            var input = new TestConsoleWrapper10();
            var expected = "Too Low";
            var actual = game.ProcessUserInput(input);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Method_With_UserAnswer_99_CurrentAnswer_10()
        {
            int CorrentAnswer = 10;
            Game game = new Game(CorrentAnswer);
            var input = new TestConsoleWrapper99();
            var expected = "Too High";
            var actual = game.ProcessUserInput(input);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Method_With_UserAnswer_100_CurrentAnswer100()
        {
            int CorrentAnswer = 100;
            Game game = new Game(CorrentAnswer);
            var input = new TestConsoleWrapper100();
            var expected = "You win!";
            var actual = game.ProcessUserInput(input);
            Assert.AreEqual(expected, actual);
        }
    }
}