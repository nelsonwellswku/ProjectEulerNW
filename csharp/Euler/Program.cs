using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Euler
{
	class Program
	{
		private const int _tenMillion = 10000000;

		static void Main(string[] args)
		{
			var solver = new Solver();
			WriteIt(7, () => solver.Seven());
			WriteIt(8, () => solver.Eight());
			WriteIt(9, () => solver.Nine());
			WriteIt(10, () => solver.Ten());

			Console.WriteLine("Press any key to exit.");
			Console.ReadKey();
		}

		static void WriteIt(int problemNumber, Func<object> act)
		{
			var stopWatch = new Stopwatch();
			stopWatch.Start();
			var result = act();
			stopWatch.Stop();
			Console.WriteLine("The answer to number {0} is {1}. Calculation time: {2} seconds", problemNumber, result, stopWatch.Elapsed.TotalSeconds);
		}
	}
}
