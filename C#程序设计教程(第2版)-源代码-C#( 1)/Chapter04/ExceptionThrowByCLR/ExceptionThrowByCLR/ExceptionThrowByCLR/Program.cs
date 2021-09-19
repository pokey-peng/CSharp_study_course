using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionThrowByCLR
{
    public class ExceptionThrowByCLR
    {
        public static void Main()
        {
            int i1 = 1, i2 = 0, i3;
            i3 = i1 / i2;            //CLR自动抛出异常System.DivideByZeroException
        }
    }

}
