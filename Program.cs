using System;
using Microsoft.VisualBasic;
using  doubleNode = dsa_revision.Components.LinkedList.DoublyLinkedList.Node;
using doubleLinkedlist = dsa_revision.Components.LinkedList.DoublyLinkedList.LinkedList;
namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            //     Arrays arrObj = new Arrays();
            //     int[] arr = [5,7,6,1,3,2,4];
            //     int low = 0 ; 
            //     int high = arr.Length-1;
            //    // arrObj.QuickSort(arr,low, high);
            //    arrObj.Merge_Sort(arr,low,high);
            //     for(int i = 0 ; i < arr.Length;i++){
            //         Console.Write(arr[i] + " ");
            //     }

            //    Binary binary= new Binary();
            //    int[] arr = [3,4,6,7,9,12,16];
            //   // var loc = binary.BinarySerach(arr,5);
            //   // Console.Write("Location is {0}",loc );
            //   int[] baseArray = [ 3,4,13,13,13,20,40];
            //   int[] duplicatearray = [7, 8, 1, 2, 3, 3, 3, 4, 5, 6];
            //   int[] rotatedArray = [7,8,9,1,2,3,4,5,6];

            //  var loc =  binary.Binary_Recursive_Method(arr,0,arr.Length-1,12);
            //     Console.WriteLine("Location is {0}",loc );

            //   var lb = binary.lowerBound(arr,12);
            //   Console.WriteLine("Lower Bound Location is {0}",lb);

            //   var up = binary.UpperBound(arr,12);
            //   Console.WriteLine("Upper Bound Location is {0}",up);

            //   var fb = binary.FoorValue(arr,10);
            //   Console.WriteLine("Floor Value of {0} is {1}",10,fb);

            //   var cv = binary.CeilValue(arr,10);
            //   Console.WriteLine("Ceil value of {0} is {1}",10,cv);

            //   var LstOcur = binary.LastOccurance(baseArray,13);
            //     Console.WriteLine("Last Occruace  of {0} is {1}",13,LstOcur);

            //   var FstOccu = binary.FirstOccurance(baseArray,13);
            //      Console.WriteLine("First Occruace  of {0} is {1}",13,FstOccu);

            //   int[] findval = [3,11,2,6];


            //   foreach(var k in findval ){
            //    var rotArray = binary.RotatedArray(rotatedArray,k);
            //   Console.WriteLine("Location  of {0} in roated array is  {1}",k,rotArray);
            //   }
            //    foreach(var k in findval ){
            //    var rotArray = binary.RotatedArray_2(duplicatearray,k);
            //   Console.WriteLine("Location  of {0} in roated duplicated array is  {1}",k,rotArray);
            //   }

            //   var minVal =  binary.MinimumRotatedArray_Value(rotatedArray);
            //   Console.WriteLine("Minimum value of rotated array is {0}",minVal);



            //Linked List 
            // Node nodeA = new Node();
            // nodeA.Data = 123;

            // Node nodeB = new Node();
            // nodeB.Data = 456;

            // Node nodeC = new Node();
            // nodeC.Data = 789;



            // nodeA.Next = nodeB;
            // nodeB.Next = nodeC;

            // Console.WriteLine(nodeC.Data);
            // Console.WriteLine(nodeC.Next);
            // int[] arr = { 10, 20, 30, 40, 50, 60, 70, 80, 90 };
         //   LinkedList ll = new LinkedList();
          // var linkedlist =  ll.convertArr2DLL(arr);

            // var head = ll.insertFirst(linkedlist, 00);
            //  var head = ll.insertTail(linkedlist,100);
            // var head = ll.RemoveHead(linkedlist);
            // var head = ll.RemoveTail(linkedlist);
            //var head = ll.removeAtK(linkedlist, 3);
        //     doubleLinkedlist dbll = new doubleLinkedlist();
        //    var dblinkedlist =  dbll.convertArr2LL(arr);
           // var head = dbll.insertHead(dblinkedlist, 05);
          // var head = dbll.insertTail(dblinkedlist,100);
         // var head = dbll.InsertAtK(dblinkedlist,3,35);
        // var head = dbll.RemoveK(dblinkedlist,3);
           // var head = ll.ReversingLinkedList_Method_1(linkedlist);
           //var head = ll.ReversingLinkedList_Traversal(linkedlist);

            // Node First = new Node(1);
            // Node second = new Node(2);
            // Node third = new Node(3);
            // Node fourth = new Node(4);
            // Node fifth = new Node(5);

            // First.Next = second;
            // second.Next = third;
            // third.Next = fourth;
            // fourth.Next = fifth;
            // // Create a loop
            // fifth.Next = third;
         // fifth.Next = null;
          // var head = ll.ReversingLinkedList_Recursive(linkedlist);
           // var head = ll.DetectLoop_LinkedList(First); 
           // ll.Display(head);
          //  dbll.Display(head);
           // var head = ll.insertAtK(linkedlist,35 ,3);
           // ll.Display(head);
        //    var head = ll.DetectLoop_UsingTortoiseAlgo(First);
        //    if(head){
        //      Console.WriteLine("Cyclic Linked List");
        //    }
        //    else{
        //     Console.WriteLine("Not a cyclic linked list");
        //    }
        //var head = ll.MiddleLinkedList(linkedlist);
    //     var head = ll.MiddleUsing_Tortoise(linkedlist);
    //    // ll.Display(head);
    // /   Console.WriteLine("Data of the Middle Node is {0}",head.Data);
        // int[] array = {1,2,1,2,3,4,12};
        // Hashing hash = new Hashing();
        //     // hash.HashingIntArray(array);
        //     //char[] arr = {'a','a','b','b','c','d','e'};
        //     //hash.CharcterHasing(arr,7);
        //   hash.InbuildFunctionHashTable();
            Tree_Node root = new Tree_Node(1);
             root.Left = new Tree_Node(2);
             root.Right = new Tree_Node(3);

             root.Left.Left = new Tree_Node(4);
             root.Left.Right = new Tree_Node(5);
            Tree tree = new Tree();
           // List<int> list = new List<int>();
          //  tree.PreOrderTraversal(root, list);
          //tree.InOrderTraversal(root, list);
          //tree.PostOrderTraversal(root,list);

      // var list =  tree.LevelOrderTraversal(root);
        //var list = tree.PreOrderTraversal_Iterative(root);
       // var list = tree.InOrderTraversal_Iterative(root);
       var list = tree.PostOrderTraversal_Iterative_Stack_2(root);
            foreach( var i in list){
                 Console.Write(i + " " );
         }
            


         }
    }
}