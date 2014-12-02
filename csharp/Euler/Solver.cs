using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
	}
}
