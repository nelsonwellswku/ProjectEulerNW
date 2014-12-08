using System.Linq;
using Euler.Extensions;

namespace Euler.Problems
{
	[EulerProblem(10)]
	public class Ten : IEulerProblem
	{
		public object Solve()
		{
			const ulong twoMillion = 2000000;
			return new PrimeTools()
				.Sieve(twoMillion)
				.Sum();
		}
	}
}
