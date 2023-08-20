namespace LeetCodeAlgorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsNumber("0"));
        }
        public static bool IsNumber(string s)
        {
            if (s == "Infinity" || s == "-Infinity" || s == "+Infinity") return false;
            double o;
            if (double.TryParse(s, out o))
            {
                return !Double.IsNaN(o);
            }
            return false;
        }

    }
}