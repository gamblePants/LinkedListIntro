# LinkedListIntro

This program builds a linked list in c# from scratch. A linked list is a data 
structure consisting of nodes in a sequence. Each node is made up of 2 parts, the head (containing the data), and the address (pointing to the next node). More information on linked lists can be found here:
https://www.c-sharpcorner.com/article/linked-list-implementation-in-c-sharp/

![visual_linked_list.PNG](https://gamblepants.github.io/img/visual_linked_list.PNG)

## Purpose

The program is for educational purposes (mainly my own). It follows a tutorial on YouTube and helps me understand the logic of linked lists.

## Credits

This program was motivated by Jeff Chastine's YouTube tutorials on Linked Lists. The first one (18.1) "Introduction to Linked Lists" gives some nice visuals to help explain the concept:
https://www.youtube.com/watch?v=lcNL_HLpcEs&t=68s

The second tutorial (18.2) "Developing a Linked List" puts the theory in to practise, by showing how to build the list in C#. My program follows this video:
https://www.youtube.com/watch?v=3svB0kM6f10&t=5s

## How to run program

<ul>
  <li>The simplest method is to run the program online from DotNetFiddle: https://dotnetfiddle.net/fS708T</li>
  <li>Alternatively go to the "Release" tab and download the sourcode.zip and extract</li>
  <li>You will need to run the LinkedListIntro.sln file in an IDE that can compile in C# (like Visual Studio)</li>
</ul>

## Program Structure

The program is all written within the Program.cs file. In that file there are 2 classes (Node and MyList). Node has a constructor to create nodes, and also sort and "print" methods. MyList has no constructor, just sort and print methods which are similar to the Node methods. The program is executed from the Main() method.

## Code examples

### Node Class (with constructor and print method)

![Node_Class.PNG](https://gamblepants.github.io/img/Node_Class.PNG)

### AddSorted Method (within Node Class)

![Add_Sorted_Method.PNG](https://gamblepants.github.io/img/Add_Sorted_Method.PNG)
