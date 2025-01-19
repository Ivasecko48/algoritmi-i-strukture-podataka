using System;

namespace BinaryTree{
	public class Node{
		public int Data{get; set;}
		public Node left;
		public Node right;

		public Node(int data){
			Data = data;
			left = right = null;
		}

		public void Insert(int value){
			int n = Node.Data;
			if(value<n&&left==null){
				left = new Node(value); 
			}else if(value<n&&left!=null){
				left = Insert(value);
			}else if(value>n&&right=null){
				right = new Node(value);
			}else{
				right = Insert(value);
			}
			
		}
	}
}