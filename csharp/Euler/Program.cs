using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

namespace Euler
{
	class Program
	{
		private static TimeSpan _tenSeconds = new TimeSpan(0, 0, 10);

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

			foreach (var entry in sortedDictionary)
			{
				WriteIt(entry.Key, entry.Value.Solve);
			}

			Console.WriteLine("\nPress any key to exit.");
			Console.ReadKey();
		}

		static void WriteIt(int problemNumber, Func<object> act)
		{
			var cancellationSource = new CancellationTokenSource();
			var token = cancellationSource.Token;

			var stopWatch = new Stopwatch();
			stopWatch.Start();
			var actionTask = Task.Run(() => act(), token);
			while (!actionTask.IsCompleted)
			{
				if (stopWatch.Elapsed > _tenSeconds)
				{
					Console.WriteLine(string.Format("Number {0} took too long. Skipping.", problemNumber));
					cancellationSource.Cancel();
					return;
				}
			}
			stopWatch.Stop();
			var result = actionTask.Result;
			Console.WriteLine("The answer to number {0} is {1}. Calculation time: {2} seconds", problemNumber, result, stopWatch.Elapsed.TotalSeconds);
		}
	}
}
