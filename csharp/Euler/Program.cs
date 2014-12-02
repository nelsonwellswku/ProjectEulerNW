using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

			Console.ReadKey();
		}

		static void WriteIt(int problemNumber, Func<object> act)
		{
			Console.WriteLine("The answer to number {0} is {1}", problemNumber, act());
		}
	}
}
