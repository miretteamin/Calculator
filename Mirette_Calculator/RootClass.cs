using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mirette_Calculator
{
    class RootClass
    {
        public static double NthRoot(double x, double y)
        {
            return Math.Pow(x, 1 / y);
        }

        public static double NthRoot(float x, float y)
        {
            return Math.Pow(x, 1 / y);
        }
    }
}
