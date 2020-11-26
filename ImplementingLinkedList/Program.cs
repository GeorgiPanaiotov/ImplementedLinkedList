using System;

namespace ImplementingLinkedList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            LinkedList<int> linked = new LinkedList<int>();

            linked.Add(new Node<int>(5));
            linked.Add(new Node<int>(10));
            linked.Add(new Node<int>(15));
            linked.Add(new Node<int>(20));
            linked.Add(new Node<int>(25));

            linked.Add(new Node<int>(30));
            linked.AddLast(new Node<int>(122));
            linked.Print();
            linked.ReversePrint();
            linked.Remove();
            linked.RemoveLast();
            linked.ToArray();
            
        }
    }
}
