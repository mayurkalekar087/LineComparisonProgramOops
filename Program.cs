using System;

namespace LineComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Line Comparison Computation Program!");
            Distance obj = new Distance(1, 2, 1, 2);
            double LineOne = obj.Compare();
            Console.WriteLine(LineOne);

            Distance obj1 = new Distance(1, 2, 1, 2);
            double LineTwo = obj1.Compare();
            Console.WriteLine(LineTwo);

            Distance.Equal(LineOne, LineTwo);

            Distance.CompareTo(LineOne, LineTwo);
        }
    }
}
