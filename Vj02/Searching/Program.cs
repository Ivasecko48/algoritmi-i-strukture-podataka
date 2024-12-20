﻿using System;
using System.Diagnostics;
using System.Threading;

namespace Searching{
	class Program{
		static int SequentialSearch(int[] array, int value){
			for (int i = 0; i < array.Length; i++){
				if(array[i] == value)
				return i;
			}
			return -1;
		}

		static int BinarySearch(int[] array, int value){
			int low=0;
			int high=array.Length - 1 ;
			while(low<=high){
				int mid= (low+high)/2;
				if(array[mid]==value) return mid;
				else if (array[mid]<value)
				low=mid + 1;
				else high = mid - 1;
			}
			return -1 ;
		}
		static int BinarySearch(int[] array,int value, int indexL, int indexH){
			if (indexL>indexH)
			return -1;

			int mid = (indexL+indexH)/2;
			if(array[mid]==value) return mid;
			else if (array[mid] < value)
			return BinarySearch(array, value, mid+1, indexH);
			else return BinarySearch(array, value, indexL, mid-1);

		}
		static void Main(){
			int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
			int index = SequentialSearch(array,6);
			Console.WriteLine("index: " + index);
			index = BinarySearch(array,6);
			Console.WriteLine("index: " + index);
			index = BinarySearch(array,6,0,6);
			Console.WriteLine("index: " + index);
		}
		
	}
}