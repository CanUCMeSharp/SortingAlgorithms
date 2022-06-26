using System;
using SortingAlgorithms;

namespace SortingAlgorithms
{
    class Programm
    {
        public static void Main(string[] args)
        {
            Test test = new Test();
            test.test(1000);
        }
    }
    public class Test
    {
        BubbleSort bubbleSort = new BubbleSort();
        GnomeSort gnomeSort = new GnomeSort();
        Random random = new Random();

        public void test(int length)
        {
            int[] a = new int[length];
            bool allTestsComplete = true;
            bool isSorted;

            shuffle(a);
            Console.WriteLine("The unsorted array:");
            printArray(a);
            bubbleSort.sort(a);
            Console.WriteLine("The sorted array:");
            printArray(a);
            isSorted = this.isSorted(a);
            Console.WriteLine(isSorted);
            allTestsComplete = allTestsComplete && isSorted;

            shuffle(a);
            Console.WriteLine("The unsorted array:");
            printArray(a);
            gnomeSort.sort(a);
            Console.WriteLine("The sorted array:");
            printArray(a);
            isSorted = this.isSorted(a);
            Console.WriteLine(isSorted);
            allTestsComplete = allTestsComplete && isSorted;

            if (allTestsComplete)
            {
                Console.WriteLine("Everything works!");
            }
            else
            {
                Console.WriteLine("Fuck, something went wrong!");
            }
        }
        private void shuffle(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next();
            }
        }
        private void printArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
        private bool isSorted(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}