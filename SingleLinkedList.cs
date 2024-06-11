using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6._1._1
{
    internal class SingleLinkedList
    {
        internal Node head;


        internal void InsertLast(SingleLinkedList singleLinkedList, House newHouse)
        {
            Node newNode = new Node(newHouse);
            if (singleLinkedList.head == null)
            {
                singleLinkedList.head = newNode;
                return;
            }
            Node lastNode = GetLastNode(singleLinkedList);
            lastNode.next = newNode;
        }
        internal Node GetLastNode(SingleLinkedList singleLinkedList)
        {
            Node temp = singleLinkedList.head;
            while (temp.next != null) 
            {
                temp = temp.next;
            }
            return temp;
        }
        internal void HouseResults(SingleLinkedList singleLinkedList, int houseNumber)
        {
            Node temp = singleLinkedList.head;
            do 
            {
                if (temp.house.HouseNumber == houseNumber)
                {
                    Console.WriteLine(temp.house.HouseNumber + " " + temp.house.StreetName + " " + temp.house.HouseType);
                    break;
                }
                else
                {
                    Console.WriteLine($"Invalid {houseNumber}");
                }              
            } while (temp.next != null);
        }
    }
}
