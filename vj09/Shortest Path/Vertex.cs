using System.Text;
using System.Collections.Generic;

namespace ShortestPath{
	public class Vertex{
		public int Source{get; set;}
		public double Distance{get; set;}
		public int Index{get; set;}
		public List<Edge> neighbours;
		public Vertex(int source){
			this.Source = source;
			this.Distance = double.MaxValue;
			this.neighbours = new List<Edge>();
		}
		public void AddEdge(int number, double cost){
			Edge newEdge = new Edge(number, cost);
			neighbours.Add(newEdge);
		}
		public override string ToString(){

			StringBuilder builder = new StringBuilder ();

			string distance = string.Format ("{0,2}",
			(Distance == double.MaxValue) ? -1.0 : Distance);

			builder.Append("Q" + Index + " N" + Source +
			"(" + distance + ") --> ");

			foreach (var edge in neighbours)
			builder.Append (edge);

			return builder.ToString();
			}
	};
}