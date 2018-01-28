using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace izvlicane_na_srednite_1__2_ili_3_elementa
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            if (array.Length == 1)
            {
                Console.Write("{ ");
                Console.Write("{0}", array[0]);
                Console.WriteLine(" }");
            }
            else if (array.Length % 2 == 0)
            {

                num1 = array[array.Length / 2 - 1];
                num2 = array[array.Length / 2];
                Console.Write("{ ");
                Console.Write("{0}, {1}", num1, num2);
                Console.WriteLine(" }");
            }
            else if (array.Length % 2 != 0)
            {
                num1 = array[array.Length / 2 - 1];
                num2 = array[array.Length / 2];
                num3 = array[array.Length / 2 + 1];
                Console.Write("{ ");
                Console.Write("{0}, {1}, {2}", num1, num2, num3);
                Console.WriteLine(" }");
            }



        }
    }
}
