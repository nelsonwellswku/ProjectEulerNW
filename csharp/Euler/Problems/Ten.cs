using System.Linq;

namespace Euler.Problems
{
	[EulerProblem(10)]
	public class Ten : IEulerProblem
	{
		public object Solve()
		{
			const double twoMillion = 2000000;
			return new PrimeTools()
				.Sieve(twoMillion)
				.Sum();
		}
	}
}
