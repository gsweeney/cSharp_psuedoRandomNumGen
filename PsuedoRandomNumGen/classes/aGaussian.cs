using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2
{
    class aGaussian : aRandomNumberGenerator
    {
        public aGaussian(int seed = 0) : base(6, 37, seed) {
            Type = "Gaussian";
        }

        /// <summary>
        /// return the sum of 6 dice rolls
        /// </summary>
        /// <returns></returns>
        public override int Next()
        {
            int sum = 0;
            // generate 6 random numbers between Low and High
            for (int i = 0; i < 6; i++ )
            {
                sum += Next(1, 7);
            }
            // sum those numbers 
            // and take the average
            //return Next(Low, High + 1);
            return sum;
        }

    }
}
