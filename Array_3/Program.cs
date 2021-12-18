using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            Random random = new Random();
            int[] my_array = new int[n];
            int first_range = 5;
            int second_range = 10;
            for (int i = 0; i < n; i++)
            {
                my_array[i] = random.Next(-51, 51);
            }
            foreach (int a in my_array)
            {
                Console.Write("{0,4} ", a);
            }
            Console.WriteLine();
            for (int i = 0; i < first_range - 1; i++)
            {
                for (int j = i + 1; j < first_range; j++)
                {
                    if (my_array[i] > my_array[j])
                    {
                        int t = my_array[i];
                        my_array[i] = my_array[j];
                        my_array[j] = t;
                    }
                }
            }
            for (int i = first_range; i < second_range - 1; i++)
            {
                for (int j = i + 1; j < second_range; j++)
                {
                    if (my_array[i] > my_array[j])
                    {
                        int t = my_array[i];
                        my_array[i] = my_array[j];
                        my_array[j] = t;
                    }
                }
            }
            foreach (int a in my_array)
            {
                Console.Write("{0,4} ", a);
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
