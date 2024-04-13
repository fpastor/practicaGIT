

namespace PracticaGitConsoleApp
{
    public class Utils
    {
        private static Random r = new Random();

        public static double GetRandom()
        {
            return r.NextDouble();
        }

        public static double GetRandom(double min, double max)
        {
            double r = GetRandom();
            double v = r * (max - min);
            return v + min;
        }

    }
}
