using System.Collections.Generic;
using System.Linq;
using Euler.Extensions;

namespace Euler.Problems
{
	[EulerProblem(9)]
	public class Nine : IEulerProblem
	{
		public object Solve()
		{
			return PythagoreanTriplets()
						.First(triplets => triplets.Sum() == 1000)
						.Multiply();
		}

		private IEnumerable<IEnumerable<int>> PythagoreanTriplets()
		{
			foreach (var a in Enumerable.Range(1, 1000))
			{
				foreach (var b in Enumerable.Range(1, 1000))
				{
					foreach (var c in Enumerable.Range(1, 1000))
					{
						if (((a * a) + (b * b)) == (c * c))
						{
							yield return new[] { a, b, c };
						}
					}
				}
			}
		}
	}
}
