using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alfabank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input amount of elements in array");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("input sorted array in decsending order");
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("input target element");
            int x = Convert.ToInt32(Console.ReadLine());
            int result = Bsearch(arr, x);
            Console.WriteLine("index of the largest element smaller than {0} is {1}", x, result);
            Console.ReadKey();
        }

        static int Bsearch(int[] arr, int x)
        {
            int index = 0;
            try
            {
                Array.Reverse(arr);
                index = Array.BinarySearch(arr, x);
                if (index < 0)
                {
                    index = ~index - 1;
                }
                if (arr[index] == x)
                {
                    index--;
                }
                index = arr.Length - index - 1;
            }
            catch(Exception e)
            {
                Console.WriteLine("probably your target value is smaler than min value in array");
                index = -1;
            }
           
            return index;

        }
    }
}
