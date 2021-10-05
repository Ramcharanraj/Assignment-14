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
            list.Append(56);
            list.Append(30);
            list.Append(70);
            list.Display();
        }
    }
}
