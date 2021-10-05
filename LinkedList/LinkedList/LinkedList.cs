using System;
using System.Collections.Generic;

namespace LinkedList
{
    public class LinkedList
    {

        //Creating Node for list
        internal Node head;

        internal void Add(int data)
        {
            Node node = new Node(data);
            if(this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            //Displaying the Linked list
            Console.WriteLine("{0} inserted into Linked List", node.data);
        }

    }
}
