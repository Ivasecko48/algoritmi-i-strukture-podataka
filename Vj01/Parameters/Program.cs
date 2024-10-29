using System;

namespace Parameters
{
	public class Program{
		public static void Swap (ref int a, ref int b){
		int temp=a;
		a=b;
		b=temp;
	}

	public static void Main(){
		int a=1;
		int b=2;
		Console.WriteLine("Vrijednosti varijabli:");
		Console.WriteLine("a=" + a + ", b=" + b);
		Swap(ref a,ref b);
		Console.WriteLine("Vrijednosti varijabli nakon promjene:");
		Console.WriteLine("a=" + a + ", b=" + b);
	
		int[] array = {2,3,4,1,8,6,5,7};
		Console.WriteLine("Niz prije:");
		foreach(int i in array){
			Console.Write(i + ",");
		}

		Swap(ref array[2], ref array[3]);
		Console.WriteLine("Niz poslije:");
		foreach(int i in array){
			Console.Write(i + ",");
		}
	}
  }
}