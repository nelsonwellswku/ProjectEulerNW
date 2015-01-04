using Euler.Problems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;

namespace EulerTests
{
	[TestClass]
	public class ProblemTests
	{
		[TestMethod]
		public void Eight()
		{
			var problem = new Eight();
			var result = (ulong)problem.Solve();
			result.Should().Be(23514624000);
		}

		[TestMethod]
		public void Nine()
		{
			var problem = new Nine();
			var result = (ulong)problem.Solve();
			result.Should().Be(31875000);
		}

		[TestMethod]
		public void Ten()
		{
			var problem = new Ten();
			var result = (ulong)problem.Solve();
			result.Should().Be(142913828922);
		}

		[TestMethod]
		public void Eleven()
		{
			var problem = new Eleven();
			var result = (ulong)problem.Solve();
			result.Should().Be(70600674);
		}

		[TestMethod]
		public void Twelve()
		{
			var problem = new Twelve();
			var result = (int)problem.Solve();
			result.Should().Be(76576500);
		}

		[TestMethod]
		public void Thirteen()
		{
			var problem = new Thirteen();
			var result = (double)problem.Solve();
			result.Should().Be(5537376230);
		}

		[TestMethod]
		public void Fourteen()
		{
			var problem = new Fourteen();
			var result = problem.Solve();
			result.Should().Be(837799);
		}
	}
}
