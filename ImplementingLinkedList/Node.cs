using System;
using System.Collections.Generic;
using System.Text;

namespace ImplementingLinkedList
{
    public class Node<T>
    {
        public Node(T value)
        {
            this.Value = value;
        }
        public Node<T> Next { get; set; }
        public T Value { get; set; } 
        public Node<T> Previous { get; set; }
    }
}
