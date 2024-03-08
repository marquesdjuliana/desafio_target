using System;

public class ChallengeFunctions
{
    public static int SumUntilIndex()
    {
        int index = 13;
        int sum = 0;
        int currentIndex = 0;

        while (currentIndex < index)
        {
            currentIndex = currentIndex + 1;
            sum = sum + currentIndex;
        }

        return sum;
    }

    public static bool IsInFibonacciSequence(int number)
    {
        int a = 0, b = 1;

        while (b <= number)
        {
            if (b == number)
            {
                return true;
            }

            int temp = a;
            a = b;
            b = temp + b;
        }

        return false;
    }

    public static string ReverseString(string input)
    {
        char[] charArray = input.ToCharArray();
        int length = charArray.Length;

        for (int i = 0; i < length / 2; i++)
        {
            char temp = charArray[i];
            charArray[i] = charArray[length - 1 - i];
            charArray[length - 1 - i] = temp;
        }

        return new string(charArray);
    }
}
