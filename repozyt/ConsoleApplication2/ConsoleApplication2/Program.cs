using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class Program
    {
        static public int partition(int[] numbers, int left, int right)
        {
            int pivot = numbers[right];
            while (true)
            {
                while (numbers[left] < pivot)
                    left++;

                while (numbers[right] > pivot)
                    right--;

                if (left < right)
                {
                    int temp = numbers[right];
                    numbers[right] = numbers[left];
                    numbers[left] = temp;
                }
                else
                {
                    return right;
                }
            }
        }
        public static void sort(int [] numbers, int left, int right)
        {
            if(left < right)
            {
                int pivot = partition(numbers, left, right);
                if (pivot > 1)
                    sort(numbers, left, pivot - 1);
                if (pivot + 1 < right)
                    sort(numbers, pivot + 1, right);
            }
        }

        public static void Main(string[] args)
        {
            int[] numbers = { 3, 8, 7, 5, 2, 1, 9, 6, 4 };
            int len = 9;

            Console.WriteLine("QuickSort By Recursive Method");
            partition(numbers, 0, len - 1);
            for (int i = 0; i < 9; i++)
                Console.WriteLine(numbers[i]);

            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
