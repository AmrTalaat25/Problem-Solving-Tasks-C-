using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving_Tasks_C_.Model;
internal class CountNumber
{
    public void count(int[] Numbers)
    {
        int countEven = 0;
        int countOdd = 0;
        foreach (int number in Numbers) 
            {
                if (number%2 == 0)
                    countEven++; 
                else
                    countOdd ++;

            }
        Console.WriteLine($"Count Even Number Is : {countEven}");
        Console.WriteLine($"Count Odd Number Is : {countOdd}");
    }
}
