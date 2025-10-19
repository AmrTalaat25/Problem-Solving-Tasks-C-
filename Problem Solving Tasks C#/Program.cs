using Problem_Solving_Tasks_C_.Class;
using Problem_Solving_Tasks_C_.Model;
using System;
internal class Program
{
    private static void Main(string[] args)
    {
        StringIsUpper stringIsUpper = new StringIsUpper();
        string text = "hello I AM AMR"; 
        string Ntext = "HELLO I AM AMR"; 

        Console.WriteLine(stringIsUpper.IsUpperCase(text));
        Console.WriteLine(stringIsUpper.IsUpperCase(Ntext));






    }
}