﻿using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using FluentAssertions;
using Euler;

namespace EulerTests
{
	[TestClass]
	public class PrimeToolsTest
	{
		[TestMethod]
		public void PrimeTools_TestSieve()
		{
			// Arrange
			ulong[] expected = new ulong[] { 2, 3, 5, 7, 11 };
			PrimeTools primeTools = new PrimeTools();

			// Act
			var actual = primeTools.Sieve(13);

			// Assert
			actual.ShouldAllBeEquivalentTo(expected);
		}
	}
}
