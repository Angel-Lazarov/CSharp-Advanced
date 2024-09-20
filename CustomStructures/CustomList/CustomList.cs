using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CustomStructures;

public class CustomList
{
    private const int InitialCapacity = 2;
    private int[] items;

    public CustomList()
    {
        items = new int[InitialCapacity];
    }

    public int Count { get; private set; }

    public int this[int index]
    {
        get
        {
            ThrowExeptionIndexOutOfRange(index);
            return items[index];
        }
        set
        {
            ThrowExeptionIndexOutOfRange(index);
            items[index] = value;
        }
    }

    private void ThrowExeptionIndexOutOfRange(int index)
    {
        if (index < 0 || index >= Count)
        {
            throw new IndexOutOfRangeException("Invalid index value");
        }
    }

    public void Add(int item)
    {
        if (items.Length == Count)
        {
            Resize();
        }

        items[Count] = item;
        Count++;
    }

    public int RemoveAt(int index)
    {
        ThrowExeptionIndexOutOfRange(index);

        int removedItem = items[index];
        ShiftLeft(index);

        Count--;

        if (Count <= items.Length / 4)
        {
            Shrink();
        }

        return removedItem;
    }

    public void InsertAt(int index, int value) 
    {
        ThrowExeptionIndexOutOfRange(index);

        if(items.Length == Count) 
        {
            Resize();
        }

        ShiftRight(index);
        items[index] = value;
        Count++;

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

    private void ShiftLeft(int index)
    {
        for (int i = index; i < Count - 1; i++)
        {
            items[i] = items[i + 1];
        }
        items[Count - 1] = default; //only for debuging
    }

    private void ShiftRight(int index) 
    {
        for (int i = Count - 1; i >= index; i--)
        {
            items[i+1] = items[i];
        }
    }

    public bool Contains(int item) 
    {
        for(int i = 0; i < Count; i++) 
        {
            if (items[i] == item) 
            {
                return true;
            }
        }
        return false;
    }

    public void Swap(int firstIndex, int secondIndex) 
    {
        ThrowExeptionIndexOutOfRange(firstIndex);
        ThrowExeptionIndexOutOfRange(secondIndex);

        int temp = items[firstIndex];
        items[firstIndex] = items[secondIndex];
        items[secondIndex] = temp;  
    }

    internal void AddRange(int[] items)
    {
        foreach (var item in items)
        {
            Add(item);
        }
    }
}
