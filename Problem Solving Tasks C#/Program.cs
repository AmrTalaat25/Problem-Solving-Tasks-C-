using Problem_Solving_Tasks_C_.Class;
using Problem_Solving_Tasks_C_.Model;
using System;
internal class Program
{
    private static void Main(string[] args)
    {
        Smallest_Int_InArray smallestInArray = new Smallest_Int_InArray();
        int[] numbers = { 182, 0, 14, 15, 16, 17, -1, 25 };
        Console.WriteLine(smallestInArray.FindSmallestInt(numbers));




    }
}