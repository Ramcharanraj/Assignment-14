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

            // Adding the values to Linked List
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.Display();
        }
    }
}
