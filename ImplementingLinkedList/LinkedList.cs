using System;
using System.Collections.Generic;
using System.Text;

namespace ImplementingLinkedList
{
    public class LinkedList<T>
    {
        public Node<T> Head { get; set; }
        public Node<T> Tail { get; set; }

        public void Add(Node<T> input)
        {
            if (Head == null)
            {
                Head = input;
                Tail = input;

            }
            else
            {
                input.Next = Head;
                Head.Previous = input;
                Head = input;
            }
        }
        public Node<T> Remove()
        {
            var head = this.Head;
            this.Head = this.Head.Next;
            Head.Previous = null;
            return head;
        }
        public Node<T> RemoveLast()
        {
            var oldTail = this.Tail;
            Tail = Tail.Previous;
            Tail.Next = null;

            return oldTail;
        }

        public Node<T>[] ToArray()
        {
            List<Node<T>> list = new List<Node<T>>();
            var currentHead = Head;

            while(currentHead != null)
            {
                list.Add(currentHead);
                currentHead = Head.Next;
            }
            return list.ToArray();
        }
        public void AddLast(Node<T> node)
        {
            if(Tail == null)
            {
                Tail = node;
                Head = node;
            }
            else
            {
                node.Previous = Tail;
                Tail.Next = node;
                Tail = node;
            }
        }
        public void Print()
        {
            Node<T> currentNode = Head;

            while (currentNode != null)
            {
                Console.WriteLine(currentNode.Value);
                currentNode = currentNode.Next;
            }
        }
        public void ReversePrint()
        {
            Node<T> currentNode = Tail;

            while(currentNode != null)
            {
                Console.WriteLine(currentNode.Value);
                currentNode = currentNode.Previous;
            }
        }
    }
}
