using System.Runtime.CompilerServices;
using System.Collections.Generic;
public class LinkedList{

    //Converting  a array into singly linked list 
    public Node convertArr2DLL(int[] arr){
        //Preservingthehead 
        Node head = new Node(arr[0]);

        Node mover = head;
        for(int i = 1 ; i < arr.Length ; i++){
            
            Node temp = new Node(arr[i]);
            mover.Next = temp;
            mover = temp;
        }
        return head;

    }
    //Displaying the data of singly linked list
    public void Display(Node node){
        Console.WriteLine("Iterating through the linked list");

        while(node != null ){
            Console.WriteLine(node.Data);
            node = node.Next;
        }
    }

    /// <summary>
    ///adding new head to linked list
    /// </summary>
  
    public Node insertFirst(Node head , int data)
    {
        Node newhead = new Node(data,head);

        return newhead;
       
    }
    /// <summary>
    /// Inserting new tail to the linked list
    /// </summary>
   
    public Node insertTail(Node head, int data)
    {
        Node temp = head;
        Node tail = new Node(data);
        while(temp.Next != null)
        {
            temp = temp.Next;
        }

        temp.Next = tail;

        return head;
    }
    /// <summary>
    /// Removing the head of the given linked list
    /// </summary>
    /// <param name="head"></param>
    /// <returns></returns>
   public Node RemoveHead(Node head)
    {
        Node temp = head;
        head = head.Next;

        return head;
    }

    public Node RemoveTail(Node head)
    {
        Node temp = head;
        if(head == null || head.Next == null)
        {
            return head;
        }
        while(temp.Next.Next != null)
        {
            temp = temp.Next;
        }

        temp.Next = null;

        return head;
    }
    
    public Node removeAtK(Node head, int k)
    {
        int count = 0;
        //Edge caase 
        if(head == null){
            return head;
        }    
        if(k==1){
            return head;
        }
        Node temp  = head;
        Node prev = null;
        while(temp != null){
            count++;

            if(count == k){
                prev.Next = temp.Next;
                break;
            }

            prev = temp;
            temp = temp.Next;
        }

        return head;
    }

    public Node insertAtK(Node head , int el ,int k){
        int count = 0;
        Node temp = head;
        Node tempK= new Node(el);
        Node prev = null;
        if(head == null){
            return head;
        }    
        if(k == 1){ 
            Node newNode = new Node(el,head);
            return newNode;
        }

        while(temp != null){
            count++;
            if(count == k){
                prev.Next = tempK;
                tempK.Next = temp.Next;  
            }
            prev = temp;
            temp = temp.Next;
        }
        return head;
    }
    
    /// <summary>
    /// Reversing a singly linked list 
    /// 1. Iterative Method.
    //2. Inplace Reversal 
    /// 3.Recursive Reversl 
    /// </summary>
    /// <param name="head"></param>
    /// <returns></returns>
    public Node ReversingLinkedList_Method_1(Node head){
        Stack<int> stack_LL = new Stack<int>();
        Node temp = head;
        while(temp != null ){
            stack_LL.Push(temp.Data);
            temp = temp.Next;
        }
        temp = head;
        while(temp != null){
            temp.Data = stack_LL.Pop();
          //  Console.WriteLine(stack_LL.Pop());
            temp = temp.Next;
        }

        return head;
    }
    public Node ReversingLinkedList_Traversal(Node head){
        Node temp =  head;
        Node prev = null;

        while(temp != null){
            //Front presert the referese 
            Node front = temp.Next;

            temp.Next = prev;

            prev = temp ;

            temp = front;

        }

        return prev;

    }

    public Node ReversingLinkedList_Recursive(Node head){
        //Base Condition 
        if(head == null || head.Next == null){
            return head;
        }

        Node newHead = ReversingLinkedList_Recursive(head.Next);

        Node front =head.Next;
        front.Next = head;
        head.Next = null;
        return newHead;
    }
    
    /// <summary>
    /// Detecting a loop in Linked List 
    /// 1. Brute Force 
    /// 2. Floyd's Tortoise and Hare algorithm
    /// </summary>
    /// <param name="head"></param>
    /// <returns></returns>
    public bool DetectLoop_LinkedList(Node head){
        Dictionary<Node , int> map = new Dictionary<Node , int>();
        Node temp = head;

        while(temp != null){
                if(map.ContainsKey(temp)){
                    return true;
                }
            map.Add(temp,1); 
            temp = temp.Next;
    
           
        }
        return false;
    }

    public bool DetectLoop_UsingTortoiseAlgo(Node head){
       Node slow = head ; 
       Node fast = head; 
       while(fast != null && fast.Next != null){
        fast = fast.Next.Next ; 
        slow = slow.Next;

        if(slow == fast){
            return true;
        }
       }
        return false;
    }

/// <summary>
/// Finding the Middle Element of a linked list 
/// 1. Brute Force Technique
/// 2. Floyd's Tortoise and Hare algorithm
/// </summary>
/// <param name="head"></param>
/// <returns></returns>
    public Node MiddleLinkedList(Node head){

        if(head == null || head.Next == null){
            return head;
        }
        Node temp = head;
        int count = 0 ;
        while(temp != null){
            count++;
            temp = temp.Next;
        }
       // Console.WriteLine(count);
        int mid = count/2 +1;
        temp = head;
        //Console.WriteLine(mid);
        while(temp != null){
            mid = mid-1;

            if(mid == 0){
                //Console.WriteLine(mid);
                break;
            }
            temp = temp.Next;
        }
        return temp;
    }

    public Node MiddleUsing_Tortoise(Node head){
        Node slow = head;
        Node fast = head;
        
        while(fast != null && fast.Next != null && slow != null){
            fast = fast.Next.Next;
            slow = slow.Next;
        }

        return slow;
    }
}