using System;
using SortingAlgorithms;
using System.Diagnostics;

namespace SortingAlgorithms
{
    class Programm
    {
        public static void Main(string[] args)
        {
            Test test = new Test();
            test.test(10000);
        }
    }
    public class Test
    {
        BubbleSort bubbleSort = new BubbleSort();
        GnomeSort gnomeSort = new GnomeSort();
        CombSort combSort = new CombSort();
        SelectionSort selectionSort = new SelectionSort();
        QuickSort quickSort = new QuickSort();
        MergeSort mergeSort = new MergeSort();
        HeapSort heapSort = new HeapSort();
        Random random = new Random();

        public void test(int length)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            int[] a = new int[length];
            shuffle(a);

            int[] b = a;
            Console.WriteLine("This is the test of the " + bubbleSort.ToString());
            stopwatch.Start();
            bubbleSort.sort(b);
            stopwatch.Stop();
            if (isSorted(b))
            {
                Console.WriteLine("The sort worked successfully");
                Console.WriteLine(stopwatch.Elapsed.ToString());
            }
            else
            {
                Console.WriteLine("An Error occurred:");
                printArray(b);
            }
            Console.WriteLine();
            stopwatch.Reset();

            b = a;
            Console.WriteLine("This is the test of the " + gnomeSort.ToString());
            stopwatch.Start();
            gnomeSort.sort(b);
            stopwatch.Stop();
            if (isSorted(b))
            {
                Console.WriteLine("The sort worked successfully");
                Console.WriteLine(stopwatch.Elapsed.ToString());
            }
            else
            {
                Console.WriteLine("An Error occurred:");
                printArray(b);
            }
            Console.WriteLine();
            stopwatch.Reset();

            b = a;
            Console.WriteLine("This is the test of the " + combSort.ToString());
            stopwatch.Start();
            combSort.sort(b);
            stopwatch.Stop();
            if (isSorted(b))
            {
                Console.WriteLine("The sort worked successfully");
                Console.WriteLine(stopwatch.Elapsed.ToString());
            }
            else
            {
                Console.WriteLine("An Error occurred:");
                printArray(b);
            }
            Console.WriteLine();
            stopwatch.Reset();

            b = a;
            Console.WriteLine("This is the test of the " + selectionSort.ToString());
            stopwatch.Start();
            selectionSort.sort(b);
            stopwatch.Stop();
            if (isSorted(b))
            {
                Console.WriteLine("The sort worked successfully");
                Console.WriteLine(stopwatch.Elapsed.ToString());
            }
            else
            {
                Console.WriteLine("An Error occurred:");
                printArray(b);
            }
            Console.WriteLine();
            stopwatch.Reset();


            b = a;
            Console.WriteLine("This is the test of the " + quickSort.ToString());
            stopwatch.Start();
            quickSort.sort(b);
            stopwatch.Stop();
            if (isSorted(b))
            {
                Console.WriteLine("The sort worked successfully");
                Console.WriteLine(stopwatch.Elapsed.ToString());
            }
            else
            {
                Console.WriteLine("An Error occurred:");
                printArray(b);
            }
            Console.WriteLine();
            stopwatch.Reset();

            b = a;
            Console.WriteLine("This is the test of the " + mergeSort.ToString());
            stopwatch.Start();
            mergeSort.sort(b);
            stopwatch.Stop();
            if (isSorted(b))
            {
                Console.WriteLine("The sort worked successfully");
                Console.WriteLine(stopwatch.Elapsed.ToString());
            }
            else
            {
                Console.WriteLine("An Error occurred:");
                printArray(b);
            }
            Console.WriteLine();
            stopwatch.Reset();

            b = a;
            Console.WriteLine("This is the test of the " + heapSort.ToString());
            stopwatch.Start();
            heapSort.sort(b);
            stopwatch.Stop();
            if (isSorted(b))
            {
                Console.WriteLine("The sort worked successfully");
                Console.WriteLine(stopwatch.Elapsed.ToString());
            }
            else
            {
                Console.WriteLine("An Error occurred:");
                printArray(b);
            }
            Console.WriteLine();
            stopwatch.Reset();
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