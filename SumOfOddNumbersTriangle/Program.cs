using System;

namespace SumOfOddNumbersTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            long row = 2257754;
            long sum = SumOfTriangleRow.rowSumOddNumbers(row);
            Console.WriteLine($"Sum is [{sum}]");
        }
    }
}
