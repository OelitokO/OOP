using StackApp.Contract;

namespace StackApp.Models;

public class LinkedListStack : IStack
{
    private LinkedList<object> _collection;

    public LinkedListStack()
    {
        _collection = new LinkedList<object>();
    }
    public object Peek()
    {
        return _collection.First.Value;
    }

    public object Pop()
    {
        var temp = _collection.First.Value;
       _collection.RemoveFirst();
       return temp;
    }

    public void Push(object item)
    {
        _collection.AddFirst(item);
    }
}