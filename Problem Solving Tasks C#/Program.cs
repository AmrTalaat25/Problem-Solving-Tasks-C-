using Problem_Solving_Tasks_C_.Class;
using Problem_Solving_Tasks_C_.Model;
using System;
internal class Program
{
    private static void Main(string[] args)
    {
        ReverseString reverseString = new ReverseString();
        DoubleChar doubleChar = new DoubleChar();

        string str = "amr talaat ";
        Console.WriteLine(reverseString.ReverseOne(str));
        Console.WriteLine(reverseString.ReverseTow(str));
        Console.WriteLine(doubleChar.DoubleString(str));




    }
}