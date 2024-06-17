namespace Class4th__Stack_
{
    public class Stack<T>
    {
        private int top;

        private readonly int arraySize;
        private T error;
        private int count;
        private T[] array;

        public Stack()
        {
            top = -1;
            count = 0;
            arraySize = 10;
            array = new T[arraySize];
        }

        public void Push(T data)
        {
            if (top >= arraySize - 1)
            {
                Console.WriteLine("Stack Overflow");
            }
            else
            {
                count++;

                array[++top] = data;
            }
        }

        public T Peek()
        {
            return array[top];
        }

        public T Pop()
        {
            if (top <= -1)
            {
                Console.WriteLine("Stack is Empty");
                return error;
            }
            else
            {
                count--;
                return array[top--];
            }
        }

        public int Count()
        {
            return count;
        }

        public bool Constains(T data)
        {
            for (int i = 0; i <= top; i++)
            {
                if (array[i].ToString() == data.ToString())
                {
                    return true;
                }
            }

            return false;
        }
    }

    internal class Program
    {
        static bool CheckBracket(string content)
        {
            if (content.Length <= 0)
            {
                return false;
            }

            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < content.Length; i++)
            {
                char character = content[i];

                if (character == '[' || character == '{' || character == '(')
                {
                    stack.Push(character);
                }
                else if (character == ']' || character == '}' || character == ')')
                {
                    char bracket = stack.Pop();

                    if (bracket == '(' && character != ')')
                    {
                        return false;
                    }

                    if (bracket == '{' && character != '}')
                    {
                        return false;
                    }

                    if (bracket == '[' && character != ']')
                    {
                        return false;
                    }
                }
            }

            if (stack.Count() <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            bool flag = CheckBracket("((()");

            Console.WriteLine("flag 변수의 값 : " + flag);

            // stack.Push(10);
            // stack.Push(20);
            // stack.Push(30);
            // stack.Push(40);
            // stack.Push(50);
            // 
            // Console.WriteLine("Stack의 Constains() : " + stack.Constains(99));
            // 
            // Console.WriteLine("Stack의 Pop : " + stack.Pop());
            // Console.WriteLine("Stack의 Pop : " + stack.Pop());
            // Console.WriteLine("Stack의 Pop : " + stack.Pop());
            // Console.WriteLine("Stack의 Pop : " + stack.Pop());
            // Console.WriteLine("Stack의 Pop : " + stack.Pop());
            // Console.WriteLine("Stack의 Pop : " + stack.Pop());
        }
    }
}
