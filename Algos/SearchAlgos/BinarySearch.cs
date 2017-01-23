using Algos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos.SearchAlgos
{
    //Only works for sorted arrays
    public class BinarySearch : ISearch
    {
        public int Search(int[] arr, int element)
        {
            int low = 0, high = (arr.Count() - 1);
            while (low <= high && element <= arr[high] && element >= arr[low])
            {
                int position = (int)Math.Floor((decimal)((low + high) / 2));
                if (element == arr[position])
                {
                    return position;
                }
                else if (element >= arr[position])
                {
                    low = position + 1;
                }
                else if (element <= arr[position])
                {
                    high = position - 1;
                }
            }
            return -1;
        }
    }
}
