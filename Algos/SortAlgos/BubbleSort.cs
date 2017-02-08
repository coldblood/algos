using Algos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos.SortAlgos
{
    class BubbleSort : ISort
    {
        public void Sort(ref int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1 ; j < n; j++)
                {
                    if (arr[j] < arr[i])
                    {
                        swap(ref arr[j], ref arr[i]);
                    }
                }
            }
        }
        private void swap(ref int v1, ref int v2)
        {
            int temp;
            temp = v2;
            v2 = v1;
            v1 = temp;
        }
    }
}
