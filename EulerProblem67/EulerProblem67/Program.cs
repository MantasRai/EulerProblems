using System;
using System.Linq;
using System.Text.RegularExpressions;
using EulerProblem67.Controllers;
using EulerProblem67.Interfaces;

namespace EulerProblem67
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            IPyramideController pyramid = new PyramidController(GetInputValues());
            IPathController pathController = new PathController(pyramid);

            var path = pathController.GetSuitablePath();

            watch.Stop();

            Console.WriteLine("Result: " + path.Sum);
            var output = "That is, ";

            for (var i = 0; i < path.PathNodes.Count; i++)
            {
                output += path.PathNodes[i].Value;
                if (i < path.PathNodes.Count - 1)
                {
                    output += " + ";
                }
            }

            output += $" = {path.Sum}";

            Console.WriteLine(output);
            Console.WriteLine($"It tooked: {watch.ElapsedMilliseconds}ms");
            Console.ReadLine();
        }

        private static int[] GetInputValues()
        {
            //var inputString = System.IO.File.ReadAllText(@"Inputs\Problem18.txt");
            var inputString = System.IO.File.ReadAllText(@"Inputs\Problem67.txt");
            var input = Regex.Replace(inputString, @"\r\n?|\n", " ");
            input = Regex.Replace(input, "[ ]{2,}", " ");

            return input.Split(' ').Select(int.Parse).ToArray();
        }
    }
}