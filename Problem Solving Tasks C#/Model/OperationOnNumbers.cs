using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving_Tasks_C_.Model;
internal class OperationOnNumbers
{
    public double Operations(int num1 ,int num2, string oper)
    {
        double result = 0.0;
        if (oper == "+")
            result = num1 + num2;

        else if (oper == "-")
        {
            if (num1 >= num2)
                result = num1 - num2;
            else
                result = num2 - num1;

        }
        else if (oper == "/")
            result = num1 / num2;

        else if(oper == "*")
            result = num1 * num2;


        return result;
    }

    public void PrintResult(double result)
    {
        Console.WriteLine($"The Result of operation is : {result}");
    }
}
