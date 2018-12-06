using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace TestScores
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            int score = 0;
            const int MAX = 100;
            const int MIN = 0;
            string scoreString;
            int count = 0;
           
            while ( score != 999)
            {
                WriteLine("Enter your test score, please also note that you can enter"+
                    " 999 to see score avg");
                scoreString = ReadLine();
                score = Convert.ToInt32(scoreString);

                if (score < MAX && score > MIN)
                {
                    WriteLine("valid  ");
                    total = score + total;
                    count++;
                
                }
                else if (score == 999) {
                    WriteLine(">>>> avg is " + (total) / count + " and your "+
                        "number of test scores is " + count);
                }
                else
                    WriteLine("  ERROR ENTER VALID TEST SCORE");
            }
           
        }
    }
}
