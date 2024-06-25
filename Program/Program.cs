﻿namespace Program
{
    public class Heap
    {
        private int size;
        private int arraySize;
        private int [ ] array; 
        
        public Heap()
        {
            size = 0;
            arraySize = 8;

            array = new int[arraySize];
        }

        private void Swap(ref int x, ref int y)
        {
            int temporary = x;

            x = y;

            y = temporary;
        }

        public void Insert(int data)
        {
            if(size >= arraySize-1)
            {
                Console.WriteLine("Heap is Full");
            }
            else
            {
                array[++size] = data;

                int child = size;
                int parent = size / 2;

                while(child > 1)
                {
                    if (array[child] > array[parent])
                    {
                        Swap(ref array[child], ref array[parent]);
                    }

                    child = parent;
                    parent = child / 2;
                }
            }
        }

        public int Remove()
        {
            // 1. Heap이 비어있다면 Error 코드를 보냅니다.
            if(size <= 0)
            {
                Console.WriteLine("Heap is Empty");
                return -9999;
            }

            // 2. 임시 변수에 array[1] 값을 보관합니다.
            int result = array[1];

            // 3. size로 가리키는 배열의 값을 첫 번째 원소에 넣어줍니다.
            array[1] = array[size];

            // 4. size로 가리키는 배열의 값을 초기화합니다.
            array[size] = 0;

            // 5. size의 값을 감소시킵니다.
            size--;

        }

        public void Show()
        {
            for(int i = 1; i <= size; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Heap heap = new Heap();

            heap.Insert(5);  // [5]
            heap.Insert(7);  // [7][5]
            heap.Insert(2);  // [7][5][2]
            heap.Insert(10); // [10][7][2][5]

            heap.Show();
        }
    }
}
