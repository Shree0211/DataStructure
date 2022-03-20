using System.Collections.Generic;
using Data_Structure;
using static Data_Structure.Node;

LinkedList customLinkedList = new LinkedList();
customLinkedList.AddLastNode(56);
customLinkedList.AddLastNode(30);
customLinkedList.AddLastNode(40);
customLinkedList.AddLastNode(70);
customLinkedList.DisplayLinkedList();
Console.WriteLine("-------------------------");
int key = customLinkedList.SearchNode(40);
customLinkedList.DeleteAtParticularPosition(key);
customLinkedList.DisplayLinkedList();
customLinkedList.Size();

SortedLinkedList<int> sortedLinkedList = new SortedLinkedList<int>();
Console.WriteLine("<----SortedLinkedList---->");
sortedLinkedList.Add(new SortedNode<int>(70));
sortedLinkedList.Add(new SortedNode<int>(40));
sortedLinkedList.Add(new SortedNode<int>(30));
sortedLinkedList.Add(new SortedNode<int>(56));
Console.WriteLine("LinkedList before sorting");
sortedLinkedList.Display();
sortedLinkedList.SortedList();
Console.WriteLine("LinkedList after sorting");
sortedLinkedList.Display();