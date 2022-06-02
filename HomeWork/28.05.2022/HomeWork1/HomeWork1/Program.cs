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
           
            Console.WriteLine("Adinizi daxil edin");
            var name = Console.ReadLine();
            
            
            Console.WriteLine("Soyadinizi daxil edin");
            var surname = Console.ReadLine();

            Console.WriteLine("Hazirda yasadiginiz seheri qeyd edin");
            var currentCity = Console.ReadLine();


            

            Console.Clear();

            Console.WriteLine("Ad: " + name);
            Console.WriteLine("Soyad: " + surname);
            Console.WriteLine("Seher: " + currentCity);

            Console.ReadLine();

        }
    }
}
