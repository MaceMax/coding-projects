namespace ToThePowerOf
{
    class Program
    {
        static void Main(string[] args)
        {
            //<StartupObject>ReverseAndNot.Program</StartupObject>
            int result = Convert.ToInt32(CalculateExponent(5, 5));
            Console.WriteLine(result);
        }

        public static long CalculateExponent(long number, long exponent)
        {
            long result = 1;
            for (var i = 0; i < exponent; i++)
            {
                result *= number;
            }
            return result;
        }
    }
}

