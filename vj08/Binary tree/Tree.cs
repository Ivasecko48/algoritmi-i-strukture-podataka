using System;

namespace BinaryTree{
	public class Tree{
		private Node root;
		public Tree(){
			root=null;
		}

		public void Insert(int value){
			if (root==null)
			root = new Node(value);
			else
			root.Insert(value);
		}

		public bool Search(int value){
			Node node = Search(root,value);

			if(node.Data!= null)
			return true;
			else
			return false;
		}

		private Node Search(Node current, int value){
			if(current.Data==Null||current.Data==value) 
			return current;

			else if(value<current.Data) 
			return Search(current.left,value);

			else return Search(current.right,value);
		}

		public void Delete(int value){
			Delete(ref root,value);
		}

		private void Delete(ref Node current, int value){

			Node delNode = Search(current,value);
			if(delNode.right!=null&&delNode.left!=null)
			 {DeleteSuccessor(delNode);}else
			delNode = delNode.left;
		}

		private
	}
}