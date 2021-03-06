using System;
using System.Collections.Generic;

namespace C__Doubly_Linked_List
{
    //this class will hold the data that we want to store in the list and a reference to the
    //previous and next nodes in the list
    public class Node
    {
        //testing git after move to VS 2019

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
        private Node head;//merely points to the head node(first node would actually come after this)
        private Node tail;
        private int count;

        //Contstructor
        public LinkedList()
        {
            this.head = null;
            this.tail = null;//not sure if this should be here
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

        public object this [int index]//indexer(just another way to use the get method)
        {
            get { return this.Get(index); }
        }

        //Methods
        public object InsertAtHead(object o)
        {
            if (this.Empty)
            {
                this.head = new Node(o, this.head, this.head);
            }

            //if list != empty, create temp node. adjust pointers. make temp node = head
            else
            {
                Node temp = new Node(o, this.head, this.head);
            }

            return o;
        }

        public object InsertByIndex(int index, object o)
        {
            if (index < 0)
                throw new ArgumentOutOfRangeException("Index " + index);

            if (index > count)
                index = count;

            Node current = this.head;

            //adds to beginning. Previous pointer should = null
            if (this.Empty || index == 0)
            {
                this.head = new Node(o, this.head, this.head);///////////////////////////keep and eye on previous parameter
            }

            //loops to node right before the one we want to insert into
            else
            {
                for (int i = 0; i < index -1; i++)
                {
                    current = current.Next;
                    current = current.Previous;
                }
                current.Next = new Node(o, current.Next, current.Previous);///////////////keep and eye on previous parameter
            }

            count++;

            return o;
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
            LinkedList list = new LinkedList();

            list.InsertByIndex(0, "test1");
            list.InsertByIndex(0, "Test2");

            list.InsertAtHead(5);

            Console.WriteLine("Is it empty? " + list.Empty);

            Console.WriteLine("Count: "+ list.Count);

            Console.WriteLine("Head Node is: " + list.Get(0));

            Console.ReadLine();
        }
    }
}
