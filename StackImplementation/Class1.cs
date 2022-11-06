using System.Collections;

namespace StackImplementation;

public class StackClass<T>
{
    public List<T> Newlist = new List<T>();

    public void Push(T item)
    {
        //Adds value at the top of the list
        Newlist.Insert(0, item);
    }

    public void Pop()
    {
        if (Newlist.Count == 0)
        {
            Console.WriteLine("Operation cannot be executed");
        }
        
        var lastitem = Newlist.Last();
        Console.WriteLine("{0}", lastitem);
        Newlist.RemoveAt((Newlist.Count-1));
        lastitem = Newlist.Last();
    }

    public void Peek()
    {
        if (Newlist.Count == 0)
        {
            Console.WriteLine("Operation cannot be executed");
        }

        T firstElement = Newlist.First();
        Console.WriteLine("{0}", firstElement);
        
    }
}

