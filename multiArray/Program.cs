namespace multiArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 10;
            int num = 5;
            int[] arr = ArrayOfMultiples(num, length);
            Console.Write("ArrayOfMultiples({0}, {1}) -> [", num, length);
            for (var i = 0; i < length; i++)
            {
                if (i != length - 1)
                {
                    Console.Write(arr[i] + ", ");
                }
                else
                {
                    Console.WriteLine(arr[i] + "]");
                }


            }
        }

        private static int[] ArrayOfMultiples(int num, int length)
        {
            int[] multiArray = new int[length];
            for (int i = 0; i < length; i++)
            {
                multiArray[i] = (i + 1) * num;
            }

            return multiArray;
        }
    }
}
