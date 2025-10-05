using Problem_Solving_Tasks_C_.Class;
using System;
internal class Program
{
    private static void Main(string[] args)
    {
        ConvertNumToString converter = new ConvertNumToString();

        int num = 5;
        Console.WriteLine(converter.NumberToString(num));
    }
}