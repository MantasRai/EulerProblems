using System.Collections.Generic;

namespace EulerProblem1.Interfaces
{
    public interface IMultiples
    {
        List<int> Values { get; set; }
        int GetSum();
    }
}
