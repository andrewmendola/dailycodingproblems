using DailyCodingProblems;
using System.Linq;
using Xunit;

namespace SolutionTest
{
	public class ProductArrayTest
	{
		[Fact]
		public void ProductArrayIsValid1()
		{
			var input = new int[] { 1, 2, 3, 4, 5 };
			var expectedOutput = new int[] { 120, 60, 40, 30, 24 };

			Assert.True(Enumerable.SequenceEqual(expectedOutput, ProductArray.GetProductArray(input)));
		}

		[Fact]
		public void ProductArrayIsValid2()
		{
			var input = new int[] { 3, 2, 1 };
			var expectedOutput = new int[] { 2, 3, 6 };

			Assert.True(Enumerable.SequenceEqual(expectedOutput, ProductArray.GetProductArray(input)));
		}
	}
}
