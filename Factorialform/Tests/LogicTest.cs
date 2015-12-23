/*
 * User: Igor
 * Date: 12/24/2015
 * Time: 00:07
 */
using System;
using System.Numerics;
using NUnit.Framework;

namespace Factorialform.Tests
{
	[TestFixture]
	public class LogicTest
	{
		[Test]
		[TestCase(0, Result = 1)]
		[TestCase(1, Result = 1)]		
		[TestCase(2, Result = 2)]
		[TestCase(11, Result = 39916800)]
		[TestCase(20, Result = 2432902008176640000)]
		public BigInteger TestFact( int input )
		{
			return Logic.Logic.Factorial( input );
		}
	}
}
