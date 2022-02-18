public class TwoToOne
{
    public string Longest(string s1, string s2)
    {
        // your code
        string tmpString = s1 + s2;
        string longest = string.Empty;

        foreach (var character in tmpString)
        {
            var isDuplicate = false;

            for (int i = 0; i < longest.Length; i++)
            {
                if (character == longest[i])
                {
                    isDuplicate = true;
                }
            }
            if (!isDuplicate)
            {
                longest += character;
            }
        }

        var tmpArray = longest.ToCharArray();
        var sortedString = string.Empty;

        for (int i = 0; i < tmpArray.Length - 1; i++)
        {
            for (int j = 0; j < tmpArray.Length - 1; j++)
            {
                if (tmpArray[j + 1] < tmpArray[j])
                {
                    var temp = tmpArray[j];
                    tmpArray[j] = tmpArray[j + 1];
                    tmpArray[j + 1] = temp;
                }
            }
        }

        longest = new string(tmpArray);
        return longest;
    }
}
