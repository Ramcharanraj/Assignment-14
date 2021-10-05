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




        //Display method

        internal void Display()
        {
            Console.WriteLine();

            Node temp = this.head;
            if(temp == null)
            {
                Console.WriteLine("Listed List is Empty");
                
            }

            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;

            }
        }

    }
}
