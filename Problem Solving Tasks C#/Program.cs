using Problem_Solving_Tasks_C_.Class;
using Problem_Solving_Tasks_C_.Model;
using System;
internal class Program
{
    private static void Main(string[] args)
    {
        SwapTwoNumbers swapTwoNumbers = new SwapTwoNumbers();
        CountNumber countNumber = new CountNumber();
        int[] numbers = { 1, 5 , 6 , 4 , 7, 8 ,10 ,11 ,44};
        int x = 3;
        int y = 5;
        swapTwoNumbers.Swap( x,  y);
        countNumber.count(numbers);



    }
}