using System.Collections.Generic;
using System.Linq;
using EulerProblem67.Controllers;
using EulerProblem67.Interfaces;
using EulerProblem67.Models;
using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace EulerProblem67Tests.Tests
{
    public class FakeMatrixController : IPyramideController
    {
        public List<INode> Nodes { get; set; }

        public FakeMatrixController(IReadOnlyList<int> inputArray)
        {
            CreateNodes(inputArray);
        }

        private void CreateNodes(IReadOnlyList<int> inputArray)
        {
            Nodes = new List<INode>();

            for (var i = 0; i < inputArray.Count; i++)
            {
                Nodes.Add(new Node(inputArray[i], i));
            }
        }
    }

    [TestFixture]
    public class PathControllerTests
    {
        [TestCase("3 7 4 2 4 6 8 5 9 3", 23)]
        public void PathController_CalculateBestPath_MatchesExpectedSum(string input, int expected)
        {
            IPyramideController matrix = new FakeMatrixController(CreateNodeValues(input));

            var path = new PathController(matrix);
            var pathTaken = path.GetSuitablePath();

            Assert.AreEqual(expected, pathTaken.Sum);
        }

        private static int[] CreateNodeValues(string input)
        {
            return input.Split(' ').Select(int.Parse).ToArray();
        }
    }
}
