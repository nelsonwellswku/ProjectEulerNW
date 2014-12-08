using System.Collections.Generic;
using System.Linq;

namespace Euler.Extensions
{
	public static class IEnumerableExtensions
	{
		public static double Multiply(this IEnumerable<double> list)
		{

			return list.Count() > 0 ? list.Aggregate((x, y) => x * y) : 0;
		}

		public static double Multiply(this IEnumerable<int> list)
		{
			return list.Count() > 0 ? list.Aggregate((x, y) => x * y) : 0;
		}
	}
}
