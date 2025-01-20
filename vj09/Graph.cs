using System;
using System.Collections;
using System.Collections.Generics;

namespace ShortestPath{
	public enum DirectionType{Directed,Undirected}
	public class Graph{

		internal Vertex[] vertices;
		PartiallyOrderedTree pot;

		public Graph (int [] nodes) {
			vertices = new Vertex[nodes.Length];
			pot = new PartiallyOrderedTree(this);

			for (int i = 0; i < vertices.Length; i++)
			{
			this.vertices[i] = new Vertex(nodes[i]);
			vertices[i].Index = i + 1;
			}
		}
			public void AddEdge(int source, int destination, double cost,
			 DirectionType direction){

			 }

			 IEnumerator IEnumerable.GetEnumerator()
				{
				foreach (var vertex in vertices)
				yield return vertex;
				}
				public void Display() {
				foreach (var o in this)
				Console.WriteLine(o);

				pot.Display();

				Console.ReadLine();
				}

		public void FindShortestPath(){
			
		}
	}	
}