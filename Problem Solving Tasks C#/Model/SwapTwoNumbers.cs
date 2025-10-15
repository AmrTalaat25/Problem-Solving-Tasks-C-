using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving_Tasks_C_.Model;
internal class SwapTwoNumbers
{
    public void Swap(  int x,  int y)
    {
        x = x + y;
        y = x - y;
        x = x - y;


        Console.WriteLine($" x = {x} && y ={y}");
    }
}
