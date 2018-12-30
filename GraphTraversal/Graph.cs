using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph_Traversal
{
    class Graph
    {
        public int[,] Matrix;
        Queue<int> queue;

        public void Traversal()
        {
            int i = 0;
            queue.Enqueue(0);

            while (!Ready())
            {
                for (int j = 0; j < Matrix.Length; j++)
                {
                    if (Matrix[i, j] != 0 && !InQueue(Matrix[i, j]))
                    {
                        queue.Enqueue(Matrix[i, j]);
                    }
                }
            }
        }

        bool InQueue(int patern)
        {
            foreach (var elem in queue)
            {
                if (elem == patern) return true;
            }

            return false;
        }

        bool Ready()
        {
            int[] arr = new int[Matrix.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i;
            }

            Array.Sort(arr);

            int[] arrQue = queue.ToArray();
            Array.Sort(arrQue);

            if (arrQue.Length != arr.Length) return false;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != arrQue[i]) return false;
            }

            return true;
        }
    }
}
