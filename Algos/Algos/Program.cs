using Algos.Helpers;
using Algos.SearchAlgos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Algos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arrayList = new List<int>() { 3, 1, 5, 19, 2, 37, 10 };
            arrayList.Sort();
            printArray(arrayList.ToArray());
            Dictionary<int, string> algoList = Enum.GetValues(typeof(AlgoList)).Cast<int>().ToDictionary(e => e, e => Enum.GetName(typeof(AlgoList), e));
            while (true) {
                Console.Write("Please enter the number to find the index : ");
                int element = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please select the appropriate algo id:");
                foreach (KeyValuePair<int, string> entry in algoList)
                {
                    Console.WriteLine(entry.Key + " : " + entry.Value);
                }
                int SelectedAlgoId = Convert.ToInt32(Console.ReadLine());
                string SelectedAlgoName = Enum.GetName(typeof(AlgoList), SelectedAlgoId);
                Console.WriteLine("Selected Algorithm : " + SelectedAlgoName);
                var searchEngine = Assembly.GetExecutingAssembly().GetType("Algos.SearchAlgos." + SelectedAlgoName);
                //Interpolated Search
                //InterpolationSearch interpolationEngine = new InterpolationSearch();
                var classInstance = Activator.CreateInstance(Type.GetType("Algos.SearchAlgos." + SelectedAlgoName + ", Algos"), null);
                Console.WriteLine("Returned Index : " + (searchEngine.GetMethod("Search").Invoke(classInstance, new object[] { arrayList.ToArray(), element })));
            }
        }

        private static void printArray(int[] arr) {
            Console.Write("Sorted array: ");
            foreach (var ele in arr) {
                Console.Write(ele + " ");
            }
            Console.WriteLine();
        }
    }
}
