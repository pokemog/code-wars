using System;
using Solution;

namespace BinToDec
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myBinaryNumber = new int[] { 0, 1, 0, 1};
            for (int i = myBinaryNumber.Length - 1; i >= 0 ; i--)
            {
                Console.WriteLine($"Index [{i}], Value {myBinaryNumber[i]}");
            }
            Console.WriteLine(Kata.binaryArrayToNumber(myBinaryNumber));
        }
    }
}
