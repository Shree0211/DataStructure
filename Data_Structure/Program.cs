using System.Collections.Generic;
using Data_Structure;

LinkedList customLinkedList = new LinkedList();
customLinkedList.AddLastNode(56);
customLinkedList.AddLastNode(30);
customLinkedList.AddLastNode(70);
customLinkedList.DisplayLinkedList();
Console.WriteLine("-------------------------");
int node = customLinkedList.DeleteLastNode();
Console.WriteLine("{0} node deleted", node);
customLinkedList.DisplayLinkedList();