using System;

namespace HashTable
{
	public class Node{
		public string Name{
			get; set;
		}
		public int Value{
			get; set;
		}
		public Node Next{
			get; set;
		}

		public Node(string name, int value, Node next=null){
			Name = name;
			Value = value;
			Next = next;
		}
	}
}