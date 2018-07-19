using System.Collections.Generic;
using System.Linq;
using EulerProblem67.Interfaces;

namespace EulerProblem67.Models
{
    public class NodePath : INodePath
    {
        public List<INode> PathNodes { get; set; }
        public int Sum { get; set; }

        public NodePath()
        {
            PathNodes = new List<INode>();
            Sum = 0;
        }

        public void AddNode(INode node)
        {
            PathNodes.Add(node);
            Sum = Sum + node.Value;
        }

        public void AddNodeRange(IEnumerable<INode> nodeRange)
        {
            var collection = nodeRange as INode[] ?? nodeRange.ToArray();
            PathNodes.AddRange(collection);
            Sum += collection.Sum(x => x.Value);
        }
    }
}
