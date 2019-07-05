using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructures
{
	public class MinHeap<T> where T : IComparable<T>
	{
		private T[] set;
		private int capacity = 10;

		public MinHeap(IEnumerable<T> set)
		{
			this.set = set.ToArray();
			Size = this.set.Length;
			capacity = Size;

			Heapify();
		}

		public int Length => Size;

		private int Size { get; set; } = 0;

		public MinHeap()
		{
			set = new T[capacity];
		}

		public T Peek()
		{
			if (set.Length == 0)
			{
				throw new Exception("Heap is Empty!");
			}

			return set[0];
		}

		public T Pop()
		{
			if (set.Length == 0)
			{
				throw new Exception("Heap is Empty!");
			}

			var num = set[0];
			set[0] = set[Size - 1];
			Size--;
			HeapifyDown();

			return num;
		}

		public void Push(T num)
		{
			EnsureCapacity();
			set[Size] = num;
			Size++;
			HeapifyUp();
		}

		private void EnsureCapacity()
		{
			if (Size == capacity)
			{
				Array.Resize(ref set, capacity * 2);
				capacity *= 2;
			}
		}

		private int GetLeftChildIndex(int parentIndex) { return 2 * parentIndex + 1; }
		private int GetRightChildIndex(int parentIndex) { return 2 * parentIndex + 2; }
		private int GetParentIndex(int childIndex) { return (childIndex - 1) / 2; }

		private T GetLeftChild(int index) { return set[GetLeftChildIndex(index)]; }
		private T GetRightChild(int index) { return set[GetRightChildIndex(index)]; }
		private T GetParent(int index) { return set[GetParentIndex(index)]; }

		private bool HasLeftChild(int index) { return GetLeftChildIndex(index) < Size; }
		private bool HasRightChild(int index) { return GetRightChildIndex(index) < Size; }
		private bool HasParent(int index) { return GetParentIndex(index) >= 0; }

		private void Heapify()
		{
			for (int i = Size - 1; i >= 0; i--)
			{
				if (HasLeftChild(i))
				{
					HeapifyDown(i);
				}
			}
		}

		private void HeapifyDown(int index = 0)
		{
			while (HasLeftChild(index))
			{
				var smallerChildIndex = GetLeftChildIndex(index);
				if (HasRightChild(index) && GetRightChild(index).CompareTo(GetLeftChild(index)) < 0)
				{
					smallerChildIndex = GetRightChildIndex(index);
				}

				if (set[index].CompareTo(set[smallerChildIndex]) > 0)
				{
					Swap(index, smallerChildIndex);
				}
				else
				{
					break;
				}

				index = smallerChildIndex;
			}
		}

		private void HeapifyUp()
		{
			var index = Size - 1;
			while (HasParent(index) && GetParent(index).CompareTo(set[index]) > 0)
			{
				Swap(index, GetParentIndex(index));
				index = GetParentIndex(index);
			}
		}

		private void Swap(int indexA, int indexB)
		{
			var temp = set[indexA];
			set[indexA] = set[indexB];
			set[indexB] = temp;
		}
	}
}
