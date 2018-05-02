using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideBy35Both
{
    class Program
    {
        static void Main(string[] args)
        {
            Logic c = new Logic(new PrintDivide());

            for (int i=0;i<100;i++)
            {
                if(i%3 == 0)
                {
                    c.PrintDivideRule3();
                }
                else if(i%5 ==0)
                {
                    c.PrintDivideRule5();
                }
                else if(i%3==0 && i%5 ==0)
                {
                    c.PrintDivideRule35();
                }
                else
                {
                    Console.WriteLine(i);
                }
            }  

            Console.ReadLine();
        }
    }
}
