namespace Class19th__Breadth_First_Search_
{
    public class Graph
    {
        private int size;
        private bool[] visited;
        private Queue<int> queue;
        private List<int>[] graph;

        public Graph()
        {
            size = 8;
            visited = new bool[size];
            queue = new Queue<int>();
            graph = new List<int>[size];

            for (int i = 0; i < size; i++)
            {
                graph[i] = new List<int>();
            }
        }

        public void Insert(int vertex, int edge)
        {
            graph[vertex].Add(edge);
            graph[edge].Add(vertex);
        }

        public void Search(int start)
        {
            queue.Enqueue(start);
            visited[start] = true;

            while (queue.Count > 0)
            {
                int x = queue.Dequeue();

                Console.Write(x + " ");

                for (int i = 0; i < graph[x].Count; i++)
                {
                    int next = graph[x][i];

                    if (visited[next] == false)
                    {
                        queue.Enqueue(next);
                        visited[next] = true;
                    }
                }
            }

        }

        public void Show()
        {
            for (int i = 0; i < graph.Length; i++)
            {
                for (int j = 0; j < graph[i].Count; j++)
                {
                    Console.Write(graph[i][j] + " ");
                }

                Console.WriteLine();
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region 너비 우선 탐색
            // 시작 정점을 방문한 후 시작 정점에 인접한 모든 정점
            // 들을 우선 방문하는 방법입니다.

            // 더 이상 방문하지 않은 정점이 없을 때까지 방문하지
            // 않은 모든 정점들에 대해서도 너비 우선 탐색을 적용합니다.

            Graph graph = new Graph();

            graph.Insert(1, 2);
            graph.Insert(1, 3);

            graph.Insert(2, 3);

            graph.Insert(2, 4);
            graph.Insert(2, 5);

            graph.Insert(3, 6);
            graph.Insert(3, 7);

            graph.Insert(4, 5);
            graph.Insert(6, 7);

            graph.Search(1);
            #endregion


        }
    }
}
