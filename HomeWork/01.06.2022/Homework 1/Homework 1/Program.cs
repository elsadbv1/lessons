using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             Homework 1:

             Asagidaki data tiplerini arasdirin ve bir numune yazmaga calisin:
             bool
             byte
             char
             decimal
             double
             float
             int
             long
             sbyte
             short
             */



            //bool

            bool count = 10 > 9;
            Console.WriteLine(count);
            Console.ReadLine();

            bool count1 = 9 > 10;
            Console.WriteLine(count1);
            Console.ReadLine();

            Console.Clear();

            //byte ramda 1 byte yer tutur
            byte first = 1;
            byte second = 5;
            byte max = byte.MaxValue;
            byte min = byte.MinValue;


            Console.WriteLine(first);
            Console.WriteLine(second);
            Console.WriteLine(max);
            Console.WriteLine(min);
            Console.ReadLine();

            Console.Clear();


            // xarakterləri tutmaq üçün char-dan istifadə olunur
            // tək dırnaq içərisində tək xarakter
            // char ramda 1 byte yer tutur
            char character = 'E';
            char character2 = '?';
            Console.WriteLine(character);
            Console.WriteLine(character2);
            Console.ReadLine();

            Console.Clear();

            // decimal dəyişəni (-7.9 x 1028 to 7.9 x 1028) / (100 to 28) (28 pillə)  arasında dəyər saxlaya bilir.

            decimal first_ = 91.5m;
            decimal second_ = -150;
            decimal max1 = decimal.MaxValue;
            decimal min1 = decimal.MinValue;
            Console.WriteLine(first_);
            Console.WriteLine(second_);
            Console.WriteLine(max1);
            Console.WriteLine(min1);
            Console.ReadLine();

            Console.Clear();

            // double ramda 8 byte yer tutur
            // double 15 pillədə rəqəm tuta bilir

            double first_Double = 125.3;
            double max_Double = double.MaxValue;
            double min_Double = double.MinValue;
            Console.WriteLine(first_Double);
            Console.WriteLine(max_Double);
            Console.WriteLine(min_Double);
            Console.ReadLine();

            Console.Clear();

            // float ramda 4 byte yer tutur və kəsrləri tutmaq üçün istifadə olunur

            float number = 25.48f;
            float float_max = float.MaxValue;
            float float_min = float.MinValue;
            Console.WriteLine(number);
            Console.WriteLine(float_max);
            Console.WriteLine(float_min);
            Console.ReadLine();

            Console.Clear();


            //int ramda 4 byte yer tutur, tam ededler ucun istifade olunur  (64 bitde 8 bayt yer tutur int)

            int variable = 99;
            int int_max = int.MaxValue;
            int int_min = int.MinValue;
            Console.WriteLine(variable);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);
            Console.ReadLine();

            Console.Clear();

            //long ramda 8 byte yer tutur, tam ededler ucun istifade olunur

            long variable1 = 175346444;
            long long_max = long.MaxValue;
            long long_min = long.MinValue;
            Console.WriteLine(variable1);
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(long.MinValue);
            Console.ReadLine();

            Console.Clear();

            //sbyte ramda 2 byte yer tutur, -128 + 127 arasinda deyisir
            sbyte variable2 = -49;
            sbyte max_sbyte = sbyte.MaxValue;
            sbyte min_sbyte = sbyte.MinValue;

            Console.WriteLine(variable2);
            Console.WriteLine(max_sbyte);
            Console.WriteLine(min_sbyte);
            Console.ReadLine();

            Console.Clear();

            // short ramda 2 byte yer tutur

            short variable3 = 30375;
            short short_max = short.MaxValue;
            short short_min = short.MinValue;
            Console.WriteLine(variable3);
            Console.WriteLine(short_max);
            Console.WriteLine(short_min);
            Console.ReadLine();

            Console.Clear();


            








        }
    }
}
