using System;

namespace CounterChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input:");
            string input = Console.ReadLine();

            CounterChallenge counterChallenge = new CounterChallenge();
            string output = counterChallenge.GetOutput(input);

            Console.WriteLine();
            Console.WriteLine("Output:");
            Console.WriteLine(output);
        }
    }
}