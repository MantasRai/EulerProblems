using EulerProblem67.Interfaces;
using EulerProblem67.Models;
using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace EulerProblem67Tests.Tests
{
    [TestFixture]
    public class NodeTests
    {
        [TestCase(0, 1)]
        [TestCase(1, 2)]
        [TestCase(2, 2)]
        [TestCase(3, 3)]
        public void NodeModel_CalculateCorretRow_rowMatchesExpected(int index, int expectedResult)
        {
            INode node = new Node(0, index);

            Assert.AreEqual(expectedResult, node.RowNr);
        }
    }
}
