using Euler.Properties;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Euler
{
	public class Solver
	{
		// 7
		public double Seven()
		{
			const int tenMillion = 10000000;
			return new PrimeTools()
				.Sieve(tenMillion)
				.Skip(10000)
				.Take(1)
				.First();
		}

		// 8
		public double Eight()
		{
			var thousandDigits = Resources.ThousandDigitNumber;

			// break up into 13 digit chunks
			double max = 0;
			var indexCount = 0;

			foreach (var digit in thousandDigits)
			{
				var chunk = thousandDigits.Skip(indexCount).Take(13).ToList();
				double total = chunk.Select(x => double.Parse(x.ToString())).Aggregate((seed, newValue) => seed * newValue);
				max = total > max ? total : max;

				indexCount++;
			}

			return max;
		}

		// 9
		public int Nine()
		{
			return PythagoreanTriplets()
				.Where(triplets => triplets.Sum() == 1000)
				.Select(triplets => triplets.Aggregate((seed, newValue) => seed * newValue))
				.First();
		}

		private IEnumerable<IEnumerable<int>> PythagoreanTriplets()
		{
			foreach(var a in Enumerable.Range(1, 1000))
			{
				foreach(var b in Enumerable.Range(1, 1000))
				{
					foreach(var c in Enumerable.Range(1, 1000))
					{
						if(((a*a) + (b*b)) == (c*c))
						{
							yield return new[] { a, b, c };
						}
					}
				}
			}
		}

		// 10
		public double Ten()
		{
			const double twoMillion = 2000000;
			return new PrimeTools()
				.Sieve(twoMillion)
				.Sum();
		}
	}
}
