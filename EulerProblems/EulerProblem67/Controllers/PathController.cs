using System.Linq;
using EulerProblem67.Interfaces;
using EulerProblem67.Models;

namespace EulerProblem67.Controllers
{
    public class PathController : IPathController
    {
        private readonly IPyramideController _pyramid;
        private readonly INode _startNode;
        private readonly INodePath _path;

        public PathController(IPyramideController pyramid)
        {
            _pyramid = pyramid;
            _startNode = _pyramid.Nodes[0];
            _path = new NodePath();
            CheckValidPath();
        }

        private void CheckValidPath()
        {
            for (var row = _pyramid.Nodes.Max(x => x.RowNr) - 1; row >= 0; row--)
            {
                foreach (var nodes in _pyramid.Nodes.Where(x => x.RowNr == row))
                {
                    var childindex = nodes.Index + nodes.RowNr;

                    var left = _pyramid.Nodes[childindex].Sum;
                    var right = _pyramid.Nodes[childindex + 1].Sum;

                    if (left > right)
                    {
                        _pyramid.Nodes[nodes.Index].AvailablePath.Add(_pyramid.Nodes[childindex]);
                        _pyramid.Nodes[nodes.Index].Sum += left;
                    }
                    else if (right >= left)
                    {
                        _pyramid.Nodes[nodes.Index].AvailablePath.Add(_pyramid.Nodes[childindex+1]);
                        _pyramid.Nodes[nodes.Index].Sum += right;
                    }
                }
            }
        }

        public INodePath GetSuitablePath()
        {
            return GetBigestValuePath(_startNode, _path);
        }
     
        private static INodePath GetBigestValuePath(INode node, INodePath path)
        {
            path.AddNode(node);

            if (node.AvailablePath.Count == 0)
            {
                return path;
            }

            var pathsums = (from n in node.AvailablePath let pathSum = new NodePath() select GetBigestValuePath(n, pathSum)).ToList();

            var maxValuePath = pathsums.OrderByDescending(t => t.Sum).FirstOrDefault();
            if (maxValuePath != null) path.AddNodeRange(maxValuePath.PathNodes);
            return path;
        }
    }
}
