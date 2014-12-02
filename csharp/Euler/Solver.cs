using Euler.Properties;
using System.Linq;

namespace Euler
{
	public class Solver
	{
		// 7
		public int Seven()
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
	}
}
