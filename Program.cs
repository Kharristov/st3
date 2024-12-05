using System;

public class Program
{
    public static long SquareDigits(long n)
    {
        string numStr = n.ToString();  
        string result = ""; 

        foreach (char digit in numStr)
        {
            int digitValue = int.Parse(digit.ToString()); 
            result += (digitValue * digitValue).ToString();  
        }

        return long.Parse(result);  
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Введите число для возведения каждой цифры в квадрат:");
        string input = Console.ReadLine();

        if (long.TryParse(input, out long number))
        {
            Console.WriteLine($"Результат: {SquareDigits(number)}");
        }
        else
        {
            Console.WriteLine("Ошибка: введено не число.");
        }
    }
}
