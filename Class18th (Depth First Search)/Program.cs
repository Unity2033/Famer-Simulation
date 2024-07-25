namespace Class18th__Depth_First_Search_
{
    public class Graph
    {
        private int size;
        private bool[] visited;
        private List<int>[] graph;

        public Graph()
        {
            size = 8;
            visited = new bool[size];
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
            // 1. 현재 노드를 방문한 것으로 표시합니다.
            visited[start] = true;

            // 2. 현재 노드를 출력합니다.
            Console.Write(start + " ");

            // 3. 현재 노드와 연결된 다른 노드를 재귀적으로 방문합니다.
            for (int i = 0; i < graph[start].Count; i++)
            {
                // 4. 현재 노드와 연결된 다음 노드를 가져옵니다.
                int next = graph[start][i];

                if (visited[next] == false)
                {
                    // 다음 노드가 방문하지 않은 노드라면 재귀 함수를 호출합니다.
                    Search(next);
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
            #region 깊이 우선 탐색
            // root 노드에서 시작해서 다음 분기로 넘어가기 전에
            // 해당 분기를 완벽하게 탐색하는 방법입니다.

            // 1. 시작 노드를 스택에 넣고 방문 처리합니다.

            // 2. 스택의 최상단 노드에 방문하지 않은 인접 노드가 
            //    있으면 그 노드를 스택에 넣고 방문 처리합니다.

            // 3. 방문하지 않은 인접 노드가 없으면 스택에서 최상단 노드를 꺼냅니다.

            // 4. 더 이상 2번의 과정을 수행할 수 없을 때까지 반복합니다.

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

            // graph.Show();

            graph.Search(1);

            #endregion

        }
    }
}
