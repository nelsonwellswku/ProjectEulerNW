using System.Collections.Generic;
using System.Linq;

namespace Euler.Extensions
{
	public static class IEnumerableExtensions
	{
		public static ulong Multiply(this IEnumerable<ulong> list)
		{
			return list.Count() > 0 ? list.Aggregate((x, y) => x * y) : 0;
		}

		public static ulong Sum(this IEnumerable<ulong> list)
		{
			return list.Count() > 0 ? list.Aggregate((x, y) => x + y) : 0;
		}
	}
}
