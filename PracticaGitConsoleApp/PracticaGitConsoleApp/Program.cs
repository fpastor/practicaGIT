namespace PracticaGitConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                CardTest.Test(5);
                Console.WriteLine();
                Console.WriteLine("Press a key to play again...");
                Console.ReadKey();
            }

        }
    }
}
