using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa_revision.Components.LinkedList.DoublyLinkedList
{
    public class Node
    {
        public int Data { get; set; }
            
        public Node? Prev { get; set; }

        public Node? Next { get; set; }

        public Node(int data)
        {
            this.Data = data;
        }

        public Node(int data, Node prev, Node next)
        {
            this.Next = next;
            this.Prev = prev;
            this.Data = data;
        }


    }
}
