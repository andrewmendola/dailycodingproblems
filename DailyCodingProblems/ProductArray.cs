/*
	6-28-19	

	Given an array of integers, return a new array such that each element at index i of the new array is the product of all the numbers in the original array except the one at i.

	For example, if our input was [1, 2, 3, 4, 5], the expected output would be [120, 60, 40, 30, 24]. If our input was [3, 2, 1], the expected output would be [2, 3, 6].

	Follow-up: what if you can't use division?
*/

using System.Collections.Generic;

namespace DailyCodingProblems
{
	public static class ProductArray
	{
		public static int[] GetProductArray(int[] set) {
			var products = new int[set.Length];
			var output = new int[set.Length];

			if (set.Length == 0) {
				return new int[0];
			}

			products[0] = set[0];
			for (var i = 1; i < set.Length; i++) {
				products[i] = set[i] * products[i - 1];
			}

			var product = 1;
			for (var i = set.Length - 1; i >= 0; i--)
			{
				output[i] = (i > 0 ? products[i - 1] : 1) * product;
				product *= set[i];
			}

			return output;
		}
	}
}
