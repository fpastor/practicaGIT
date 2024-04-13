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
                Console.WriteLine("Pul$a una tecla para jOgar otra v3z...");
                Console.ReadKey();
            }

        }
    }
}
