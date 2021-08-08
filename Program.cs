using System;

namespace LineComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Line Comparison Computation Program!");
            Distance obj = new Distance(1, 2, 1, 2);
            double LineOne = obj.Compair();
            Console.WriteLine(LineOne);
        }
    }
}