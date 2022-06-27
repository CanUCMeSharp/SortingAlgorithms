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
}