using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1. Calcular a soma até o índice");
            Console.WriteLine("2. Verificar se um número pertence à sequência de Fibonacci");
            // Console.WriteLine("3. Inverta");
            Console.WriteLine("0. Sair");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                switch (choice)
                {
                    case 1:
                        ReturnSumUntilIndex();
                        break;
                    case 2:
                        CheckFibonacci();
                        break;
                    // case 3:
                    //     ReverseString();
                    //     break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Opção inválida. Tente novamente.");
            }

            Console.WriteLine();
        }
    }

    static void ReturnSumUntilIndex()
    {
        int sumResult = ChallengeFunctions.CalculateSumUntilIndex();
        Console.WriteLine($"A soma até o índice é: {sumResult}");
    }

    static void CheckFibonacci()
    {
        Console.Write("Digite um número para verificar se pertence à sequência de Fibonacci: ");
        if (int.TryParse(Console.ReadLine(), out int inputNumber))
        {
            if (inputNumber >= 0)
            {
                bool isInFibonacci = ChallengeFunctions.IsInFibonacciSequence(inputNumber);
                Console.WriteLine($"{inputNumber} pertence à sequência de Fibonacci: {isInFibonacci}");
            }
            else
            {
                Console.WriteLine("O valor inserido deve ser um número positivo.");
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida. O valor inserido deve ser um número inteiro.");
        }
    }

    static void ReverseString()
    {
        Console.Write("Digite uma string para inverter: ");
        string? inputString = Console.ReadLine();

        if (IsValidString(inputString))
        {
            string reversedString = ChallengeFunctions.ReverseString(inputString);
            Console.WriteLine($"A string invertida é: {reversedString}");
        }
        else
        {
            Console.WriteLine("Entrada inválida. A string deve conter apenas letras.");
        }
    }

    static bool IsValidString(string input)
    {
        return !string.IsNullOrEmpty(input) && input.All(char.IsLetter);
    }

}
