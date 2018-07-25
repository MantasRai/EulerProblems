using EulerProblem1.Interfaces;
using EulerProblem1.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace EulerProblem1Tests.Tests
{
    [TestClass]
    public class MultiplesTests
    {
        [Test]
        public void MultiplesModel_InitialValues_CorrectDefaultValues()
        {
            IMultiples multiples = new Multiples();
            
            Assert.AreEqual(0, multiples.Values.Count);
            Assert.AreEqual(0, multiples.GetSum());
        }

        [Test]
        public void MultiplesModel_AddingMultipleMultiples_SumAndListCountIsCorrect()
        {
            IMultiples multiples = new Multiples();

            multiples.Values.Add(4);
            multiples.Values.Add(6);

            Assert.AreEqual(2, multiples.Values.Count);
            Assert.AreEqual(10, multiples.GetSum());
        }
    }
}
