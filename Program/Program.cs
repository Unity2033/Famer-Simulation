using System.Security;

namespace Program
{  
    public class BinarySearchTree
    {
        public class Node
        {
            public int data;
            public Node left;
            public Node right;
        }

        public Node root;

        public BinarySearchTree()
        {
            root = null;
        }

        Node CreateNode (int data)
        {
            Node node = new Node();

            node.data = data;

            node.left = null;

            node.right = null;

            return node;
        }

        public bool Find(int data)
        {
            Node currentNode = root;

            while (currentNode != null)
            {
                if(currentNode.data == data)
                {
                    return true;
                }
                else
                {
                    if(currentNode.data > data)
                    {
                        currentNode = currentNode.left;
                    }
                    else
                    {
                        currentNode = currentNode.right;
                    }
                }
            }

            return false;
        }

        public void Insert(int data)
        {
            if(root == null)
            {
                root = CreateNode(data);
            }
            else
            {
                Node currentNode = root;

                while(currentNode != null)
                {
                    if (currentNode.data > data)
                    {
                        if (currentNode.left == null)
                        {
                            currentNode.left = CreateNode(data);
                            break;
                        }
                        else
                        {
                            currentNode = currentNode.left;
                        }
                    }
                    else
                    {
                        if(currentNode.right == null)
                        {
                            currentNode.right = CreateNode(data);
                            break;
                        }
                        else
                        {
                            currentNode = currentNode.right;
                        }
                    }
                }
            }
        }

        public void Inorder(Node root)
        {
            if (root != null)
            {
                Inorder(root.left);
                Console.Write(root.data + " ");
                Inorder(root.right);
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree binarySearchTree = new BinarySearchTree();

            binarySearchTree.Insert(10);
            binarySearchTree.Insert(7);
            binarySearchTree.Insert(12);
            binarySearchTree.Insert(5);
            binarySearchTree.Insert(9);

            binarySearchTree.Inorder(binarySearchTree.root);

            Console.WriteLine();

            Console.WriteLine("binarySearchTree Find(7) : " + binarySearchTree.Find(7));
            Console.WriteLine("binarySearchTree Find(11) : " + binarySearchTree.Find(11));

        }
    }
}
