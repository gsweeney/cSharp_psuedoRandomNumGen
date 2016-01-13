using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2
{
    class aCoin : aRandomNumberGenerator
    {
        public aCoin(int seed = 0) : base(0, 2, seed) {
            Type = "Coin";
        }
    }
}
