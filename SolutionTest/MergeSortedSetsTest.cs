using DailyCodingProblems;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace SolutionTest
{
	public class MergeSortedSetsTest
	{
		[Fact]
		public void Given()
		{
			var sets = new List<int[]> {
				new int[] { 10, 15, 30 },
				new int[] { 12, 15, 20 },
				new int[] { 17, 20, 32 }
			};
			Assert.True(IsExpectedResult(sets, MergeSortedSets.MergeWithMinHeap));
			Assert.True(IsExpectedResult(sets, MergeSortedSets.MergeWithRecursion));
		}

		[Fact]
		public void EmptyList()
		{
			var sets = new List<int[]> {};
			Assert.True(IsExpectedResult(sets, MergeSortedSets.MergeWithMinHeap));
			Assert.True(IsExpectedResult(sets, MergeSortedSets.MergeWithRecursion));
		}

		[Fact]
		public void EmptyLists()
		{
			var sets = new List<int[]> { new int[0], new int[0], new int[0] };
			Assert.True(IsExpectedResult(sets, MergeSortedSets.MergeWithMinHeap));
			Assert.True(IsExpectedResult(sets, MergeSortedSets.MergeWithRecursion));
		}

		[Fact]
		public void SingleSet()
		{
			var sets = new List<int[]> {
				new int[] { 10, 15, 30 }
			};
			Assert.True(IsExpectedResult(sets, MergeSortedSets.MergeWithMinHeap));
			Assert.True(IsExpectedResult(sets, MergeSortedSets.MergeWithRecursion));
		}

		[Fact]
		public void SingleSetSingleValue()
		{
			var sets = new List<int[]> {
				new int[] { 10 }
			};
			Assert.True(IsExpectedResult(sets, MergeSortedSets.MergeWithMinHeap));
			Assert.True(IsExpectedResult(sets, MergeSortedSets.MergeWithRecursion));
		}

		[Fact]
		public void MultiSetSingleValue()
		{
			var sets = new List<int[]> {
				new int[] { 10 },
				new int[] { 357 },
				new int[] { 25 }
			};
			Assert.True(IsExpectedResult(sets, MergeSortedSets.MergeWithMinHeap));
			Assert.True(IsExpectedResult(sets, MergeSortedSets.MergeWithRecursion));
		}

		[Fact]
		public void MultiSetMultiValues()
		{
			var sets = new List<int[]> {
				new int[] { 623, 2700, 3479, 4327, 5152, 7297, 9171, 9400, 9493, 9650 },
				new int[] { 182, 708, 821, 979, 3876, 4338, 5486, 6669, 7225, 9953 },
				new int[] { 802, 809, 1595, 2395, 2631, 5373, 6425, 6583, 7249, 8826 },
				new int[] { 1219, 2473, 2647, 3450, 4956, 6182, 6199, 6569, 7274, 9438 },
				new int[] { 300, 1224, 1433, 1493, 3133, 6256, 7317, 8355, 8504, 9348 }
			};
			Assert.True(IsExpectedResult(sets, MergeSortedSets.MergeWithMinHeap));
			Assert.True(IsExpectedResult(sets, MergeSortedSets.MergeWithRecursion));
		}

		[Fact]
		public void MultiSetManyValues()
		{
			var sets = new List<int[]> {
				new int[] { 239, 342, 363, 561, 799, 972, 1209, 1223, 1250, 1289, 1392, 1623, 1704, 1724, 1897, 2043, 2103,
					2214, 2278, 2753, 2755, 2792, 2795, 2847, 2862, 2997, 3378, 3567, 3746, 3758, 3778, 3839, 3923, 4160,
					4177, 4234, 4268, 4589, 4631, 4633, 4826, 4942, 5028, 5041, 5167, 5293, 5412, 5527, 5649, 5689, 5697,
					5707, 5768, 5854, 5867, 5895, 5907, 5969, 6226, 6464, 6612, 6648, 6792, 6899, 6917, 6936, 7067, 7073,
					7240, 7414, 7569, 7636, 7667, 7673, 7795, 8027, 8209, 8224, 8234, 8299, 8382, 8396, 8447, 8641, 8655,
					8755, 8887, 8965, 8979, 9007, 9093, 9141, 9307, 9341, 9354, 9374, 9384, 9454, 9491, 9899 },
				new int[] { 124, 184, 256, 280, 327, 395, 404, 459, 521, 561, 710, 719, 795, 902, 931, 1029, 1041, 1104,
					1117, 1399, 1489, 1580, 1594, 1881, 1885, 1944, 1980, 1992, 2077, 2142, 2310, 2340, 2428, 2528, 2530,
					2577, 2694, 2771, 2805, 2874, 2898, 2967, 3218, 3252, 3607, 3619, 3853, 3928, 4068, 4149, 4206, 4360,
					4397, 4430, 4445, 4518, 4552, 4674, 4755, 4844, 4927, 4933, 5049, 5134, 5293, 5342, 5556, 5567, 5589,
					5711, 5752, 6138, 6197, 6302, 6326, 6529, 6792, 6854, 6998, 7321, 7988, 8032, 8154, 8276, 8349, 8464,
					8570, 8823, 8978, 9016, 9039, 9067, 9209, 9261, 9273, 9302, 9499, 9510, 9735, 9847 },
				new int[] { 59, 83, 361, 452, 463, 476, 542, 574, 695, 740, 790, 826, 864, 917, 1093, 1125, 1299, 1411,
					1432, 1575, 1585, 1715, 1776, 1848, 1967, 1977, 2032, 2313, 2604, 2678, 2682, 2818, 3006, 3177, 3217,
					3326, 3729, 3739, 3906, 3909, 3930, 4049, 4119, 4173, 4332, 4335, 4503, 4589, 4610, 4933, 4995, 5147,
					5365, 5376, 5450, 5590, 5597, 5628, 5689, 5707, 5740, 5913, 5919, 5939, 5985, 5987, 6106, 6303, 6692,
					6731, 6772, 6885, 6904, 6907, 7133, 7198, 7201, 7256, 7453, 7463, 7874, 7903, 7994, 8017, 8568, 8643,
					8747, 8807, 8813, 8849, 9021, 9026, 9027, 9272, 9330, 9382, 9454, 9601, 9656, 9764 },
				new int[] { 17, 102, 132, 233, 390, 499, 687, 753, 935, 1087, 1088, 1348, 1396, 1456, 1532, 1889, 1920,
					2034, 2109, 2198, 2246, 2257, 2356, 2361, 2486, 2592, 2701, 2713, 3042, 3279, 3343, 3421, 3430, 3643,
					3833, 3933, 4037, 4144, 4188, 4317, 4333, 4556, 4716, 4737, 4741, 4744, 4902, 4919, 4997, 5166, 5205,
					5244, 5248, 5315, 5359, 5364, 5412, 5438, 5851, 5878, 6000, 6382, 6555, 6673, 6714, 6761, 6849, 6947,
					7079, 7086, 7144, 7222, 7495, 7515, 7606, 7641, 7672, 7855, 7876, 7884, 7925, 8086, 8444, 8484, 8495,
					8574, 8645, 8742, 8944, 8984, 9033, 9057, 9302, 9314, 9347, 9426, 9517, 9530, 9778, 9938 },
				new int[] { 242, 311, 320, 334, 490, 589, 610, 625, 681, 745, 810, 860, 1191, 1196, 1205, 1312, 1372, 1771,
					1838, 2754, 2916, 2953, 3206, 3262, 3279, 3530, 3590, 3774, 3877, 3893, 4259, 4389, 4448, 4652, 4741,
					4756, 4788, 4857, 4929, 5032, 5062, 5139, 5187, 5318, 5597, 5613, 5717, 5788, 5893, 5937, 6124, 6178,
					6197, 6211, 6241, 6289, 6317, 6375, 6421, 6492, 6612, 6648, 6824, 6990, 7043, 7045, 7439, 7477, 7668,
					7717, 7740, 7805, 7857, 8002, 8303, 8352, 8372, 8374, 8421, 8501, 8692, 8700, 8703, 8712, 8756, 8779,
					8893, 8995, 9030, 9034, 9060, 9154, 9160, 9266, 9402, 9428, 9673, 9735, 9922, 9996 }
			};
			Assert.True(IsExpectedResult(sets, MergeSortedSets.MergeWithMinHeap));
			Assert.True(IsExpectedResult(sets, MergeSortedSets.MergeWithRecursion));
		}

		[Fact]
		public void ManySetMultiValues()
		{
			var sets = new List<int[]> {
				new int[] { 882, 1674, 3074, 3344, 4168 },
				new int[] { 2922, 3308, 3967, 6344, 8103 },
				new int[] { 521, 2951, 5410, 5508, 8173 },
				new int[] { 1652, 2526, 2577, 9255, 9834 },
				new int[] { 91, 1153, 7048, 8017, 8127 },
				new int[] { 1774, 2702, 5602, 8454, 9472 },
				new int[] { 1182, 1384, 4629, 5235, 7336 },
				new int[] { 4095, 5198, 6959, 7098, 8822 },
				new int[] { 361, 4204, 4237, 7757, 7935 },
				new int[] { 607, 1372, 1406, 2276, 4558 },
				new int[] { 3956, 4887, 4907, 5626, 6534 },
				new int[] { 1147, 1989, 2624, 9194, 9552 },
				new int[] { 3517, 7132, 8525, 9406, 9624 },
				new int[] { 2396, 4760, 6376, 7539, 9276 },
				new int[] { 3402, 4209, 7942, 9273, 9426 }
			};
			Assert.True(IsExpectedResult(sets, MergeSortedSets.MergeWithMinHeap));
			Assert.True(IsExpectedResult(sets, MergeSortedSets.MergeWithRecursion));
		}

		[Fact]
		public void MultiSetManyDupes()
		{
			var sets = new List<int[]> {
				new int[] { 3, 7, 10, 12, 18, 21, 22, 24, 29, 30 },
				new int[] { 1, 3, 6, 8, 12, 17, 18, 23, 24, 25 },
				new int[] { 3, 4, 9, 15, 17, 18, 20, 25, 28, 30 },
				new int[] { 3, 4, 5, 8, 9, 13, 14, 19, 22, 25 },
				new int[] { 2, 4, 6, 9, 13, 17, 20, 22, 23, 26 }
			};
			Assert.True(IsExpectedResult(sets, MergeSortedSets.MergeWithMinHeap));
			Assert.True(IsExpectedResult(sets, MergeSortedSets.MergeWithRecursion));
		}

		[Fact]
		public void LargeGapInMinSizes()
		{
			var sets = new List<int[]> {
				new int[] { 1, 25, 35, 50 },
				new int[] { 2, 3, 4, 5 }
			};
			Assert.True(IsExpectedResult(sets, MergeSortedSets.MergeWithMinHeap));
			Assert.True(IsExpectedResult(sets, MergeSortedSets.MergeWithRecursion));
		}

		[Fact]
		public void DifferentListSizes()
		{
			var sets = new List<int[]> {
				new int[] { 0 },
				new int[] { },
				new int[] { 3, 4 },
				new int[] { 3, 4, 5, 8, 9, 13, 14, 19, 22, 25 },
				new int[] { 2, 4, 6, 9, 13, 17, 26 }
			};
			Assert.True(IsExpectedResult(sets, MergeSortedSets.MergeWithMinHeap));
			Assert.True(IsExpectedResult(sets, MergeSortedSets.MergeWithRecursion));
		}

		[Fact]
		public void Dupes()
		{
			var sets = new List<int[]> {
				new int[] { 1, 3, 5, 6, 7, 8, 9, 12, 14, 15 },
				new int[] { 2, 3, 4, 5, 6, 9, 10, 12, 14, 15 },
				new int[] { 2, 3, 4, 5, 6, 9, 10, 12, 13, 15 }
			};
			Assert.True(IsExpectedResult(sets, MergeSortedSets.MergeWithMinHeap));
			Assert.True(IsExpectedResult(sets, MergeSortedSets.MergeWithRecursion));
		}

		private int[] GetExpectedOutput(List<int[]> sets)
		{
			return sets.SelectMany(list => list).OrderBy(i => i).ToArray();
		}

		private bool IsExpectedResult(List<int[]> sets, Func<List<int[]>, int[]> method) {
			var expectedOutput = GetExpectedOutput(sets);
			var result = method(sets);
			return Enumerable.SequenceEqual(expectedOutput, result);
		}
	}
}
