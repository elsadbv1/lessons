using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Homework 2: İstifadəçidən 3 ayrı sətirdə 3 ayrı rəqəm alın. İstifadəçi 3-cü rəqəmi daxil etdikdən sonra ekrana belə bir yazı yazdırın Nəticə: 5 + 5 + 10 = 20. Bunu
            çıxma, vurma və bölmə üçün də edin.
            */

            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Console.WriteLine("Rəqəm 1");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Rəqəm 2");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Rəqəm 3");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine(a + b + c);
            Console.WriteLine(a * b * c);
            Console.WriteLine(a / b / c);
          
            Console.ReadLine();


        }
    }
}
