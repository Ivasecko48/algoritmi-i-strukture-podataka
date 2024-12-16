using System;
using SingleList;

namespace Queue{
class Queue
{
    private CustomList list;

    public Queue()
    {
        list = new CustomList();
    }

    public bool IsEmpty()
    {
        return list.IsEmpty();
    }

    public void Enqueue(object item)
    {
        list.InsertEnd(item);
    }

    public object Dequeue()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Queue is empty. Cannot dequeue.");
        }
        return list.RemoveFront();
    }

    public void Display()
    {
        list.Display();
    }
}
}