using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagnusMicroMath
{
    public class MagnusMicroMath //Magnus' Math Class
    {
        /// <summary>
        /// Method for adding two integers together
        /// </summary>
        /// <param name="t1">First integer</param>
        /// <param name="t2">Second integer</param>
        /// <returns>An integer sum of the two parameter integers</returns>
        public int Add(int t1, int t2)
        {
            return t1 + t2;
        }

        public int Add3Numbers(int t1, int t2, int t3)
        {
            return t1 + t2 + t3;
        }
    }
}
