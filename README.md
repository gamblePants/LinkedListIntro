# LinkedListIntro

This program builds a linked list in c# from scratch. A linked list is a data 
structure consisting of nodes in a sequence. Each node is made up of 2 parts; the data, and the address (pointing to the next node or null). More information on linked lists can be found here:
https://www.c-sharpcorner.com/article/linked-list-implementation-in-c-sharp/

![linked_list.PNG](https://gamblepants.github.io/img/linked_list.PNG)

This program has several Add() methods to add integers to a linked list. The methods can add to the beginning of the list, the end of the list, or add them in sorted numerically. This program adds in the integers 9, 5, 7 and 11 using the AddSorted() method and then displays the list.

## Purpose

For educational purposes (mainly my own). It follows a tutorial on YouTube and helps me understand the logic of linked lists.

## Credits

Motivated by Jeff Chastine's YouTube tutorials on Linked Lists. The first one (18.1) "Introduction to Linked Lists" gives some nice visuals to help explain the concept:
https://www.youtube.com/watch?v=lcNL_HLpcEs&t=68s

The second tutorial (18.2) "Developing a Linked List" puts the theory in to practise, by showing how to build the list in C#. My program follows this video:
https://www.youtube.com/watch?v=3svB0kM6f10&t=5s

## How to run program

- The simplest method is to run the program online from DotNetFiddle: https://dotnetfiddle.net/fS708T
- Alternatively go to the [Release](https://github.com/gamblePants/LinkedListIntro/releases) page, download the Source code zipped folder and extract
- You will need to run the LinkedListIntro.sln file in an IDE that can compile in C# (like Visual Studio)

## Program Structure

The program is all written within the Program.cs file. In that file there are 2 classes (Node and MyList). Node has a constructor to create nodes, and also sort and "print" methods. MyList has no constructor, just sort and print methods which are similar to the Node methods. The program is executed from the Main() method.

## Code example

### Node Class

```C#
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
```


