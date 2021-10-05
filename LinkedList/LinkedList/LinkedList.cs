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



        //Appeding the values to the List

        public void Append(int new_data)
        {
            Node new_node = new Node(new_data);
            if (head == null)
            {
                head = new Node(new_data);
                return;
            }

            new_node.next = null;
            Node last = head;
            while (last.next != null)
            {
                last = last.next;
            }
            last.next = new_node;
            Console.WriteLine("{0} Is Inserted In The Linked List", last.next.data);
            return;
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
