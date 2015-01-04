using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Euler.Problems
{
	[EulerProblem(12)]
	public class Twelve : IEulerProblem
	{
		public object Solve()
		{
			int answer = 0;
			CancellationTokenSource tokenSource = new CancellationTokenSource();

			var options = new ParallelOptions() { CancellationToken = tokenSource.Token, MaxDegreeOfParallelism = 4 };

			try
			{
				Parallel.ForEach(TriangleNumbers().Skip(500), options, num =>
				{
					var count = Divisors(num).Count();
					if (count > 500)
					{
						tokenSource.Cancel();
						answer = num;
					}
				});
			}
			catch (OperationCanceledException)
			{
				// no op
			}

			return answer;
		}

		private IEnumerable<int> TriangleNumbers()
		{
			foreach (var num in Enumerable.Range(1, int.MaxValue))
			{
				var triangleNumber = Enumerable.Range(1, num - 1).Sum();
				yield return triangleNumber;
			}
		}

		private IEnumerable<int> Divisors(int number)
		{
			foreach (var potentialDivisor in Enumerable.Range(1, (number / 2) + 1))
			{
				if (number % potentialDivisor == 0)
				{
					yield return potentialDivisor;
				}
			}
		}
	}
}
