using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideBy35Both
{
    class Logic
    {
        private IDivideRule _dividerule;

        public Logic(IDivideRule dividerule)
        {
            this._dividerule = dividerule;
        }

        public void PrintDivideRule3()
        {
            _dividerule.Divideby3();
        }
        public void PrintDivideRule5()
        {
            _dividerule.Divideby5();
        }
        public void PrintDivideRule35()
        {
            _dividerule.Divideby35();
        }
    }
}
