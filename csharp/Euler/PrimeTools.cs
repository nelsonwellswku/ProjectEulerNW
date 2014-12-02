using System.Collections.Generic;
using System.Linq;

namespace Euler
{
	public class PrimeTools
	{
		/// <summary>
		/// Find all prime numbers less than n
		/// </summary>
		/// <param name="n"></param>
		/// <returns>IEnumerable of prime numbers</returns>
		public IEnumerable<double> Sieve(double n)
		{
			var dictionary = new Dictionary<double, MarkedStatus>();
			for(int i = 2; i < n; i++)
			{
				dictionary[i] = MarkedStatus.Unmarked;
			}

			double p = 2;
			while (p*p < n)
			{
				dictionary = MarkForP(dictionary, p, n);
				p = dictionary.Where(x => x.Key > p && x.Value == MarkedStatus.Unmarked).FirstOrDefault().Key;
			}

			return dictionary.Where(x => x.Value == MarkedStatus.Unmarked).Select(x => x.Key);
		}

		private Dictionary<double, MarkedStatus> MarkForP(Dictionary<double, MarkedStatus> dictionary, double p, double max)
		{
			for (double pp = p + p; pp < max; pp += p)
			{
				dictionary[pp] = MarkedStatus.Marked;
			}

			return dictionary;
		}

		private enum MarkedStatus
		{
			Unmarked,
			Marked
		}
	}
}
