using System;
using System.Collections.Generic;
namespace Comparisons{
	public class Bubble{
		public delegate bool Comparison(object obj1, object obj2);
		
		public static void Sort(object[] array, Comparison compare){
			int n = array.Length;

			for(int i=0; i<n; i++){
				for(int j=0; j< n-i-1; j++){
					if(compare(array[j], array[j+1])){
						object temp=array[j];
						array[j]=array[j+1];
						array[j+1]=temp;
					}
				}
			}
		}
	}
}