using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving_Tasks_C_.Model;
internal class OperationOnNumbers
{
    public double Operations(int num1, int num2, string oper)
    {
        double result;

        switch (oper)
        {
            case "+":
                result = num1 + num2;
                break;

            case "-":
                result = num1 - num2;
                break;

            case "*":
                result = num1 * num2;
                break;

            case "/":
                if (num1 == 0 || num2 == 0)
                {
                    Console.WriteLine("Can`t you Division by zero!");
                    return 0;
                }
                result = (double)num1 / num2;
                break;

            default:
                Console.WriteLine("Error: Invalid operator!");
                return 0;
        }

        return result;
    }


    public void PrintResult(double result)
    {
        Console.WriteLine($"The Result of operation is : {result}");
    }
}
