using System;

namespace PR14
{
    class Program
    {
        static double funkciya(int n)
        {
            if (n - 3 < 0)
                return Math.Sqrt(n);
            return Math.Sqrt(n + funkciya(n - 3)); 
        }
        static void Main(string[] args)
        {
            double R;
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            R = funkciya(n);
            Console.WriteLine($"R = {R}");
        }
    }
}
