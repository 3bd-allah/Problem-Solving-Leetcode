using System.Collections.Generic;
using System.Xml;
using System.Text;

namespace Data_structures
{
    #region singly node and class linked list
    // create singly linked list 
    //public  class Node
    // {
    //     public int data { get; set; }
    //     public Node next { get; set; }  
    //     public Node(int value ) {

    //         data = value;
    //         next = null;

    //     }

    // }
    // public class LinkedList
    // {
    //     private static Node head; 
    //     public LinkedList()
    //     {
    //         head = null;
    //     }
    //     public  void Insert(int value)
    //     {
    //         Node newNode =new Node(value);
    //         if (head == null)
    //         {
    //             head = newNode;
    //         }
    //         else
    //         {
    //            Node current = head;
    //             while (current.next != null)
    //             {
    //                 current = current.next; 

    //             }
    //             current.next = newNode;
    //         }

    //     }

    //     public  void Display()
    //     {
    //         Node current = head;
    //         while (current != null)
    //         {
    //             Console.Write(current.data + " ");
    //             current = current.next;
    //         }
    //         Console.WriteLine();
    //         for (Node tmp = head; tmp != null;tmp = tmp.next)
    //         {
    //             Console.WriteLine(tmp.data + " ");
    //         }

    //     }
    // }

    #endregion c

    public class Node {

        public int data;
        public Node next;
        public Node prev;

        public Node(int data)
        {
            this.data = data;
            next = null;
            prev = null;    
        }
    }

    public class doubly_LinkedList
    {
        private Node head ;

        public doubly_LinkedList()
        {
            head = null;
        }
        public void Insert(int value)
        {
            Node newNode = new Node(value);

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                while (head.next != null)
                {

                }

            }
        }
    }

    internal class Program
    {
              

        static void Main(string[] args)
        {
            #region  initializing singly linked list by traditional method
            ////Node head = null;
            ////Node second = null;
            ////Node third= null;

            //// allocate 3 nodes in the heap 
            //Node head = new Node();
            //Node second = new Node();
            //Node third = new Node();
            //// assign data in the first node 
            //head.data = 1;

            ////link first node with second 
            //head.next = second;

            ////assign data to sencond node 
            //second.data = 2;

            //// link second node with second 
            //second.next = third;
            //// assign data to third node 
            //third.data = 3;

            //third.next = null;

            //Node.printList(head);
            #endregion


            #region singly likedlist by using class
            //LinkedList mylist = new LinkedList();
            //mylist.Insert(1);
            //mylist.Insert(2);

            //mylist.Display();


            #endregion


            #region doubly linkedlist

                      
            
            #endregion

        }
    }
}   