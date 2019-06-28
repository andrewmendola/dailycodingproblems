using DailyCodingProblems;
using Xunit;

namespace SolutionTest
{
	public class SetHasSumTest
	{
		[Theory]
		[InlineData(10, true, 0, 1, 2, 3, 4, 5, 6)]
		[InlineData(20, false, 0, 1, 2, 3, 4, 5, 6)]
		[InlineData(17, true, 10, 15, 3, 7)]
		[InlineData(-1, true, 10, -11, 23, 33, 53, 53, 54)]
		[InlineData(10, false, 10)]
		[InlineData(34, true, 10, -11, 23, 53, 54, 45)]
		[InlineData(0, true, 10, -10)]
		[InlineData(20, false, 10, 20, 30, 40, 50)]
		[InlineData(20, true, 10, 20, 30, 40, 50, 10)]
		public void Test1(int sum, bool hasSum, params int[] set)
		{
			Assert.Equal(hasSum, SetHasSum.HasSum(set, sum));
		}
	}
}
