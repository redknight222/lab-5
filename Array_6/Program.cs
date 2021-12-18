using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] my_array = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    my_array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
            }
            int sum_string = 0;
            int sum_diag_1 = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    sum_string += my_array[i, j];
                    sum_diag_1 += (j==i)?my_array[i, j]:0;
                }
            }
            sum_string = sum_string / n;
            int sum_column = 0;
            int sum_diag_2 = 0;
            for (int j = n - 1; j >= 0; j--)
            {
                for (int i = 0; i < n; i++)
                {
                    sum_column += my_array[i, j];
                    sum_diag_2 += (j == i) ? my_array[i, j] : 0;
                }
            }
            sum_column = sum_column / n;
            Console.WriteLine("sum_string = {0,4} ", sum_string);
            Console.WriteLine("sum_column = {0,4} ", sum_column);
            Console.WriteLine("sum_diag_1 = {0,4} ", sum_diag_1);
            Console.WriteLine("sum_diag_2 = {0,4} ", sum_diag_2);
            if (sum_string == sum_column & sum_column  == sum_diag_1 & sum_diag_1  == sum_diag_2)
            {
                Console.WriteLine("Magic square");
            }
            else
            {
                Console.WriteLine("Not magic square");
            }
            Console.ReadKey();
        }
    }
}
