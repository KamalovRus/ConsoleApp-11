using System;

namespace Task11
{
    class Program
    {
        static void Main(string[] args)
        {
            LinearEquation eq1 = new LinearEquation(0,12);
            Console.WriteLine(eq1.Root());
            LinearEquation eq2 = new LinearEquation();
            eq2.K = 15;
            eq2.B = 3;
            Console.WriteLine(eq2.Root());
            Console.ReadKey();
        }
    }
    public struct LinearEquation
    {
        public LinearEquation(double k, double b)
        {
            K = k;
            B = b;
        }
        public double K { get; set; }
        public double B { get; set; }
        public double Root()
        {
            if(K == 0)
            {
                Console.WriteLine("Корней нет!");
                return 0;
            }
            Console.Write("Корень есть: ");
            return -B / K;
        }
    }
}
