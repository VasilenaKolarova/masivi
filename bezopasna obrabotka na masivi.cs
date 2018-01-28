using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bezopasna_obrabotka_na_masivi
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            string[] inputDistinct = input;
            bool found = false;
            while (found == false)
            {
                string inputText = Console.ReadLine().ToLower();
                if (inputText == "distinct")
                {
                    inputDistinct = input.Distinct();
                    Console.WriteLine(string.Join(" ", input));
                }

                if (inputText == "reverse")
                {
                    Array.Reverse(input);
                }

                if (inputText == "end")
                {
                    found = true;
                }
            }
        }
    }
}
