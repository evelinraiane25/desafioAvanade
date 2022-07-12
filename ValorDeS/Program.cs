using System;

namespace ValorDeS
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, s = 0;

            for (a = 1; a <= 100; a++)
            {
                s+= 1 / a;
            }

            var x = Math.Round(s, 2);

            Console.WriteLine(x);
        }
    }
}
