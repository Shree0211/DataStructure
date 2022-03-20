using System.Collections.Generic;
using Data_Structure;

LinkedList customLinkedList = new LinkedList();
customLinkedList.AddLastNode(56);
customLinkedList.AddLastNode(30);
customLinkedList.AddLastNode(70);
customLinkedList.DisplayLinkedList();
Console.WriteLine("-------------------------");
int node = customLinkedList.SearchNode(30);
customLinkedList.InsertAtParticularPosition(node + 1, 40);
customLinkedList.DisplayLinkedList();