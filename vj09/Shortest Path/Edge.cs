using System;

namespace ShortestPath{
	public class Edge{
		public int Destination{get; set;}
		public double Cost{get; set;}

		public Edge(int destination, double cost){
			this.Destination = destination;
			this.Cost = cost;
		}
		public override string ToString(){
			return $"[{Destination}, {Cost}]";
		}
	};
}