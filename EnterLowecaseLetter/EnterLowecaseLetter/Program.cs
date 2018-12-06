using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace EnterLowecaseLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter;
            string letterString;
            

            Write("  Enter a lowercase letter  ");
            letterString = ReadLine();
            letter = Convert.ToChar(letterString);
            if (letter >= 'a' && letter <= 'z')
                Write("   OK   ");
            else
                Write("   NEED LOWERCASE LETTER  ");

        }
    }
}
