using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStructures
{
    public class CustomQueue
    {
        private const int InitialCapacity = 4;
        private const int FirstElementIndex = 0;
        private int[] items;
        private int count;

        public CustomQueue()
        {
            //count = 0; // при инициализацията ще вземе default стойност 0. За това е излишно!
            items = new int[InitialCapacity];
        }

        //public int Count { get; private set; }
        public int Count => count;
        //public int Count
        //{ 
        //    get
        //    {
        //        return count;
        //    }
        //}

        public void Enqueue(int item)
        {
            if (items.Length == count)
            {
                Resize();
            }
            items[count] = item;
            count++;
        }

        public int Dequeue() 
        {
            if (count == 0)
            {
                throw new InvalidOperationException("CustomQueue is empty!");
            }

            int firstElement = items[FirstElementIndex];
            ShiftLeft();
            count--;
            if (count <= items.Length /4)
            {
                Shrink();
            }
            return firstElement;
        }

        public int Peek()
        {
            if (items.Length == 0)
            {
                throw new InvalidOperationException("CustomStack is empty!");
            }

            return items[FirstElementIndex];
        }

        public void Clear() 
        {
            items = new int[InitialCapacity];
            count = 0;
        }

        private void ShiftLeft()
        {
            for (int i = FirstElementIndex; i < Count - 1; i++)
            {
                items[i] = items[i + 1];
            }
        }

        private void Shrink()
        {
            int[] copy = new int[items.Length / 2];
            for (int i = 0; i < Count; i++)
            {
                copy[i] = items[i];
            }
            items = copy;
        }

        private void Resize()
        {
            int[] copy = new int[items.Length * 2];
            for (int i = 0; i < items.Length; i++)
            {
                copy[i] = items[i];
            }
            items = copy;
        }

        internal void ForEach(Action<int> action)
        {
            for (int i = 0; i < Count; i++)
            {
                int currentItem = items[i];
                action(currentItem);
                //action(items[i]); 
            }

            //for (int i = Count - 1; i >= 0; i--)
            //{
            //     action(items[i]);
            //}

        }
    }
}
