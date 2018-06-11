using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideBy35Both
{
    class PrintDivide : IDivideRule
    {
        public void Divideby3()
        {
            Console.WriteLine("Buzz");    
        }

        public void Divideby35()
        {
            Console.WriteLine("Firtz");
        }

        public void Divideby5()
        {
            Console.WriteLine("Buzz&Firthz");
        }
    }
}
