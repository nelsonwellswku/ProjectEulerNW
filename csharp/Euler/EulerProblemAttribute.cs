using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
	[AttributeUsage(AttributeTargets.Class)]
	public class EulerProblemAttribute : Attribute
	{
		public int ProblemNumber { get; set; }

		public EulerProblemAttribute(int problemNumber)
		{
			ProblemNumber = problemNumber;
		}
	}
}
