using System.Linq;

namespace Euler.Problems
{
	[EulerProblem(7)]
	public class Seven : IEulerProblem
	{
		public object Solve()
		{
			const int tenMillion = 10000000;
			return new PrimeTools()
				.Sieve(tenMillion)
				.Skip(10000)
				.Take(1)
				.First();
		}
	}
}
