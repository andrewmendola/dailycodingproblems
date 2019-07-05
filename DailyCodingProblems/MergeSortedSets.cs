/*
	7-1-2019
	Return a new sorted merged list from K sorted lists, each with size N.

	For example, if we had [[10, 15, 30], [12, 15, 20], [17, 20, 32]], 
	the result should be [10, 12, 15, 15, 17, 20, 20, 30, 32].
*/

using DataStructures;
using System;
using System.Collections.Generic;

namespace DailyCodingProblems
{
	public class MergeSortedSets
	{
		public static int[] MergeWithMinHeap(List<int[]> set)
		{
			if (set.Count == 0) {
				return new int[0];
			}

			if (set.Count == 1) {
				return set[0];
			}

			var heap = new MinHeap<Node>();
			for (int i = 0; i < set.Count; i++)
			{
				if (set[i].Length > 0)
				{
					heap.Push(new Node
					{
						Value = set[i][0],
						ArrayIndex = i,
						ValueIndex = 0
					});
				}
			}

			var result = new List<int>();
			while (heap.Length > 0) {
				var node = heap.Pop();
				result.Add(node.Value);

				if (node.ValueIndex + 1 < set[node.ArrayIndex].Length) {
					heap.Push(new Node
					{
						Value = set[node.ArrayIndex][node.ValueIndex + 1],
						ArrayIndex = node.ArrayIndex,
						ValueIndex = node.ValueIndex + 1
					});
				}
			}

			return result.ToArray();
		}

		public static int[] MergeWithRecursion(List<int[]> set)
		{
			if (set.Count == 0) {
				return new int[0];
			}

			if (set.Count == 1) {
				return set[0];
			}

			if (set.Count == 2)
			{
				return Merge(set[0], set[1]);
			}

			var index = 0;
			var sets = new List<int[]>();
			while (index < set.Count) {
				if (index + 1 < set.Count)
				{
					sets.Add(Merge(set[index], set[index + 1]));
					index += 2;
				}
				else {
					sets.Add(set[index]);
					index++;
				}
			}

			return MergeWithRecursion(sets);
		}

		private static int[] Merge(int[] setA, int[] setB) {
			var result = new int[setA.Length + setB.Length];
			var indexA = 0;
			var indexB = 0;
			var index = 0;

			while (indexA < setA.Length || indexB < setB.Length)
			{
				if (indexA == setA.Length || (indexB < setB.Length && setA[indexA] > setB[indexB]))
				{
					result[index] = setB[indexB];
					indexB++;
				}
				else
				{
					result[index] = setA[indexA];
					indexA++;
				}

				index++;
			}

			return result;
		}

		class Node : IComparable<Node>
		{
			public int Value { get; set; }

			public int ValueIndex { get; set; }

			public int ArrayIndex { get; set; }

			public int CompareTo(Node other)
			{
				return this.Value.CompareTo(other.Value);
			}
		}
	}
}
