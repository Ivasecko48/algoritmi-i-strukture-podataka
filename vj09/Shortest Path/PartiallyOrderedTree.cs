using System;
using System.Collections;

namespace ShortestPath{
	public class PartiallyOrderedTree:IEnumerable{
		internal int[] queue;
		Graph graph;
		public int last;

		public PartiallyOrderedTree(Graph graph){
			this.graph = graph;
			this.last = graph.vertices.Length;
			queue = new int[last + 1];
			queue[0] = -1;

			 for (int i = 1; i <= last; i++)
			{
				queue[i] = i - 1;
			}
		}

		public void Swap(int a, int b){
			int temp = queue[a];
			queue[a]=queue[b];
			queue[b]=temp;
		}

		double GetPriority(int a){
			return graph.vertices[queue[a]].Distance;
		}

		internal void BubbleUp(int index){
				while (index > 1 && GetPriority(index) < GetPriority(index / 2))
		{
			// Swap the element with its parent if its priority is higher (lower distance)
			Swap(index, index / 2);
			index = index / 2; // Move up to the parent
		}
		}

		internal void BubbleDown(int index){
			int child;
			while (index * 2 <= last)
			{
				child = index * 2; // Left child index

				// If there's a right child and it's smaller, choose the right child
				if (child + 1 <= last && GetPriority(child + 1) < GetPriority(child))
				{
					child = child + 1;
				}

				// If the priority of the current node is less than or equal to the priority of the child, stop
				if (GetPriority(index) <= GetPriority(child))
				{
					break;
				}

				// Swap the current node with the child
				Swap(index, child);
				index = child; // Move down to the child	
			}
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			foreach (var priority in queue)
			{
			yield return priority;
			}
		}

		public void Display() {
			Console.Write("Queued: ");
			for (int i = 1; i <= last; i++)
			Console.Write(queue[i] + " ");
			Console.WriteLine();
			Console.Write("Settled: ");
			for (int i = last+1; i < queue.Length; i++)
			Console.Write(queue[i] + " ");
			Console.WriteLine();
		}
	}
}