using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Resultado do Requisito 01: " + ChallengeFunctions.SumUntilIndex());

        Console.WriteLine();
        Console.WriteLine("Resultado do Requisito 02:");
        Console.Write("Informe um número para verificar se está na sequência de Fibonacci: ");
        int userInput = Convert.ToInt32(Console.ReadLine());

        bool isInFibonacci = ChallengeFunctions.IsInFibonacciSequence(userInput);

        if (isInFibonacci)
        {
            Console.WriteLine($"{userInput} pertence à sequência de Fibonacci.");
        }
        else
        {
            Console.WriteLine($"{userInput} não pertence à sequência de Fibonacci.");
        }

        Console.WriteLine();
        Console.WriteLine("Resultado do Requisito 05:");
        Console.Write("Informe uma string para inverter: ");
        string reverseInput = Console.ReadLine();

        string reversedString = ChallengeFunctions.ReverseString(reverseInput);
        Console.WriteLine($"String invertida: {reversedString}");
    }

    
}
