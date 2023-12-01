using System;

namespace Linked_List_Homework
{
    public class LinkedList
    {
        public Node First { get; set; }

        public void Print()
        {
            Node move = First;
            while (move != null)
            {
                Console.Write(move.Data+"\t");
                move = move.Next;
            }
            Console.WriteLine();
        }

        // methods
        public void Add(int val)
        {
            Node newNode = new Node(val);
            if (First == null)
            {
                First = newNode;
            }
            else
            {
                Node current = First;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }

        public void RemoveKey(int key)
        {
            if (First == null)
            {
                return;
            }

            if (First.Data == key)
            {
                First = First.Next;
                return;
            }

            Node current = First;
            while (current.Next != null)
            {
                if (current.Next.Data == key)
                {
                    current.Next = current.Next.Next;
                    return;
                }
                current = current.Next;
            }
        }

        public void Merge(LinkedList other_list)
        {
            if (First == null)
            {
                First = other_list.First;
                return;
            }

            Node current = First;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = other_list.First;
        }

        public void Reverse()
        {
            Node prev = null;
            Node current = First;
            Node next = null;
            while (current != null)
            {
                next = current.Next;
                current.Next = prev;
                prev = current;
                current = next;
            }
            First = prev;
        }
    }
}

