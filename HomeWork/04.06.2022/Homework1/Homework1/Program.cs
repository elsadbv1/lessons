using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Homework 1:
            Ev tapşırığı olaraq ilk növbədə ən az 2 - 3 saat internetdə "C# data types"(C# veri tipleri) mövzusunu geniş 
             bir şəkildə araşdırırsınız.Araşdıra - araşdıra da bir Console App açıb araşdırdığınız data tiplərindən nümunələr
 
              yazırsınız.Hər data type üçün ən az 5 fərqli nümunə yazın.
              */

            /*Data types
             1. Value data type 
                1.1 Simple types
                1.2 Enum types
                1.3 Struct types
                1.4 Nullable types

              ( 1.1 Predefined data types (Integer, Boolean, Float)
               1.2 User defined data types (Enumerations, Stucture)
               Char, signed char, unsigned char, short(s-u), int(s-u), long(s-u), float, double, decimal)

              2. Pointer data type (&, *)

              3. Referance data type
     
                3.1 Class types 
                3.2 Interface types
                3.3 Array types
                3.4 Delegate types

                  (3.1 Predefined data types (Objects, Strings)
               3.2 User defined data types (Classes, Interface))

              */

            //Value types

            // 1. Int
            int a = 16;
            int b = 32;
            int c = a + b;
            int a1 = 9;
            int b1 = 39;
            int c1 = b - a;

            // 2. Bool
            bool d = a<b;
            bool e = c1 > c;

            // 3. Byte
            byte f = 1;

            // 4. Char
            char g = 'a';

            // 5. Decimal
            decimal d1 = 175.3m;

            // 6. Double
            double e1 = 111111111111111111d;

            /* 7. Enum  - yazmağa çalışdım amma alınmadı (using System;
            namespace EnumerationExample) bu hissəni başa düşmədim
            Enum DaysOfTheWeek
                
            {
                Monday,


            }
            */

            // 8. Float
            float f1 = 12742.5f;

            // 9. Short
            short g1 = 3111;

            // 10. Long 
            long g2 = 777777777777;

           
















        }
    }
}
