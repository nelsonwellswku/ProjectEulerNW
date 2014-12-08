using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;

namespace Euler
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Gathering problems to run...");
			var numberToInstanceDict = Assembly.GetExecutingAssembly()
				.DefinedTypes
				.Where(t => t.ImplementedInterfaces.Contains(typeof(IEulerProblem)))
				.Where(t => t.GetCustomAttribute<EulerProblemAttribute>() != null)
				.OrderBy(t => t.GetCustomAttribute<EulerProblemAttribute>().ProblemNumber)
				.ToDictionary(t => t.GetCustomAttribute<EulerProblemAttribute>().ProblemNumber,
							  t => Activator.CreateInstance(t) as IEulerProblem);
			var sortedDictionary = new SortedDictionary<int, IEulerProblem>(numberToInstanceDict);
			Console.WriteLine("Problems gathered.\n");

			foreach(var entry in sortedDictionary)
			{
				WriteIt(entry.Key, entry.Value.Solve);
			}

			Console.WriteLine("\nPress any key to exit.");
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
