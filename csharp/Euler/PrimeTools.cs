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
		public IEnumerable<int> Sieve(int n)
		{
			var dictionary = new Dictionary<int, MarkedStatus>();
			for(int i = 2; i < n; i++)
			{
				dictionary[i] = MarkedStatus.Unmarked;
			}

			int p = 2;
			while (p*p < n)
			{
				dictionary = MarkForP(dictionary, p, n);
				p = dictionary.Where(x => x.Key > p && x.Value == MarkedStatus.Unmarked).FirstOrDefault().Key;
			}

			return dictionary.Where(x => x.Value == MarkedStatus.Unmarked).Select(x => x.Key);
		}

		private Dictionary<int, MarkedStatus> MarkForP(Dictionary<int, MarkedStatus> dictionary, int p, int max)
		{
			for (int pp = p + p; pp < max; pp += p)
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
