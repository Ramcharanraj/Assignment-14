using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to LinkedList");

            // Creation of Linked List
            LinkedList list = new LinkedList();

            //Adding values to linked list
            list.Add(56);
            list.Add(30);
            list.Add(70);

            //calling method to remove last Node
            list.RemoveLastNode();

            //Method to Display the Node
            list.Display();
        }
    }
}
