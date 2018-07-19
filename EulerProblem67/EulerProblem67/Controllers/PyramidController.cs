using System.Collections.Generic;
using EulerProblem67.Interfaces;
using EulerProblem67.Models;

namespace EulerProblem67.Controllers
{
    public class PyramidController : IPyramideController
    {
        public List<INode> Nodes { get; private set; }

        public PyramidController(int[] inputArray)
        {
            CreateNodes(inputArray);
        }

        private void CreateNodes(int[] inputArray)
        {
            Nodes = new List<INode>();

            for (var i = 0; i < inputArray.Length; i++)
            {
                Nodes.Add(new Node(inputArray[i], i));
            }
        }
    }
}
