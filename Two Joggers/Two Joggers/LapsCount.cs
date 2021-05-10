using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Two_Joggers
{
    public class LapsCount
    {
        public int Gcd(int x, int y )
        {
            if (x == 0)
                return y;
            return Gcd(y % x, x);
        }
        public int Lcm(int x , int y)
        {
            return (x / Gcd(x, y)) * y;
        }
    }
}
