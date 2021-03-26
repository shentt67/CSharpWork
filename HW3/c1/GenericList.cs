﻿using System;

namespace c1
{
    public class Node<T>
    {
        
        public Node<T> Next { get; set; }
        public T Data { get; set; }

        public Node(T t)
        {
            Next = null;
            Data = t;
        }
    }

    public class GenericList<T>
    {
        
        private Node<T> head;
        private Node<T> tail;
        public GenericList()
        {
            tail = head = null;
        }

        public Node<T> Head
        {
            get => head;
        }
        public void Add(T t)
        {
            Node<T> n = new Node<T>(t);
            if (tail == null)
            {
                head = tail = n;
            }
            else
            {
                tail.Next = n;
                tail = n;
            }
        }
    //ForEach
        public void ForEach(Action<Node<T>> action)
        {
            Node<T> N = head;
            for (; N != null; N = N.Next)
                action(N);
        }


    }
}

