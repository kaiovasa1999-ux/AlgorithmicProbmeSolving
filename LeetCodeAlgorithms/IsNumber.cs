using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeAlgorithms
{
    internal class IsNumber
    {
        public bool IsNumberValidator(string s)
        {
            if (s == "Infinity" || s == "-Infinity" || s == "+Infinity") return false;
            double o;
            if (double.TryParse(s, out o))
            {
                return !Double.IsNaN(o);
            }
            return false;
        }
    }
}
