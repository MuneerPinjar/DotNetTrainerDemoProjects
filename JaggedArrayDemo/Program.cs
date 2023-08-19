using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArrayDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Jagged array declaration
            //int[][] jagged_array = new int[4][];


            //jagged_array[0] = new int[] { 1, 4, 5, 6 };

            //jagged_array[1] = new int[] { 1, 6, 7, 1, 10 };


            //jagged_array[2] = new int[] { 1, 2, 3, 45 };

            //jagged_array[3] = new int[] { 93, 33, 35, 645 };


            //for (int i = 0; i < jagged_array.Length; i++)
            //{
            //    //Print the row number
            //    Console.WriteLine("ROW {0} :",i);

            //    for (int j = 0; j < jagged_array[i].Length; j++)
            //    {
            //        Console.WriteLine("{0}",jagged_array[i][j]);
            //    }

            //    Console.WriteLine();
            //}


            char[] arr = { 't', 'e', 'e', 't', 'h' };

            Console.WriteLine("Array printing using for loop");      
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }


            Console.WriteLine();


            Console.WriteLine("Array printing using foreach loop");

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }


            Console.Read();

        }
    }
}
