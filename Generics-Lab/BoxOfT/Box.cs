
namespace BoxOfT
{
    public class Box<T>
    {
        //private Stack<T> data;

        //public Box()
        //{
        //    data = new Stack<T>();
        //}

        //public int Count => data.Count;

        //public void Add(T element) 
        //{
        //    data.Push(element);
        //}

        //public T Remove() 
        //{
        //    T removed = data.Pop();
        //    return removed;
        //}

        private List<T> list = new List<T>();

        public int Count => list.Count;

        public void Add(T item)
        {
            list.Add(item);
        }

        public T Remove()
        {
            T removed = list[list.Count - 1];
            list.RemoveAt(list.Count - 1);
            return removed;
        }
    }
}
