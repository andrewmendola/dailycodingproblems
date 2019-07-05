using DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace DataStructuresTest
{
	public class MinHeapTest
	{
		[Fact]
		public void Test1()
		{
			var input = new int[] { 16, 42, 12, 0, 10, -5, 800, 44, 55, 33, 9 };
			var expectedOutput = input.OrderBy(i => i).ToArray();
			var heap = new MinHeap<int>(input);

			var output = new List<int>();
			while (heap.Length > 0) {
				output.Add(heap.Pop());
			}

			Assert.True(Enumerable.SequenceEqual(expectedOutput, output));
		}
	}
}
