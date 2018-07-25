using EulerProblem1.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace EulerProblem1Tests.Tests
{
    [TestClass]
    public class MultiplesControllerTests
    {
        [TestCase(10, 23)]
        [TestCase(1000, 233168)]
        public void MultiplesController_FindMultiples_CorrectSum(int range, int expectedSum)
        {
            var controller = new MultiplesController();
            var multiples = controller.FindMultiples(range);

            Assert.AreEqual(expectedSum, multiples.GetSum());
        }
    }
}
