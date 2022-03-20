using System.Collections.Generic;
using Data_Structure; 

LinkedList customLinkedList = new LinkedList();
customLinkedList.AddLastNode(56);
customLinkedList.AddLastNode(30);
customLinkedList.AddLastNode(76);
Console.WriteLine("nodes inserted");
customLinkedList.DisplayLinkedList();

customLinkedList.AddFirstNode(70);
customLinkedList.AddFirstNode(30);
customLinkedList.AddFirstNode(56);
customLinkedList.DisplayLinkedList();