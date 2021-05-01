using System;
using System.Collections.Generic;

namespace C__Doubly_Linked_List
{
    //this class will hold the data that we want to store in the list and a reference to the
    //previous and next nodes in the list
    public class Node
    {
        //private fields
        private object data;
        private Node next;
        private Node previous;

        //constructor
        public Node(object data, Node next, Node previous)
        {
            this.data = data;
            this.next = next;
            this.previous = previous;
        }

        //Public Properties
        public object Data
        {
            get { return this.data; }
            set { this.data = value; }
        }

        public Node Next
        {
            get { return this.next; }
            set { this.next = value; }
        }

        public Node Previous
        {
            get { return this.previous; }
            set { this.previous = value; }
        }
    }

    public class LinkedList
    {
        //Private Fields
        private Node head;
        private int count;

        //Contstructor
        public LinkedList()
        {
            this.head = null;
            this.count = 0;
        }

        //Public Properties
        public bool Empty
        {
            get { return this.count == 0; }
        }

        public int Count
        {
            get { return this.count; }
        }

        public object this [int index]
        {
            get { return this.Get(index); }
        }

        

        public object Get(int index)
        {
            if (index < 0)
                throw new ArgumentOutOfRangeException("index " + index);

            if (this.Empty)
                return null;

            if (index >= this.count)
                index = this.count -1;

            Node current = this.head;

            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }

            return current.Data;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");

            Console.ReadLine();
        }
    }
}
