using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Damin.Common.Diagnostics
{
    public class StackFrameExpansion
    {
        /// <summary>
        /// 현재 메소드의 이름을 가져온다.
        /// </summary>
        /// <returns></returns>
        public string GetMethodName()
        {
            StackTrace stackTrace = new StackTrace();
            StackFrame stackFrame = stackTrace.GetFrame(1);
            return stackFrame.GetMethod().Name;
        }
    }
}
