using Problem_Solving_Tasks_C_.Class;
using Problem_Solving_Tasks_C_.Model;
using System;
internal class Program
{
    private static void Main(string[] args)
    {
        NumberBetweenTowIntegers numberBetweenTowIntegers = new NumberBetweenTowIntegers(); 
;
        int[] result = numberBetweenTowIntegers.FindBetweenTowNumber(3, 8);

        numberBetweenTowIntegers.PrintArray(result);

    }
}