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
		public IEnumerable<ulong> Sieve(ulong n)
		{
			var dictionary = new Dictionary<ulong, MarkedStatus>();
			for(ulong i = 2; i < n; i++)
			{
				dictionary[i] = MarkedStatus.Unmarked;
			}

			ulong p = 2;
			while (p*p < n)
			{
				dictionary = MarkForP(dictionary, p, n);
				p = dictionary.Where(x => x.Key > p && x.Value == MarkedStatus.Unmarked).FirstOrDefault().Key;
			}

			return dictionary.Where(x => x.Value == MarkedStatus.Unmarked).Select(x => x.Key);
		}

		private Dictionary<ulong, MarkedStatus> MarkForP(Dictionary<ulong, MarkedStatus> dictionary, ulong p, ulong max)
		{
			for (ulong pp = p + p; pp < max; pp += p)
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
