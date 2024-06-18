namespace Class6th__Circle_Queue_
{
    public class CircleQueue<T>
    {
        private int count;
        private int rear;
        private int front;

        private int arraySize;

        private T error;
        private T[] array;

        public CircleQueue()
        {
            count = 0;
            arraySize = 5;

            front = arraySize - 1;
            rear = arraySize - 1;

            array = new T[arraySize];
        }

        public void Enqueue(T data)
        {
            if (front == (rear + 1) % arraySize)
            {
                Console.WriteLine("Circle Queue is Full");
            }
            else
            {
                rear = (rear + 1) % arraySize;
                array[rear] = data;

                count++;
            }
        }

        public T Dequeue()
        {
            if (front == rear)
            {
                Console.WriteLine("Circle Queue is Empty");
                return error;
            }
            else
            {
                front = (front + 1) % arraySize;

                count--;

                return array[front];
            }
        }

        public T Peek()
        {
            return array[(front + 1) % arraySize];
        }

        public int Size()
        {
            return count;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            CircleQueue<int> circleQueue = new CircleQueue<int>();

            circleQueue.Enqueue(10);
            circleQueue.Enqueue(20);
            circleQueue.Enqueue(30);
            circleQueue.Enqueue(40);

            while (circleQueue.Size() != 0)
            {
                Console.WriteLine(circleQueue.Dequeue());
            }
        }
    }
}
