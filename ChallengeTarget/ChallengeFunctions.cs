using System;

public class ChallengeFunctions
{
    public static int CalculateSumUntilIndex()
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

            if (number == 0)
            {
                return true;
            }

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

        for (int index = 0; index < length / 2; index++)
        {
            char temp = charArray[index];
            charArray[index] = charArray[length - 1 - index];
            charArray[length - 1 - index] = temp;
        }

        return new string(charArray);
    }
}
