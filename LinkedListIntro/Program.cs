using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList linky = new MyList();
            //linky.AddToEnd(9);
            //linky.AddToEnd(5);
            //linky.AddToEnd(7);
            //linky.AddToEnd(11);
            //linky.AddToBeginning(9);
            //linky.AddToBeginning(5);
            //linky.AddToBeginning(7);
            //linky.AddToBeginning(11);
            linky.AddSorted(9);
            linky.AddSorted(5);
            linky.AddSorted(7);
            linky.AddSorted(11);
            linky.Print();

            Console.ReadKey();
        }
    }

    public class Node
    {
        public int data;
        public Node next;

        // constructor
        public Node(int i)
        {
            data = i;
            next = null;
        }

        // print method
        public void Print()
        {
            Console.Write("|" + data + "|->");
            if (next != null)
            {
                next.Print();
            }
        }

        // add sorted method
        public void AddSorted(int data)
        {
            if (next == null)
            {
                next = new Node(data);
            }
            else if (data < next.data)
            {
                Node temp = new Node(data);
                temp.next = this.next;
                this.next = temp;
            }
            else
            {
                next.AddSorted(data);
            }
           
        }

        // add to end method
        public void AddToEnd(int data)
        {
            if (next == null)
            {
                next = new Node(data);
            }
            else
            {
                next.AddToEnd(data);
            }
        }
    }

    public class MyList
    {
        public Node headNode;

        public MyList()
        {
            headNode = null;
        }

        public void AddToEnd(int data)
        {
            if (headNode == null)
            {
                headNode = new Node(data);
            }
            else
            {
                headNode.AddToEnd(data);
            }
        }

        public void AddSorted(int data)
        {
            if (headNode == null)
            {
                headNode = new Node(data);
            }
            else if (data < headNode.data)
            {
                AddToBeginning(data);
            }
            else
            {
                headNode.AddSorted(data);
            }
        }
        public void AddToBeginning(int data)
        {
            if (headNode == null)
            {
                headNode = new Node(data);
            }
            else
            {
                Node temp = new Node(data);
                temp.next = headNode;
                headNode = temp;
            }
        }

        public void Print()
        {
            if(headNode != null)
            {
                headNode.Print();
            }
        }

    }
}
