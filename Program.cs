﻿//Nikhil kacham 400pms
namespace SortingAlgorithm
{
    internal class Program
    {
        
        public static void Main(string[] args)
        {
            int[] input_array = { 3, 62, 5, 16, 4, 10,99 };
            Bubble_Sort(input_array);
            foreach (int element in input_array)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();

        }
        public static void Bubble_Sort(int[] bs_arr)
        {
            // The for loop will continue until the array is sorted in ascending order.
            // Bubble Sort starts from the beginning of the array each for loop iteration and checks the value
            // of the next element in the array to see if it is less. If it is less, then swap.
            for (int i = 0; i < bs_arr.Length - 1; i++)
            {
                for (int x = 0; x < bs_arr.Length - i - 1; x++)
                {
                    // In each nested for loop iteration check to see if the next element value is lower than the current element value
                    // If the next element value is less, then conduct the swap
                    if (bs_arr[x] > bs_arr[x + 1])
                    {
                        // Here you will swap temp and bs_arr[x]
                        // The temp variable is used to temporarily hold the value of the current element so that it can be swapped
                        int temp = bs_arr[x];
                        bs_arr[x] = bs_arr[x + 1];
                        bs_arr[x + 1] = temp;
                    } // End of if
                } // End of inner for loop
            } // End of outer for loop
            Console.WriteLine(bs_arr);
        }
    }
}
