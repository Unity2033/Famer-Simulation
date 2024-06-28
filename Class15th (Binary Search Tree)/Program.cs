namespace Class15th__Binary_Search_Tree_
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

        Node CreateNode(int data)
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
                if (currentNode.data == data)
                {
                    return true;
                }
                else
                {
                    if (currentNode.data > data)
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
            if (root == null)
            {
                root = CreateNode(data);
            }
            else
            {
                Node currentNode = root;

                while (currentNode != null)
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
                        if (currentNode.right == null)
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

        public void Remove(int data)
        {
            Node currentNode = root;
            Node parentNode = null;

            if (currentNode == null)
            {
                Console.WriteLine("Binary Search Tree is Empty");
            }
            else
            {
                while (currentNode.data != data)
                {
                    parentNode = currentNode;

                    if (currentNode.data > data)
                    {
                        currentNode = currentNode.left;
                    }
                    else
                    {
                        currentNode = currentNode.right;
                    }
                }
            }

            if (currentNode == null)
            {
                Console.WriteLine("Data not found is the Binary Search Tree");
            }
            else
            {
                if (currentNode.left == null && currentNode.right == null)
                {
                    if (parentNode != null)
                    {
                        if (parentNode.left == currentNode)
                        {
                            parentNode.left = null;
                        }
                        else
                        {
                            parentNode.right = null;
                        }
                    }
                    else
                    {
                        root = null;
                    }
                }
                else if (currentNode.left == null || currentNode.right == null)
                {
                    Node childNode = null;

                    if (currentNode.left != null)
                    {
                        childNode = currentNode.left;
                    }
                    else
                    {
                        childNode = currentNode.right;
                    }

                    if (parentNode != null)
                    {
                        if (parentNode.left == currentNode)
                        {
                            parentNode.left = childNode;
                        }
                        else
                        {
                            parentNode.right = childNode;
                        }
                    }
                }
                else
                {
                    Node findNode = currentNode.right;
                    Node traceNode = findNode;

                    while (findNode.left != null)
                    {
                        traceNode = findNode;
                        findNode = findNode.left;
                    }

                    currentNode.data = findNode.data;

                    traceNode.left = findNode.right;
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
            binarySearchTree.Insert(5);
            binarySearchTree.Insert(19);
            binarySearchTree.Insert(14);
            binarySearchTree.Insert(23);
            binarySearchTree.Insert(21);

            binarySearchTree.Remove(19);

            binarySearchTree.Inorder(binarySearchTree.root);
        }
    }
}
