namespace Class11th__Binary_Tree_
{
    public class Node
    {
        public int data;

        public Node left;
        public Node right;
    }

    internal class Program
    {
        static Node CreateNode(int data, Node left, Node right)
        {
            Node newNode = new Node();

            newNode.data = data;

            newNode.left = left;

            newNode.right = right;

            return newNode;
        }

        // 전위 순회
        // 1. root Node를 방문합니다.
        // 2. 왼쪽 자식 노드를 전위 순회합니다.
        // 3. 오른쪽 자식 노드를 전위 순회합니다.

        static void Preorder(Node root)
        {
            if (root != null)
            {
                Console.Write(root.data + " ");
                Preorder(root.left);
                Preorder(root.right);
            }
        }

        static void Inorder(Node root)
        {
            if (root != null)
            {
                Inorder(root.left);
                Console.Write(root.data + " ");
                Inorder(root.right);
            }
        }

        static void Postorder(Node root)
        {
            if (root != null)
            {
                Postorder(root.left);
                Postorder(root.right);
                Console.Write(root.data + " ");
            }
        }

        static void Main(string[] args)
        {
            Node node7 = CreateNode(7, null, null);
            Node node6 = CreateNode(6, null, null);
            Node node5 = CreateNode(5, null, null);
            Node node4 = CreateNode(4, null, null);

            Node node3 = CreateNode(3, node6, node7);
            Node node2 = CreateNode(2, node4, node5);

            Node node1 = CreateNode(1, node2, node3);

            //Preorder(node1);
            //Inorder(node1);
            //Postorder(node1);
        }
    }
}
