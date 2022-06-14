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
            /* Homework 1: İstifadəçidən 2 dənə ayrı dəyər alın(rəqəm). Məsələn birincidə istifadəçi 20 daxil etdi onu a dəyişənində saxlayın. İkincidə 50 daxil etdi onu da
               b dəyişənində saxlayın. Elə edin ki, bu iki dəyişənin dəyərlərinin yerlərini dəyişdirin. Yəni a 20, b 50-dirsə elə edin ki, a olsun 50, b olsun 20.
            */

            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Console.WriteLine("1-ci rəqəmi daxil edin");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("2-ci rəqəmi daxil edin");
            int b = int.Parse(Console.ReadLine());

            a = Convert.ToInt32(b);
            b = Convert.ToInt32(a);

        }
    }
}
