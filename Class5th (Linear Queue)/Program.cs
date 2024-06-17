namespace Class5th__Linear_Queue_
{
    public class LinearQueue<T>
    {
        private T error;
        private int rear;
        private int front;
        private int count;

        private T[] array;
        private int arraySize;

        public LinearQueue()
        {
            rear = 0;
            front = 0;
            count = 0;
            arraySize = 5;

            array = new T[arraySize];
        }

        public void Enqueue(T data)
        {
            if (rear < arraySize)
            {
                array[rear++] = data;

                count++;
            }
            else
            {
                Console.WriteLine("Linear Queue is Full");
            }
        }

        public T Dequeue()
        {
            if (front == rear)
            {
                Console.WriteLine("Linear Queue is Empty");
                return error;
            }
            else
            {
                T data = array[front++];

                count--;

                return data;
            }
        }

        public int Count()
        {
            return count;
        }

        public T Peek()
        {
            if (front == rear)
            {
                Console.WriteLine("Linear Queue is Empty");

                return error;
            }
            else
            {
                return array[front];
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            LinearQueue<int> linearQueue = new LinearQueue<int>();

            linearQueue.Enqueue(10);
            linearQueue.Enqueue(20);
            linearQueue.Enqueue(30);
            linearQueue.Enqueue(40);
            linearQueue.Enqueue(50);

            Console.WriteLine("linearQueue의 Peek : " + linearQueue.Peek());
            Console.WriteLine("linearQueue의 Dequeue : " + linearQueue.Dequeue());
            Console.WriteLine("linearQueue의 Dequeue : " + linearQueue.Dequeue());
        }
    }
}
