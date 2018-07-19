using System.Collections.Generic;

namespace EulerProblem67.Interfaces
{
    public interface INodePath
    {
        List<INode> PathNodes { get; set; }
        int Sum { get; set; }
        void AddNode(INode node);
        void AddNodeRange(IEnumerable<INode> nodeRange);
    }
}
