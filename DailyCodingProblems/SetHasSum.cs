﻿/*
	6-27-19	

	Given a list of numbers and a number k, return whether any two numbers from the list add up to k.

	For example, given [10, 15, 3, 7] and k of 17, return true since 10 + 7 is 17.

	Bonus: Can you do this in one pass?
*/

using System.Collections.Generic;

namespace DailyCodingProblems
{
	public static class SetHasSum
	{
		public static bool HasSum(int[] set, int sum) {
			var hash = new HashSet<int>();

			foreach (var num in set) {
				var diff = sum - num;
				if (hash.Contains(diff))
				{
					return true;
				}

				hash.Add(num);
			}

			return false;
		}
	}
}
