﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
   
    class Program
    {
     /* Linked list is a linear collection of data elements. 
      * Each element points to the next
     * It is a data structure consisting of a group of nodes which
     * together represent a sequence.
     * Each node is composed of data and reference
     * 
     */
        static void Main(string[] args)
        {
            SinglyLinkedList myList = new SinglyLinkedList();
            myList.insertFirst(100);
            myList.insertFirst(50);
            myList.insertFirst(99);
            myList.insertFirst(88);
            myList.insertFirst(999000);
            Console.WriteLine("Before Deletion");
            myList.displayList();

            myList.deleteFirst();
            Console.WriteLine("After Deletion");
            myList.displayList();
            Console.ReadKey();

       }

    }

    public class SinglyLinkedList
    {
        private Node first;
        public bool isEmpty()
        {
            return (first == null); //check if the first node is empty
        }

        public void insertFirst(int data)
        {
            Node newNode = new Node();
            newNode.data = data;
            newNode.next = first;
            first = newNode; //it should point to the first
        }

        public Node deleteFirst()
        {
            Node temp = first;
            first = first.next; // assign to the next value of first node
            return temp;
        }

        public void displayList()
        {
            Console.WriteLine("List (first -- last) ");
            Node current = first;
            while(current != null)
            {
                current.displayNode();
                current = current.next;
            }
            Console.WriteLine();
        } 

        public void inserLast(int data)
        {
            Node current = first;
            while(current.next != null)
            {
                current = current.next;
            }
            Node newNode = new Node();
            newNode.data = data;
            current.next = newNode;
        }

    }


    public class Node
    {
        public int data;
        public Node next;

        public void displayNode()
        {
            Console.Write(" < " + data + " > ");
        }
    }


}
