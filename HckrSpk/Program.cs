﻿namespace HckrSpk
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public static string HackerSpeak(string str)
        {
            return str.Replace('a', '4').Replace('e', '3').Replace('i', '1').Replace('o', '0').Replace('s', '5');

        }

    }
}

