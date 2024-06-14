namespace Class3th__Circle_Linked_List_
{
    public class CircleLinkedList<T>
    {
        private int size;

        private class Node
        {
            public T data;
            public Node next;
        }

        private Node head;

        public CircleLinkedList()
        {
            size = 0;
            head = null;
        }

        public void PushBack(T data)
        {
            Node newNode = new Node();

            newNode.data = data;

            if (head == null)
            {
                head = newNode;

                newNode.next = head;
            }
            else
            {
                newNode.next = head.next;

                head.next = newNode;

                head = newNode;
            }

            size++;
        }

        public void RemoveFront()
        {
            if (head == null)
            {
                Console.WriteLine("Linked List Empty");
            }
            else
            {
                if (head == head.next)
                {
                    head = null;
                }
                else
                {
                    head.next = head.next.next;
                }

                size--;
            }
        }

        public void PushFront(T data)
        {
            Node newNode = new Node();

            newNode.data = data;

            if (head == null)
            {
                head = newNode;

                newNode.next = head;
            }
            else
            {
                newNode.next = head.next;

                head.next = newNode;
            }

            size++;
        }

        public void RemoveBack()
        {
            if (head == null)
            {
                Console.WriteLine("Linked List is Empty");
            }
            else
            {
                if (head == head.next)
                {
                    head = null;
                }
                else
                {
                    Node currentNode = head;

                    for (int i = 0; i < size - 1; i++)
                    {
                        currentNode = currentNode.next;
                    }

                    currentNode.next = head.next;

                    head = currentNode;
                }

                size--;
            }
        }

        public void Show()
        {
            if (head != null)
            {
                Node currentNode = head.next;

                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine(currentNode.data);
                    currentNode = currentNode.next;
                }
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            CircleLinkedList<int> circleLinkedList = new CircleLinkedList<int>();

            circleLinkedList.PushBack(10);
            circleLinkedList.PushBack(20);
            circleLinkedList.PushFront(99);

            circleLinkedList.RemoveBack();
            circleLinkedList.RemoveBack();
            circleLinkedList.RemoveBack();
            circleLinkedList.RemoveBack();

            //circleLinkedList.PushBack(30);

            circleLinkedList.Show();
        }
    }
}
