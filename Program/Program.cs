using System.ComponentModel;

namespace Program
{
    public class Vector<T>
    {
        private int size;
        private int capacity;

        private T [] array;
        
        public Vector()
        {
            size = 0;
            capacity = 0;

            array = null;
        }

        public void Resize(int newSize)
        {
            // 1. capacity에 새로운 newSize 값을 넣어줍니다.
            capacity = newSize;

            // 2. 새로운 배열을 생성합니다.
            T [] newArray = new T[capacity];
            
            // 3. 기존 배열에 있는 값을 복사해서 새로운 배열에
            //    넣어줍니다.
            for(int i = 0; i < size; i++)
            {
                newArray[i] = array[i];
            }

            // 4. array의 주소를 newArray의 값으로 넣어줍니다.
            array = newArray;
        }

        public void Add(T data)
        {
            if(capacity <= 0)
            {
                Resize(1);
            }
            else if(size >= capacity)
            {
                Resize(capacity * 2);
            }

            array[size++] = data;
        }

        public void RemoveAt(int index)
        {
            for (int i = index; i < size-1; i++)
            {
                array[i] = array[i + 1];
            }

            array[size - 1] = default;
        }

        public void Reserve(int newSize)
        {
            if(newSize < capacity)
            {
                return;
            }
            else
            {
                Resize(newSize);
            }
        }

        public int Count()
        {
            return size;
        }

        public T this [int index]
        {
            get { return array[index]; }
        }
    }

    internal class Program
    {
        static void Main(string [] args)
        {
          

        }
    }
}
