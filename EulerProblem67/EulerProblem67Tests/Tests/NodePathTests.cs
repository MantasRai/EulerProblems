using System.Collections.Generic;
using EulerProblem67.Interfaces;
using EulerProblem67.Models;
using EulerProblem67Tests.Helpers;
using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace EulerProblem67Tests.Tests
{
    [TestFixture]
    public class NodePathTests
    {
        [Test]
        public void NodePathModel_InitialValues_MatchDefaults()
        {
            INodePath nodePath = new NodePath();

            Assert.AreEqual(0, nodePath.Sum);
            Assert.AreEqual(0, nodePath.PathNodes.Count);
        }

        [Test]
        public void NodePathModel_addingSingleNode_SumIsCorrect()
        {
            INode node = new MockNode
            {
                Value = 3
            };

            INodePath nodePath = new NodePath();
            nodePath.AddNode(node);

            Assert.AreEqual(node.Value, nodePath.Sum);
        }

        [Test]
        public void NodePathModel_addingMultipleNodes_SumIsCorrect()
        {
            INode nodeOne = new MockNode { Value = 7 };
            INode nodeTwo = new MockNode { Value = 4 };

            INodePath nodePath = new NodePath();
            var expectedTotal = nodeOne.Value + nodeTwo.Value;

            nodePath.AddNode(nodeOne);
            nodePath.AddNode(nodeTwo);

            Assert.AreEqual(expectedTotal, nodePath.Sum);
            Assert.AreEqual(2, nodePath.PathNodes.Count);
        }

        [Test]
        public void NodePathModel_AddingNodeRange_SumIsCorrect()
        {
            INode nodeOne = new MockNode { Value = 7 };
            INode nodeTwo = new MockNode { Value = 4 };

            var nodeRange = new List<INode> {nodeOne, nodeTwo};
            var expectedTotal = nodeOne.Value + nodeTwo.Value;

            INodePath nodePath = new NodePath();
            nodePath.AddNodeRange(nodeRange);

            Assert.AreEqual(expectedTotal, nodePath.Sum);
            Assert.AreEqual(2, nodePath.PathNodes.Count);
        }
    }
}