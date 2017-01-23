using Algos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos.SearchAlgos
{
    //Only works for sorted arrays
    public class JumpSearch : ISearch
    {
        public int Search(int[] arr, int ele)
        {
            int n = arr.Count();
            int prev = 0;
            int step = (int)Math.Floor(Math.Sqrt(n));
            //Finding the block which has the element
            while (arr[Math.Min(step, n) - 1] < ele) {
                prev = step;
                step += (int)Math.Floor(Math.Sqrt(n));
                if(prev >= n)
                {
                    return -1;
                }
            }
            //Linear search in the selected block
            while (arr[prev] < ele)
            {
                prev++;
                if(prev == Math.Min(step, n))
                {
                    return -1;
                }
            }
            //If element is found
            if (arr[prev] == ele) return prev;
            return -1;
        }
    }
}
