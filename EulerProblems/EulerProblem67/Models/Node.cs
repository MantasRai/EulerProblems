using System;
using System.Collections.Generic;
using EulerProblem67.Interfaces;

namespace EulerProblem67.Models
{
    public class Node : INode
    {
        public int Value { get; set; }
        public int Sum { get; set; }
        public int Index { get; }
        public List<INode> AvailablePath { get; set; }
        public int RowNr { get; private set; }

        public Node(int value, int index)
        {
            Value = value;
            Sum = value;
            Index = index;
            AvailablePath = new List<INode>();
            GetRowNumber();
        }

        private void GetRowNumber()
        {
            // n2 + n - 2i = 0
            // (-1 + √(1 + 8i)) / 2
            RowNr = (int) Math.Truncate((-1 + Math.Sqrt(1 + 8 * Index)) / 2) + 1;
        }
    }
}
