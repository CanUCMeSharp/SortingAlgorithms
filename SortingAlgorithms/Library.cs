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
        public void switchPlaces(int[] array, int posA, int posB)
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
                        switchPlaces(array, i, i + 1);
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
                    switchPlaces(array, i, i + 1);
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
                        switchPlaces(array, i, i +gap);
                    }
                }
            }
        }
    }
    public class SelectionSort : SortingAlgorithm
    {
        public void sort(int[] array)
        {
            //This is a work in progress
            int arrayLength = array.Length;
            for(int sorted = 0; sorted < arrayLength; sorted++)
            {
                for(int i = sorted; i < arrayLength; i++)
                {
                    if(array[i] < (int)min)
                    {

                    }
                }
            }
        }
    }
}