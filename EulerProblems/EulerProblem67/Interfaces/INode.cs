using System.Collections.Generic;

namespace EulerProblem67.Interfaces
{
    public interface INode
    {
        int Value { get; set; }
        int Sum { get; set; }
        int Index { get; }
        List<INode> AvailablePath { get; set; }
        int RowNr { get; }
    }
}
