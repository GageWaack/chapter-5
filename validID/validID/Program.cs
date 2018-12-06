﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace validID
{
    class Program
    {
        static void Main(string[] args)
        {
            int idNum;
            string input;
            const int LOW = 1000;
            const int HIGH = 9999;

            Write("enter an Id number   ");
                input = ReadLine();
            idNum = Convert.ToInt32(input);

            while (idNum < LOW || idNum > HIGH)  {
                WriteLine(+idNum + "  is an invalid ID number      ");
                Write("  ID number must be between   "+LOW + "and   "+ HIGH + "  inclusive    ");
                Write("  enter ID number   ");
                input = ReadLine();
                idNum = Convert.ToInt32(input);
            }
            WriteLine("ID number " + idNum +  " is valid   ");
        }
    }
}
