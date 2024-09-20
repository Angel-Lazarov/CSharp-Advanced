using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStructures
{
    public class CustomStack
    {
        private const int InitialCapacity = 4;

        private int[] items;

        public CustomStack()
        {
            items = new int[InitialCapacity];
        }

        public int Count { get; private set; }

        public void Push(int item)
        {
            if (items.Length == Count)
            {
                Resize();
            }
            items[Count] = item;
            Count++;
        }

        public int Pop()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("CustomStack is empty!");
            }

            int removed = items[Count - 1];
            items[Count - 1] = default;

            Count--;
            if (Count <= items.Length / 4)
            {
                Shrink();
            }

            return removed;
        }

        public int Peek()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("CustomStack is empty!");
            }

            return items[Count - 1];
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

        internal void ForEach(Action<object> action)
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
