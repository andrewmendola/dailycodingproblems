using DailyCodingProblems;
using System.Linq;
using Xunit;

namespace SolutionTest
{
	public class FirstPositiveIntegerTest
	{
		[Fact]
		public void Test1()
		{
			Evaluate(new int[] { 3, 4, -1, 1 }, 2);
		}

		[Fact]
		public void Test2()
		{
			Evaluate(new int[] { 1, 2, 0 }, 3);
		}

		[Fact]
		public void Test3()
		{
			Evaluate(new int[] { 1, 2, 0, 4, 10, -9, -100 }, 3);
		}

		[Fact]
		public void Test4()
		{
			Evaluate(new int[] { 0 }, 1);
		}

		[Fact]
		public void Test5()
		{
			Evaluate(new int[] { -1, 0, -100 }, 1);
		}

		[Fact]
		public void Test6()
		{
			Evaluate(new int[] { 1, 2, 3, 5 }, 4);
		}

		[Fact]
		public void Test7()
		{
			Evaluate(new int[0], 1);
		}

		private void Evaluate(int[] set, int expected) {
			Assert.Equal(expected, FirstPositiveInteger.FindFirstPositiveInteger(set));
		}
	}
}
