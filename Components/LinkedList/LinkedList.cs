// using System.Runtime.CompilerServices;

// public class LinkedList {

//     public Node? First{get;set;}

//     public Node converArr2LL(int[] arr){
//         Node head = new Node();
//         head.Data = arr[0];
//         Node mover = head;
//         for(int i = 1; i< arr.Length;i+ +){
//             Node temp = new Node();
//             temp.Data =arr[i];
//             mover.Next = temp;
//         } 

//         return head;
        
//     }
// //Inserting a the head of linked list 
//     public void InsertFirst(int data){
//         //Create a node 
//         Node newNode = new Node();
//         //Put the data in the data 
//         newNode.Data = data;
//         //Put the old node to in new node. 
//         newNode.Next = First;
//     }
// //Deleted a head of linked list. 
//     public Node DeleteFirst(){
//         //Assign the temp variable 
//         Node temp = First;

//         //Assign the new head. 
//         First = First.Next;

//         return temp;
//     }

//     public void DisplayList(){
//         Console.WriteLine("Iterating through the list....");
//         Node current = First;

//         while(current != null){
//             current.DisplayNode();
//             current = current.Next;
//         }
//     }

// }