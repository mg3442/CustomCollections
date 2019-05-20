using System;
using System.Collections;
using System.Collections.Generic;

namespace DoublyLinkedList
{
    public class DoublyLinkedList<T> : IList<T>
    {
        DoublyNode<T> head;
        DoublyNode<T> tail;
        int count;

        public int Count { get { return count; } }

        public bool IsEmpty { get { return count == 0; } }

        public void AddLast(T data)
        {
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }
                
            DoublyNode<T> node = new DoublyNode<T>(data);

            if (head == null)
            {
                head = node;
            }
            else
            {
                tail.Next = node;
                node.Previous = tail;
            }

            tail = node;
            count++;
        }

        public void AddFirst(T data)
        {
            if (data == null)
            {
                throw new ArgumentNullException();
            }
                
            DoublyNode<T> node = new DoublyNode<T>(data);
            DoublyNode<T> temp = head;
            node.Next = temp;
            head = node;

            if (count == 0)
            {
                tail = head;
            }
            else
            {
                temp.Previous = node;
            }

            count++;
        }

        public bool Contains(T data)
        {
            DoublyNode<T> current = head;
            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    return true;
                }

                current = current.Next;
            }

            return false;
        }

        public string Remove(T data)
        {
            DoublyNode<T> current = head;
            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    break;
                }

                current = current.Next;
            }

            if (current != null)
            {
                if (current.Next != null)
                {
                    current.Next.Previous = current.Previous;
                }
                else
                {
                    tail = current.Previous;
                }

                if (current.Previous != null)
                {
                    current.Previous.Next = current.Next;
                }
                else
                {
                    head = current.Next;
                }

                count--;
                return $"{data} removed from list";
            }

            return $"{data} not found in list";
        }

        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }

        public string FindIdOfElement(T data)
        {
            DoublyNode<T> current = head;
            for (int i = 0; i < Count; i++)
            {
                if (current.Data.Equals(data))
                {
                    return $"Element {data} has id {i} in list";
                }

                current = current.Next;
            }

            return $"No element {data} in list";
        }
    }
}
