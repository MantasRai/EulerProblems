using System;
using EulerProblem1.Controllers;
using EulerProblem1.Interfaces;

namespace EulerProblem1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Solving Euler problem: 1");

            IMultiplesController multiplesController = new MultiplesController();
            var multiples = multiplesController.FindMultiples(1000);

            var watch = System.Diagnostics.Stopwatch.StartNew();

            Console.WriteLine("Result: " + multiples.GetSum());
            Console.WriteLine($"It tooked: {watch.ElapsedMilliseconds}ms");

            Console.ReadLine();
        }
    }
}
