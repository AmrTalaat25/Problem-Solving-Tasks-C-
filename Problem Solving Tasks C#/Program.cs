using Problem_Solving_Tasks_C_.Class;
using Problem_Solving_Tasks_C_.Model;
using System;
internal class Program
{
    private static void Main(string[] args)
    {
        ConvertNumToString converter = new ConvertNumToString();
        ConvertToNegative  negative = new ConvertToNegative();

        int num = 5;
        Console.WriteLine(negative.MakeNegative(num));
    }
}