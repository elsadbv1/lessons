using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
           Homework 2:
           Istifadeciden hobbilerini sorusun ve bele bir text daxil edeceyini nezere alin:

           Menim hobbilerim uzmek ve musiqi dinlemekdir.  26/7

           Ekrani Clear edin.

           SubString method'u vasitesile, musiqi sozunu tapib ekrana cixarmaga calisin.
           */

            Console.WriteLine("Hobbileriniz nelerdir?");
            string hobby = Console.ReadLine();
            hobby = hobby.Substring(26, 7);
            Console.WriteLine(hobby);
            Console.ReadLine();

            Console.Clear();












        }
    }
}
