using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            //implicit conversion -  byte -- short -- int -- long -- float -- double

            byte byteVal = 254;
            short takeByteVal = byteVal;

            short shortVal = 3799;
            int takeShortVal = shortVal;

            int intVal = 111111111;
            long takeIntVal = intVal;

            long longVal = 22222222222222;
            float takeLongVal = longVal;

            float floatVal = 2225.5f;
            double takeFloatVal = floatVal;


            //Explicit conversion

            short s = 186;
            byte b = (byte)s;

            int i = 25000;
            short s1 = (short)i;

            long l = 1234567;
            int i1 = (int)l;

            float f = 12345.5f;
            long l1 = (long)f;

            double d = 12345678;
            float f1 = (float)d;

            //Helper class conversion






        }
    }
}
