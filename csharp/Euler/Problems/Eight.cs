using Euler.Properties;
using System.Linq;
using Euler.Extensions;

namespace Euler.Problems
{
	[EulerProblem(8)]
	public class Eight : IEulerProblem
	{
		public object Solve()
		{
			var thousandDigits = Resources.ThousandDigitNumber;

			// break up into 13 digit chunks
			ulong max = 0;
			var indexCount = 0;

			foreach (var digit in thousandDigits)
			{
				var chunk = thousandDigits.Skip(indexCount).Take(13).ToList();
				ulong total = chunk.Select(x => ulong.Parse(x.ToString())).Multiply();
				max = total > max ? total : max;

				indexCount++;
			}

			return max;
		}
	}
}
