using System;
using System.Collections;
using System.Collections.Generic;

namespace ShortestPath{
	public enum DirectionType{Directed,Undirected}
	public class Graph:IEnumerable {

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

				vertices[source].AddEdge(destination,cost);

				if(direction == DirectionType.Undirected){
                vertices[destination].AddEdge(source, cost);
            	}
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

		 public void FindShortestPath()
        {
			if (vertices == null || vertices.Length == 0)
			{
				throw new InvalidOperationException("The graph has no vertices.");
			}

            // Postavi početni čvor na 0 udaljenost
            this.vertices[0].Distance = 0;

            // Kreiraj PartiallyOrderedTree (min-heap) za praćenje čvorova prema prioritetima
            PartiallyOrderedTree pot = new PartiallyOrderedTree(this);

            // Dodaj sve čvorove u prioritetni red
            for (int i = 0; i < vertices.Length; i++)
            {
                pot.BubbleUp(i + 1); // Osiguraj da su svi čvorovi uključeni u prioritetni red
               
            }

            List<int> settled = new List<int>();

                Console.WriteLine("Initial State:");
    Display(); // Show initial state of the graph
            
            while (pot.last >= 1) // Dokle god postoje čvorovi u prioritetnom redu
            {
                // Izvuci čvor s najmanjom udaljenosti (prioritet)
                int currentIndex = pot.queue[1]; // Čvor sa najmanjom udaljenosti je na poziciji 1
                Vertex currentVertex = this.vertices[currentIndex];//trenutni čvor
                pot.Swap(1, pot.last--); // Premjesti zadnji element na početak i smanji veličinu
                pot.BubbleDown(1); // Rekonstruiraj prioritetni red

settled.Add(currentIndex);
 Console.WriteLine($"\nProcessing Vertex: Q{currentVertex.Index} (Source: {currentVertex.Source}, Distance: {currentVertex.Distance})");

                // Obradi susjede trenutnog čvora
                foreach (var edge in currentVertex.neighbours)
                {
                    Vertex neighbor = this.vertices[edge.Destination];

                    // Izračunaj novu potencijalnu udaljenost do susjeda
                    double newDistance = currentVertex.Distance + edge.Cost;

                    // Ako je nova udaljenost manja od trenutne, ažuriraj
                    if (newDistance < neighbor.Distance)
                    {
                        neighbor.Distance = newDistance;

                        // Ažuriraj prioritet u redu
                        // Provjeravamo postoji li već u redu, pa vršimo BubbleUp
                        int neighborIndex = Array.IndexOf(pot.queue, edge.Destination);
                        if (neighborIndex > 0)
                        {
                            pot.BubbleUp(neighborIndex); // Premjesti susjeda gore ako je potrebno
                        }
                         Console.WriteLine($"Updated Distance for Vertex Q{neighbor.Index}: {neighbor.Distance}");
                    }
                }
                        pot.Display();
            }
            Display();
            // Prikaz rezultata
            // foreach (var vertex in this.vertices)
            // {
            //     Console.WriteLine($"Shortest distance to node {vertex.Source}: {vertex.Distance}");
            // }
        }

    }
}