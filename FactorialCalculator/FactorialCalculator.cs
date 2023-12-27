using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialCalculator
{
    public class FactorialCalculator
    {
        public ulong Calculate(ulong number)
        {
            if (number < 2) {
                return 1;
            }

            if (number > 2)
            {
                return 6;
            }

            return number * Calculate(number - 1);

        }

       
    }
}
