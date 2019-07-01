/*
	Given an array of integers, find the first missing positive integer in linear time and constant space.
	In other words, find the lowest positive integer that does not exist in the array.
	The array can contain duplicates and negative numbers as well.

	For example, the input [3, 4, -1, 1] should give 2. The input [1, 2, 0] should give 3.

	You can modify the input array in-place.
*/

using System;

namespace DailyCodingProblems
{
	public class FirstPositiveInteger
	{
		public static int FindFirstPositiveInteger(int[] set)
		{
			var start = OffsetNegatives(set);

			for (var i = start; i < set.Length; i++) {
				var num = Math.Abs(set[i]);
				if (num <= set.Length - start)
				{
					var index = start + num - 1;
					if (index >= 0)
					{
						set[index] = -1 * Math.Abs(set[index]);
					}
				}
			}

			for (var i = start; i < set.Length; i++)
			{
				if (set[i] > 0) {
					return i - start + 1;
				}
			}

			return set.Length - start + 1;
		}

		private static int OffsetNegatives(int[] set) {
			var j = 0;
			for (int i = 0; i < set.Length; i++) {
				if (set[i] <= 0) {
					var temp = set[i];
					set[i] = set[j];
					set[j] = temp;
					j++;
				}
			}

			return j;
		}
	}
}
