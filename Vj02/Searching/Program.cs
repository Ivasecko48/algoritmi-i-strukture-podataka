using System;

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
			int l=0;
			int h=array.Length - 1 ;
			while(low<=high){
				int mid= (l+h)/2;
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
			int[] array = { 1, 2, 3, 4, 5, 6, 7 };
			
		}
	}
}