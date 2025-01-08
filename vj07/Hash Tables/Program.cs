using System;

namespace HashTable{
	public class program{
			static void Main(){
			HashTable hashTable = new HashTable(9);
			hashTable.Insert("Iva",2);
			hashTable.Insert("Kim",3);
			hashTable.Insert("Ana",1);
			hashTable.Insert("Tea",9);
			hashTable.Insert("Lea",6);
			hashTable.Insert("Bob",4);
			hashTable.Insert("Ivo",5);
			hashTable.Insert("Ena",8);
			hashTable.Insert("Joe",7);

			hashTable.Display();

			try
			{
				Console.WriteLine($"Value of 'Bob': {hashTable.Search("Bob")}");
				hashTable.Delete("Bob");
				hashTable.Display();
				hashTable.Delete("Dave"); // Will throw exception
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
	}
}