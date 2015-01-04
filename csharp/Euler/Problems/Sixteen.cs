using System;
using System.Linq;
using System.Numerics;

namespace Euler.Problems
{
	public class Sixteen
	{
		public int Solve()
		{
			var twoToTheThousand = Math.Pow(2, 1000);
			var big = new BigInteger(twoToTheThousand);

			var sum = big.ToString().Select(x => int.Parse(x.ToString())).Sum();
			return sum;
		}
	}
}
