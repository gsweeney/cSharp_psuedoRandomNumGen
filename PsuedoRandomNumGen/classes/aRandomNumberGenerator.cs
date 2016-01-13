using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2
{
    public class aRandomNumberGenerator : Random
    {
        // track random numbers generated
        public List<int> numbers = new List<int>();
        public int[] mydata;

        // fields
        private readonly int high;
        private readonly int low;
        private string type;

        // properties
        public string Type { get { return type; } set { type = value; } }
        public int High { get{return high;}  }
        public int Low { get { return low; } }
        public int[] MyData{ get { return mydata; } set { mydata = value; } }

        /// <summary>
        /// create a new instance of aRandomNumberGenerator
        /// </summary>
        /// <param name="lowest"></param>
        /// <param name="highest"></param>
        /// <param name="seed"></param>
        public aRandomNumberGenerator(int lowest, int highest, int seed) : base(seed) { 
            high = highest-1;
            low = lowest;
            mydata = new int[37];
        }

        /// <summary>
        /// generate a random number within the limits specified by properties High and Low
        /// </summary>
        /// <returns></returns>
        public override int Next(){
            //  generate a random number between Low and High
            return Next(Low, High+1);
        }

        /// <summary>
        /// generate a random number between 0 and upper-bound
        /// </summary>
        /// <param name="max"></param>
        /// <returns></returns>
        public override int Next(int max){
            // generate a random number between 0 and max
            return Next(0, max + 1);
        }
    }
}
