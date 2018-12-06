using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace HomeSales
{
    class Program
    {
        static void Main(string[] args)
        {

           
            string initalsString;
            char initals ='a';
            int total;
            string saleString = null;
            int saleD;
            int saleE;
            int saleF;
            while (initals != 'Z')
            {
                WriteLine("Enter the salespersons initials, also note that you can enter Z to exit");
                initalsString = ReadLine();
                initals = Convert.ToChar(initalsString);

                if (initals == 'd')
                {
                    Write("Now enter your sale ");
                    saleString = ReadLine();
                    saleD = Convert.ToInt32(saleString);
                }

                else if (initals == 'e')
                {
                    Write("Now enter your sale ");
                    saleString = ReadLine();
                    saleE = Convert.ToInt32(saleString);
                }
                else if (initals == 'f')
                {
                    Write("Now enter your sale ");
                    saleString = ReadLine();
                    saleF = Convert.ToInt32(saleString);
                }
                else if (initals == 'Z')
                {
                    Write("");
                }
                saleF = Convert.ToInt32(saleString);
                saleE = Convert.ToInt32(saleString);
                saleD = Convert.ToInt32(saleString);
                if (saleF > saleE & saleF > saleD)
                    WriteLine("sale F is the biggest");
                else if (saleE > saleF & saleE > saleD)
                {
                    WriteLine("sale E is the biggest");
                }

                else if (saleD > saleE & saleD > saleF) {
                    WriteLine("sale D is the biggest");
                }

                

                total = saleD + saleE + saleF;
                
                WriteLine("total is " + total);
                
               

            }
            
        }
    }
}
