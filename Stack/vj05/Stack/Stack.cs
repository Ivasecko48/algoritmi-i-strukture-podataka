using System;
using SingleList;

namespace Stack{
class Stack
{
    private CustomList list;

    public Stack()
    {
        list = new CustomList();
    }

    public bool IsEmpty()
    {
        return list.IsEmpty();
    }

    public void Push(object item)
    {
        list.InsertFront(item);
    }

    public object Pop()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Stack is empty. Cannot pop.");
        }

        return list.RemoveFront();
    }

    public void Display()
    {
        Console.WriteLine("Stack contents:");
        list.Display();
    }
}
}