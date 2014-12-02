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

			Console.WriteLine("#7 is {0}", solver.Seven());

			Console.ReadKey();
		}
	}
}
