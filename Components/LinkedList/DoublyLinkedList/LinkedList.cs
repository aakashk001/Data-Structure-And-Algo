using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace dsa_revision.Components.LinkedList.DoublyLinkedList
{
    public class LinkedList
    {
        public Node convertArr2LL(int[] arr)
        {
            Node head = new Node(arr[0]);

            Node mover = head;

            for(int i = 1; i < arr.Length; i++)
            {
                Node temp = new Node(arr[i], mover, null);
                mover.Next = temp;
                mover = temp;
            }

            return head;
        }

        public void Display(Node head)
        {
            Node current = head;

            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }

        }

        public Node insertHead(Node head, int data)
        {
            Node newNode = new Node(data, null, head);

            return newNode;
        }

        public Node insertTail(Node head , int data){
            Node tail = head; 
            //Edge Case 
            if(head == null){
                return head;
            }
            while(tail.Next != null){
                tail = tail.Next;
            }  
            
            Node newTail = new Node(data,tail,null );
            tail.Next = newTail;

            return head;
        }

        public Node InsertAtK(Node head, int k , int el){
             Node newNode = new Node(el);
            if(head == null){
                return head;
            }
            if(k==1){
               return newNode;
            }

          //  Node newNode = new Node(el);
            Node temp = head;
            int count = 0;
            Node prev = null;
            Node next = null;
            while(temp != null){
                count++;

                if(count == k){
                    prev = temp.Prev;
                    next = temp.Next;
                    break;
                }
                temp = temp.Next;
            }

            prev.Next = newNode;
            next.Prev = newNode;

            newNode.Next = next;
            newNode.Prev = prev;

            return head;
        }


        public Node RemoveK(Node head , int k ){
            int count = 0;
            if(head == null){
                return null;
            }
            if(k==1){
                return null;
            }

            Node temp = head;
            Node prev = null;
           // Node next = null;
            
            while(temp != null){
                count ++;

                if(count == k){
                  prev.Next = prev.Next.Next;
                    break;
                }
                prev = temp;
                temp = temp.Next;
            }
            return head;
            
        }
        

    }
}
