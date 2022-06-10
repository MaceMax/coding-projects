namespace RetFact
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public static int Factorial(int num)
        {
            int result = 1;
            for (; num > 0; num--)
            {
                result *= num;
            }
            return result;
        }

    }
}

