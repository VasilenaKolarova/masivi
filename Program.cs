using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sguni_i_suberi
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = array.Length / 4;
            
            int br = 0;
            for (int i = k; i < 2 * k; i++)
            {
                br = i; 
            }
            int[] firstNums = new int[array[k]];
            
            int[] lastNums = new int[array[array.Length-k]];
            int[] midNums = new int[array[br]];
            for (int j = 0; j < k - 1; j++)
            {
                 int[] sum1 = new int[firstNums[j] + midNums[j]];
                Console.WriteLine(sum1);
            }
            for (int m = 0; m < k - 1; m++)
            {
                int[] sum2 = new int[lastNums[m] + midNums[m + 2 * k]];
            }
            

        }
    }
}
