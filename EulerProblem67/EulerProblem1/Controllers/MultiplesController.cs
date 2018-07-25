using EulerProblem1.Interfaces;
using EulerProblem1.Models;

namespace EulerProblem1.Controllers
{
    public class MultiplesController : IMultiplesController
    {
        private readonly IMultiples _multiples;

        public MultiplesController()
        {
            _multiples = new Multiples();
        }

        public IMultiples FindMultiples(int range)
        {
            for (var i = 0; i < range; i++)
            {
                if (i % 3 != 0 && i % 5 != 0) continue;

                _multiples.Values.Add(i);
            }

            return _multiples;
        }
    }
}
