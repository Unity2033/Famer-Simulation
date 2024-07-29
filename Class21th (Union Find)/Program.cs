namespace Class21th__Union_Find_
{
    public class Graph
    {
        private int size;
        private int[] parent;

        public Graph()
        {
            size = 7;
            parent = new int[size];

            for (int i = 1; i < size; i++)
            {
                parent[i] = i;
            }
        }

        public int Find(int x)
        {
            if (x == parent[x])
            {
                return x;
            }
            else
            {
                return parent[x] = Find(parent[x]);
            }
        }

        public bool Same(int x, int y)
        {
            return Find(x) == Find(y);
        }

        public void Union(int x, int y)
        {
            x = Find(x);
            y = Find(y);

            if (Same(x, y))
            {
                return;
            }

            if (x < y)
            {
                parent[y] = x;
            }
            else
            {
                parent[x] = y;
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region 유니온 파인드
            // 여러 노드가 존재할 때 어떤 두 개의 노드를 같은 집합으로
            // 묶은 다음 어떤 두 노드가 같은 집합에 있는 지 확인하는 알고리즘입니다.

            Graph graph = new Graph();

            graph.Union(2, 3);
            graph.Union(1, 3);

            Console.WriteLine(graph.Same(2, 3));

            Console.WriteLine(graph.Same(1, 3));




            #endregion


        }
    }
}
