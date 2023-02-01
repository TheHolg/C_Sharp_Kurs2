using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Node
    {
        public object data;
        public Node next; public void DisplayNode()
        {
            Console.WriteLine("Data: " + data.ToString());
        }
    }
    class SinglyLinkedList
    {
        private Node first; public bool IsEmpty()
        {
            return first == null;
        }
        public void InsertFirst(object data)
        {
            Node newNode = new Node();
            newNode.data = data;
            newNode.next = first;
            first = newNode;
        }
        public void InsertLast(object data)
        {
            Node current = first; if (IsEmpty())
            {
                InsertFirst(data);
            }
            else
            {
                while (current.next != null)
                {
                    current = current.next;
                }
                Node newNode = new Node();
                newNode.data = data;
                current.next = newNode;
            }
        }
    }
}
