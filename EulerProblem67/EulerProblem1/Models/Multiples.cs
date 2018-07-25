using System.Collections.Generic;
using System.Linq;
using EulerProblem1.Interfaces;

namespace EulerProblem1.Models
{
    public class Multiples : IMultiples
    {
        public List<int> Values { get; set; }

        public Multiples()
        {
            Values = new List<int>();
        }

        public int GetSum()
        {
            return Values.Sum();
        }
    }
}
