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
                Console.WriteLine("Pulsa una tecla para jugar otra vez...");
                Console.ReadKey();
            }

        }
    }
}
