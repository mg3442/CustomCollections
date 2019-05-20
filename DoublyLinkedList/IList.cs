using System;
using System.Collections.Generic;
using System.Text;

namespace DoublyLinkedList
{
    interface IList<T>
    {
        void AddLast(T data);

        void AddFirst(T data);

        bool Contains(T data);

        string Remove(T data);

        void Clear();

        string FindIdOfElement(T data);
    }
}
