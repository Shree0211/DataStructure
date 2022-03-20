using System.Collections.Generic;
using Data_Structure;

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