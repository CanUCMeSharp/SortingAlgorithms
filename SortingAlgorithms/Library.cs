namespace SortingAlgorithms
{
    public class Library
    {
        ///Welcome to the Sorting Algorithms Library!
        ///This is a library, that's main purpose it is to get me some coding, computer science
        ///and C# practise. This means that the code her mostly is pretty shit, but I haven't
        ///learned to do it better yet. For the purpose of simplicity, I´monly gonna handle
        ///integers.
        ///HAVE FUN!
    }
    public partial class SortingAlgorithm
    {
        public bool isSorted(int[] array)
        {
            for(int i = 0; i < array.Length - 1; i++)
            {
                if(array[i] > array[i + 1])
                {
                    return false;
                }
            }
            return true;
        }
        public void swap(int[] array, int posA, int posB)
        {
            int temp = array[posA];
            array[posA] = array[posB];
            array[posB] = temp;
        }
    }
    public class BubbleSort : SortingAlgorithm
    {
        public void sort(int[] array)
        {
            while (!isSorted(array))
            {
                for(int i = 0; i < array.Length - 1; i++)
                {
                    if(array[i] > array[(i + 1)])
                    {
                        swap(array, i, i + 1);
                    }
                }
            }
        }
    }
    public class GnomeSort : SortingAlgorithm
    {
        public void sort(int[] array)
        {
            int arrayLength = array.Length;
            for(int i =0; i < arrayLength - 1;)
            {
                if(array[i] > array[i + 1])
                {
                    swap(array, i, i + 1);
                    if(i > 0)
                    {
                        i--;
                    }
                    else
                    {
                        i++;
                    }
                }
                else
                {
                    i++;
                }
            }
        }
    }
    public class CombSort : SortingAlgorithm
    {
        public void sort(int[] array)
        {
            int arrayLength = array.Length;
            for(int gap = arrayLength - 1; gap > 0; gap--)
            {
                for(int i = 0; i + gap < arrayLength; i++)
                {
                    if(array[i] > array[i + gap])
                    {
                        swap(array, i, i +gap);
                    }
                }
            }
        }
    }
    public class SelectionSort : SortingAlgorithm
    {
        public void sort(int[] array)
        {
            int minvalue = int.MaxValue;
            int minPos = 0;
            for(int sorted = 0; sorted < array.Length; sorted++)
            {
                for(int i = sorted; i < array.Length; i++)
                {
                    if(minvalue >= array[i])
                    {
                        minvalue = array[i];
                        minPos = i;
                    }
                }
                swap(array, sorted, minPos);
                minvalue = int.MaxValue;
                minPos = 0;
            }
        }
    }
    public class QuickSort : SortingAlgorithm
    {
        public void sort(int[] array)
        {
            quickSort(array, 0, array.Length - 1);
        }
        private void quickSort(int[] array, int low, int high)
        {
            if(low < high)
            {
                int pi = partition(array, low, high);
                quickSort(array, low, pi - 1);
                quickSort(array, pi + 1, high);
            }
        }
        private int partition(int[] array, int low, int high)
        {
            int pivot = array[high];
            int i = (low - 1);

            for (int j = low; j <= high - 1; j++)
            {
                if (array[j] < pivot)
                {
                    i++;
                    swap(array, i, j);
                }
            }
            swap(array, i + 1, high);
            return (i + 1);
        }
    }
    public class MergeSort : SortingAlgorithm
    {
        public void sort(int[] array)
        {
            mergeSort(array, 0, array.Length - 1);
        }
        private void mergeSort(int[] array, int l, int r)
        {
            if(l < r)
            {
                int m = l + (r - l) / 2;
                mergeSort(array, l, m);
                mergeSort(array, m + 1, r);
                merge(array, l, m, r);
            }
        }
        private void merge(int[] array, int l, int m, int r)
        {
            int n1 = m - l + 1;
            int n2 = r - m;
            int[] L = new int[n1];
            int[] R = new int[n2];
            int i, j;
            for(i = 0; i < n1; i++)
            {
                L[i] = array[l + i];
            }
            for(j = 0; j < n2; j++)
            {
                R[j] = array[m + j + 1];
            }
            i = 0;
            j = 0;
            int k = l;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    array[k] = L[i];
                    i++;
                }
                else
                {
                    array[k] = R[j];
                    j++;
                }
                k++;
            }
            while(i < n1)
            {
                array[k] = L[i];
                i++;
                k++;
            }
            while (j < n2)
            {
                array[k] = R[j];
                j++;
                k++;
            }
        }
    }
    public class HeapSort : SortingAlgorithm
    {
        public void sort(int[] array)
        {
            int n = array.Length;
            for(int i = n / 2 - 1; i >= 0; i--)
            {
                heapify(array, n, i);
            }
            for(int i = n - 1; i > 0; i--)
            {
                swap(array, 0, i);
                heapify(array, i, 0);
            }
        }
        private void heapify(int[] array, int n, int i)
        {
            int largest = i;
            int l = 2 * i + 1;
            int r = 2 * l + 2;
            if(l < n && array[l] > array[largest])
            {
                largest = l;
            }
            if(r < n && array[r] > array[largest])
            {
                largest = r;
            }
            if(largest != i)
            {
                swap(array, largest, i);
            }
            heapify(array, n, largest);
        }
    }
}