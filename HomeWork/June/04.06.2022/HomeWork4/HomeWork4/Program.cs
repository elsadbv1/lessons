using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Homework 4:
             Araşdırdığınız dəyişən tipləri barədə bir yazı hazırlayacaqsız.Hər bir data type'ın nə kimi bir dəyər aldığını,
             neçə bit olduğunu və s.araşdırın.
             */

            /*
            1. byte - 8-bit unsigned integer; range - "0 to 255"
            2. sbyte - 8-bit signed integer; range - "-128 to 127"
            3. short - 16-bit signed integer; range - "-32,768 to 32,767"
            4. ushort - 16-bit unsigned integer; range - "0 to 65,535"\
            5. int - 32-bit signed integer; range - " -2,147,483,648 to 2,147,483,647"
            6. uint - 32-bit unsigned integer; range - "0 to 4,294,967,295"
            7. long - 64-bit signed integer; range - "-9,223,372,036,854,775,808 to 9,223,372,036,854,775,807"
            8. ulong - 64-bit unsigned integer; range - "0 to 18,446,744,073,709,551,615"
            9. float - 32-bit Single-precision floating point type; range - "-3.402823e38 to 3.402823e38"
            10. double - 64-bit double-precision floating point type; range - "-1.79769313486232e308 to 1.79769313486232e308"
            11. decimal - 128-bit decimal type for financial and monetary calculations; range - "(+ or -) 1.0 x 10e-28to 7.9 x 10e28"
            12. char - 16-bit single Unicode character; range - "Any valid character, e.g. a,*,"
            13. bool - 8-bit logical true/false value; range - "True or False"
            14. object - Base type of all other types.
            15. string - A sequence of Unicode characters
            16. DateTime - Represents date and time; range - "0:00:00am 1/1/01 to 11:59:59pm 12/31/9999"






            */
            double a = 5.1111111111111111119999999;
            double b = 5.2222222222222222229999999;
            double c = a + b;
            Console.WriteLine(c);
            Console.ReadLine();




        }
    }
}
