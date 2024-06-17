namespace Program
{
    public class CircleQueue<T>
    {
        private int count;
        private int rear;
        private int front;
        
        private int arraySize;
        private T [] array;
        
        public CircleQueue()
        {
            count = 0;
            arraySize = 5;

            front = arraySize - 1;
            rear = arraySize - 1;

            array = new T[arraySize];
        }
    }

    internal class Program
    {
        static void Main(string [] args)
        {
           
        }
    }
}
