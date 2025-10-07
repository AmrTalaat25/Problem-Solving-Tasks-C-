using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving_Tasks_C_.Model;
internal class NumberBetweenTowIntegers
{
    public int [] FindBetweenTowNumber(int Num1, int Num2)
    {   
        var list = new List<int> ();
        if (Num1 < Num2)
        {
            int current = Num1 ;  
            while (current <= Num2)
            {
                list.Add(current);
                current++;
            }
        }
        else 
        {
            int current = Num2;   
            while (current <= Num1)
            {
                list.Add(current);
                current++;
            }
        }
        int[] Numbers = list.ToArray();

        return Numbers;
    }

    public void PrintArray(int[] numbers)
    {
        foreach (var number in numbers)
        {
            Console.Write( number +" ");
        }


    }
}
