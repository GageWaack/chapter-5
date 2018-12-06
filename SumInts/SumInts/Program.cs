using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace SumInts
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int sum = 0;
            int exit=0;
            string inputString;
            while (exit != 999)
            { 
                WriteLine("Enter numbers that you wish to add, please "+
                "also note that you can enter 999 to exit    ");
                inputString = ReadLine();
                num = Convert.ToInt32(inputString);
                exit = Convert.ToInt32(inputString);
                sum = num  + sum;
                
            }
            Write ("the sum is " + (sum - 999));
        }
    }
}
