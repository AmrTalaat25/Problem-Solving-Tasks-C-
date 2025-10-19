using Problem_Solving_Tasks_C_.Class;
using Problem_Solving_Tasks_C_.Model;
using System;
internal class Program
{
    private static void Main(string[] args)
    {
        StringIsUpper stringIsUpper = new StringIsUpper();
        RemoveCharFromString RemoveCharFromString = new RemoveCharFromString();
        AvarageInArray averageArray = new AvarageInArray();
        string text = "hello I AM AMR"; 
        string Ntext = "HELLO I AM AMR"; 
        double[] doubles = {1, 2, 3, 4, 5}; 

        Console.WriteLine(stringIsUpper.IsUpperCase(text));
        Console.WriteLine(stringIsUpper.IsUpperCase(Ntext));
        Console.WriteLine(RemoveCharFromString.Remove_char(text));
        Console.WriteLine($"The Average Of Array : {averageArray.FindAverage(doubles)}");






    }
}