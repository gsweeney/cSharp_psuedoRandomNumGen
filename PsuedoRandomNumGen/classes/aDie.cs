using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2
{
    class aDie : aRandomNumberGenerator
    {
        public aDie(int seed = 0) : base(1, 7, seed) {
            Type = "Die";
        }   
    }
}
