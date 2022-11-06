namespace QueueImplementation;

public class Queue
{
    public class QueueClass<T>
    {
        public List<T> List = new List<T>();

        public void Push(T item)
        {
            //Adds value at the end of the list
            List.Insert(List.Count, item);
        }

        public void Pop()
        {
            if (List.Count == 0)
            {
                Console.WriteLine("Operation cannot be executed");
            }
        
            var firstItem = List.First();
            Console.WriteLine("{0}", firstItem);
            List.RemoveAt((0));
            firstItem = List.First();
        }

        public void Peek()
        {
            if (List.Count == 0)
            {
                Console.WriteLine("Operation cannot be executed");
            }

            T firstElement = List.First();
            Console.WriteLine("{0}", firstElement);
        }
    }


}