public class SumOfTriangleRow
{
    public long RowSumOddNumbers(long n)
    {
        long sum = 0;
        long rowIndex = indexOfRow(n);
        long startValue = nthOddNumber(rowIndex);

        for (int i = 0; i < n; i++)
        {
            sum += nthOddNumber(rowIndex);
            rowIndex++;
        }

        // Optimal solution is n*n*n

        return sum;
    }

    private long indexOfRow(long row)
    {
        long indexOfRow = 1;

        while (row >= 1)
        {
            indexOfRow += row - 1;
            row--;
        }
        return indexOfRow;
    }

    public static long nthOddNumber(long n) {
        return (2 * n) - 1;
    }
}