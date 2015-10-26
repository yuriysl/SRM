﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
	public class Stack<TValue> : IStack<TValue>
	{
		private BinaryHeap<int, TValue> _binaryHeap;

		public int Count { get { return _binaryHeap.HeapSize; } }

		public Stack()
		{
			_binaryHeap = new BinaryHeap<int, TValue>();
		}

		public TValue Peek()
		{
			return ((IMaxHeap<int, TValue>)_binaryHeap).Max().Value;
		}

		public TValue Pop()
		{
			return ((IMaxHeap<int, TValue>)_binaryHeap).ExtractMax().Value;
		}

		public void Push(TValue value)
		{
			((IMaxHeap<int, TValue>)_binaryHeap).MaxInsert(Count, value);
		}
	}
}