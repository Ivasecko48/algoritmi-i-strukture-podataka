using System;

namespace HashTable{
	public class HashTable{
		public Node[] buckets;
		private int length;
		public HashTable(int length){
			this.length = length;
			buckets = new Node[length];
		}
		public void Display(){
			for (int i = 0; i < length; i++)
            {
                Console.Write($"Bucket {i}: ");
                Node current = buckets[i];
                while (current != null)
                {
                    Console.WriteLine($"[{current.Name}, {current.Value}]");
                    current = current.Next;
                }
				
            }
		}

		private int Hash(string str){
			int hashValue = 0;
			foreach (char c in str)
			{
				hashValue+=c;
			}
			return hashValue%length;
		}

		public void Insert(string name, int value){
			int index = Hash(name);
			Node newNode = new Node(name,value);

			if(buckets[index]==null){
				buckets[index]=newNode;
			}
			else{
				Node current = buckets[index];
				while(current != null){
					current = current.Next;
				}
				current = newNode;
			}
		}

		public int Search(string name){
			int index = Hash(name);
			Node current = buckets[index];

			while (current!=null){
				if(current.Name==name){
					return current.Value;
				}
				current=current.Next;
			}

		throw new Exception($"Node with name '{name}' not found in the hash table.");
		}

		public void Delete(string name){
			int index = Hash(name);
			Node current = buckets[index];

			if(current.Name!= null && current.Name==name){
				buckets[index]=current.Next;
				return;
			}

			Node previous = null;
			while (current != null)
			{
				if (current.Name == name)
				{
					previous.Next = current.Next;
					return;
				}
				
				previous = current;
				current = current.Next;
			}
			throw new Exception($"Node with key '{name}' not found in the hash table.");
		}
	}
}