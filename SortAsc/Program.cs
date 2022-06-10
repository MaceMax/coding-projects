namespace SortAsc
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 88, 34, 93, 35, 37, 72, 81, 89, 80, 45, 90, 91, 44, 50, 15, 94, 56, 8, 85, 20, 38, 53, 27, 31, 52, 17, 68, 67, 1, 18, 99, 95, 64, 16, 39, 98, 60, 4, 77, 13, 55, 57, 63, 9, 28, 3, 11, 49, 24, 26 };
            Console.WriteLine("Unsorted array: [{0}]", string.Join(", ", arr));
            int[] sortedArr = SortNumsAscending(arr);
            Console.WriteLine("Sorted array: [{0}]", string.Join(", ", sortedArr));
        }

        public static int[] SortNumsAscending(int[] arr)
        {
            int[] sortedArray = new int[arr.Length];
            if (arr != null || arr.Length == 0)
            {
                Array.Copy(arr, sortedArray, arr.Length);
                Array.Sort(sortedArray);
            }
            return sortedArray;
        }

    }
}

