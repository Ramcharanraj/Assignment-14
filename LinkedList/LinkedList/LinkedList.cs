using System;
using System.Collections.Generic;

namespace LinkedList
{
    public class LinkedList
    {
        internal Node head;


        // Adding to list
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
            //Dispalys the list if it not empty
            Console.WriteLine("{0} inserted into Linked List", node.data);

            
        }



        internal Node InsertAtParticularPosition(int position, int data)
        {
            if (position < 1)
            {
                Console.WriteLine("Invalid Position");
            }

            if (position == 1)
            {
                var newNode = new Node(data);
                newNode.next = this.head;
                head = newNode;
            }

            else
            {
                while (position-- != 0)
                {
                    if (position == 1)
                    {
                        Node newNode = new Node(data);
                        newNode.next = this.head.next;
                        head.next = newNode;
                        break;
                    }
                    head = head.next;
                }
                if (position != 1)
                {
                    Console.WriteLine("Position Out Of Range");
                }
            }
            return head;
        }
        internal void Display()
        {
            Node temp = head;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is Empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }

    }
}
