using System;
using Damin.Common.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Damin.Common.Calculation
{
    public class MathExpansion
    {
        /// <summary>
        /// number를 sortation 단위로 반올림
        ///
        /// </summary>
        /// <param name="minute">구분할 수</param>
        /// <param name="sortation">반올림 단위</param>
        /// <returns> ex) number = 7, sortation = 15 일때 return = 0 //
        /// ex) number = 8, sortation = 15 일때 return = 15</returns>
        public string RoundOff(int number, DivideByFive sortation) 
        {
            var todouble = (double)sortation;
            var toInt = (int)sortation;
            var round = ((int)Math.Round(number / todouble)) * toInt;
            return round.ToString();
        }
    }
}
