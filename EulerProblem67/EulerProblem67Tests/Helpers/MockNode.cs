using System;
using System.Collections.Generic;
using EulerProblem67.Interfaces;

namespace EulerProblem67Tests.Helpers
{

    public class MockNode : INode
    {
        public int Value { get; set; }
        public int Sum { get; set; }
        public int Index { get; set; }
        public List<INode> AvailablePath { get; set; }

        public int RowNr => GetRowNumber();

        private static int GetRowNumber()
        {
            // No need to mock it
            throw new NotImplementedException();
        }
    }
}