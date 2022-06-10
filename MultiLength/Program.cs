namespace MultiLength
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public static int[] MultiplyByLength(int[] arr)
        {
            for (var i = 0; i < arr.Length; i++)
            {
                arr[i] *= arr.Length;
            }
            return arr;
        }

    }
}

