namespace ReverseAndNot
{
    class Program
    {
        static void Main(string[] args)
        {
            //<StartupObject>ReverseAndNot.Program</StartupObject>
            ReverseAndNot(145);
        }

        public static string ReverseAndNot(int i)
        {
            string originalString = i.ToString();
            string reverseString = "";

            for (var j = 0; j < originalString.Length; j++)
            {
                reverseString += originalString[originalString.Length - (j + 1)];
            }
            reverseString += originalString;
            System.Console.WriteLine(reverseString);
            return reverseString;
        }
    }
}

