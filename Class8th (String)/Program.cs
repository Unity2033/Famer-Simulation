namespace Class8th__String_
{
    public class String
    {
        private char[] array;
        private int errorCode = -99999;

        public String()
        {
            array = null;
        }

        public void Add(char[] content)
        {
            array = new char[content.Length + 1];

            for (int i = 0; i < content.Length; i++)
            {
                array[i] = content[i];
            }
        }

        public void Concat(char[] content)
        {
            char[] newArray = new char[(array.Length - 1) + content.Length + 1];

            for (int i = 0; i < array.Length - 1; i++)
            {
                // [A][B][C][][]
                newArray[i] = array[i];
            }

            for (int i = 0; i < content.Length; i++)
            {
                newArray[(array.Length - 1) + i] = content[i];
            }

            array = newArray;
        }

        public int IndexOf(char alphabet)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == alphabet)
                {
                    return i;
                }
            }

            return errorCode;
        }

        public bool Equals(char[] content)
        {
            if (array.Length != content.Length + 1)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] != content[i])
                    {
                        return false;
                    }
                }

                return true;
            }
        }

        public void Show()
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }
        }

        public int Size()
        {
            return array.Length - 1;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            String name = new String();

            name.Add(new char[] { 'A', 'B', 'C' });

            name.Concat(new char[] { 'D', 'E' });

            name.Show();

            Console.WriteLine();

            Console.WriteLine(name.IndexOf('Z'));
            Console.WriteLine(name.Equals(new char[] { 'A', 'B', 'C', 'D', 'E', 'F' }));
        }
    }
}
