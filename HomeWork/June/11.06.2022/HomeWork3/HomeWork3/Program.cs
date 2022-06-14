using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Homework 3: İstifadəçidən 10 dənə fərqli rəqəm alıb bir dəyişəndə toplayın. Bu taskı da çıxma, vurma və bölmə üçün də edin. Çıxmada və toplama əməliyyatlarında 10-cu dəyər daxil
                         edildikdən sonra alınan nəticəyə 1 toplayacaq və ya çıxacaqsız. Vurmada bölmədə isə, alınan nəticəni 20'ə vurun və ya bölün.
               */

            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            string a1 = "rəqəm";

            Console.WriteLine("10 fərqli rəqəm daxil edin");
            
            Console.WriteLine("1-ci " + a1 + ":");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("2-ci " + a1 + ":");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("3-cü " + a1 + ":");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("4-cü " + a1 + ":");
            int d = int.Parse(Console.ReadLine());

            Console.WriteLine("5-ci " + a1 + ":");
            int e = int.Parse(Console.ReadLine());

            Console.WriteLine("6-cı " + a1 + ":");
            int f = int.Parse(Console.ReadLine());

            Console.WriteLine("7-ci " + a1 + ":");
            int g = int.Parse(Console.ReadLine());

            Console.WriteLine("8-ci " + a1 + ":");
            int h = int.Parse(Console.ReadLine());

            Console.WriteLine("9-cu " + a1 + ":");
            int k = int.Parse(Console.ReadLine());

            Console.WriteLine("10-cu " + a1 + ":");
            int l = int.Parse(Console.ReadLine());



            Console.WriteLine(a + b + c + d + f + g + h + k + l +1);
            Console.WriteLine(a - b - c - d - f - g - h - k - l - 1);
            Console.WriteLine(a * b * c * d * f * g * h * k * 20);
            Console.WriteLine(a / b / c / d / f / g / h / k / 20);
            Console.ReadLine();
















        }
    }
}
