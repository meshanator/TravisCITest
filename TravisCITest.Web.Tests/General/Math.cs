using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TravisCITest.Web.Tests.General
{
	[TestClass]
	public class Math
	{
		[TestMethod]
		public void TestMethod1()
		{
			var first = 1;
			var second = 2;
			Assert.AreEqual(first + second, 3);
		}
	}
}
