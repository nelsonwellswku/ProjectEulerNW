using System.Collections.Generic;
using System.Linq;

namespace Euler.Extensions
{
	public static class IEnumerableExtensions
	{
		public static double Multiply(this IEnumerable<double> list)
		{
			return list.Aggregate((x, y) => x * y);
		}

		public static double Multiply(this IEnumerable<int> list)
		{
			return list.Aggregate((x, y) => x * y);
		}
	}
}
