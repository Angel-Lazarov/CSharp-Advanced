
namespace GenericArrayCreator
{
    public  class ArrayCreator
    {
        public static T[] Create<T>(int length, T item) 
        {
            T[] massiv = new T[length];

            for (int i = 0; i < length; i++) 
            {
                massiv[i] = item;   
            }
            return massiv;
        }
    }
}
