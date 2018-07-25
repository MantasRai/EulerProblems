using EulerProblem67.Controllers;
using NUnit.Framework;

namespace EulerProblem67Tests.Tests
{
    [TestFixture]
    public class PyramidControllerTests
    {
        private static readonly int[] Input =   { 3, 7, 4, 2, 4, 6, 8, 5, 9, 3 };

        [Test]
        public void MatrixController_CreatesNodes_correctAmount()
        {

            var controller = new PyramidController(Input);

            Assert.AreEqual(Input.Length, controller.Nodes.Count);
        }

        [Test]
        public void MatrixController_CreateCorrectValuedNodes_CorrectValue()
        {
            var controller = new PyramidController(Input);

            Assert.AreEqual(Input[0], controller.Nodes[0].Value);
            Assert.AreEqual(Input[1], controller.Nodes[1].Value);
            Assert.AreEqual(Input[2], controller.Nodes[2].Value);
        }

        [Test]
        public void MatrixController_CreateCorrectIndexedNodes_CorrectIndex()
        {
            var controller = new PyramidController(Input);

            Assert.AreEqual(0, controller.Nodes[0].Index);
            Assert.AreEqual(1, controller.Nodes[1].Index);
            Assert.AreEqual(2, controller.Nodes[2].Index);
        }
    }
}

