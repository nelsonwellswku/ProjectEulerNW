using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Problems
{
	public class Fourteen
	{
		Dictionary<ulong, ulong> _numToCount;
		ulong _oneMillion = 1000000;

		public Fourteen()
		{
			_numToCount = new Dictionary<ulong, ulong>();
		}

		public ulong Solve()
		{
			for (ulong i = 1; i <= _oneMillion; i++)
			{
				_numToCount[i] = GetSequenceFor(i).Aggregate((ulong)0, (seed, next) => seed += 1);
			}

			ulong key = 0;
			ulong maxVal = 0;
			foreach(var item in _numToCount)
			{
				if(item.Value > maxVal)
				{
					maxVal = item.Value;
					key = item.Key;
				}
			}

			return key;
		}

		IEnumerable<ulong> GetSequenceFor(ulong num)
		{
			while(num != 1)
			{
				if (num % 2 == 0)
				{
					num = num / 2;
				}
				else
				{
					num = (3 * num) + 1;
				}

				yield return num;
			}

			yield return 1;
		}
	}
}
