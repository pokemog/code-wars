
public class BinToDec
{
    public int binaryArrayToNumber(int[] BinaryArray)
    {
        int result = 0;

        for (int i = BinaryArray.Length - 1, bit = 0; i >= 0; i--, bit++)
        {
            if (BinaryArray[i] == 1)
            {
                result += (int)System.Math.Pow(2, bit);
            }
        }

        return result;
    }
}
