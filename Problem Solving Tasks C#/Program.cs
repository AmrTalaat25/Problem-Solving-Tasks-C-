using Problem_Solving_Tasks_C_.Class;
using Problem_Solving_Tasks_C_.Model;
using System;
internal class Program
{
    private static void Main(string[] args)
    {
        OperationOnNumbers operationOnNumbers = new OperationOnNumbers();
        Console.Write("pleass Enter Number One : ");
        int x= int .Parse(Console.ReadLine());
        Console.Write("pleass Enter Number Tow : ");
        int y = int.Parse(Console.ReadLine());
        Console.Write("pleass Enter operator  : ");
        string oper = Console.ReadLine();
        var result = operationOnNumbers.Operations(x, y, oper);
        operationOnNumbers.PrintResult(result);

    }
}