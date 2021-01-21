using System;

namespace typeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            // char - 2 bytes
            char myChar = 'F';
            Console.WriteLine($"myChar: {myChar}");
            // int - 4 bytes
            int myInt = myChar;
            Console.WriteLine($"myInt: {myInt}");
            // long - 8 bytes
            long myLong = myInt;
            Console.WriteLine($"myLng: {myLong}");
            long largestPossibleLong = 9223372036854775807;
            Console.WriteLine($"largestPossibleLong: {largestPossibleLong}");
            float truncatedLong = largestPossibleLong;
            Console.WriteLine($"truncatedLong: {truncatedLong}");



            // double - 8 bytes
            double myDouble = 1.79769313486231e10;
            Console.WriteLine($"myDouble: {myDouble}");
            // float - 4 bytes
            float myFloat = (float)myDouble;
            Console.WriteLine($"myFloat: {myFloat}");

            // int - 4 bytes
            int myInt2 = 70000;
            Console.WriteLine($"myInt2: {myInt2}");
            // char - 2 bytes
            char myChar2 = (char)myInt2;
            Console.WriteLine($"myChar2: {myChar2}");

            // https://unicodelookup.com/
        }
    }
}
