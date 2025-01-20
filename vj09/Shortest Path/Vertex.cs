using System.Text;
using System.Collections.Generics;

namespace ShortestPath{
	public class Vertex{
		public int Source{get; set;};
		public double Distance{get; set;};
		public int Index{get; set;};
		public List<Edge> neighbours;
		public Vertex(int source){
			this.Source = source;
			this.Distance = double 
			this.neighbours = new List<Edge>[] listNeighbours;
		}
		public void AddEdge(int number, double cost){
			newEdge = new Edge(number, cost);
			listNeighbours.Add(newEdge);
		}
		public override string ToString(){

			StringBuilder builder = new StringBuilder ();
			string distance = string.Format ("{0,2}",
			(Distance == double.MaxValue) ? -1.0 : Distance);

			builder.Append("Q" + Index + " N" + Source +
			"(" + distance + ") --> ");
			foreach (var edge in neighbors)
			builder.Append (edge);
			return builder.ToString();
			}
	};
}