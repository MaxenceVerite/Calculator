using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
 
    
    public class CalculatorEngine
    {


        /// <summary>
        /// Function to addition two values
        /// </summary>
        /// <param name="valueA"> first value </param>
        /// <param name="valueB"> 2nd value </param>
        /// <returns>the sum of the two values</returns>
        public virtual int Add(int valueA, int valueB)
        {
            return valueA + valueB;
        }

        /// <summary>
        /// Function to addition two values
        /// </summary>
        /// <param name="valueA"> first value </param>
        /// <param name="valueB"> 2nd value </param>
        /// <returns>the sum of the two values</returns>
        public virtual int Sub(int valueA, int valueB)
        {
            return valueA - valueB;
        }

        /// <summary>
        /// Function to multiply the two value
        /// </summary>
        /// <param name="valueA"> first value </param>
        /// <param name="valueB"> 2nd value </param>
        /// <returns>the product of the two values</returns>
        public virtual int Mul(int valueA, int valueB)
        {
            return valueA * valueB;
        }

        /// <summary>
        /// Function to divise the first value by the second one
        /// </summary>
        /// <param name="valueA"> first value </param>
        /// <param name="valueB"> 2nd value </param>
        /// <returns>the div of the two values</returns>
        public virtual int Div(int valueA, int valueB)
        {
            int res;

            if(valueB != 0)
            {
                res = valueA / valueB;
            }
            else
            {
                res = Int32.MinValue;
            }

            return res;
        }
    }
}
