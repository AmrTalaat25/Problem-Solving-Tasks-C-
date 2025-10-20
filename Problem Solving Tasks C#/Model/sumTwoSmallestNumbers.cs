using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving_Tasks_C_.Model;
internal class SumTwoSmallestNumbers
{
    public int sumSmallestNumbers(int[] numbers)
    {
        numbers.OrderBy(n => n);
        return numbers[0] + numbers[1];



    }

}
