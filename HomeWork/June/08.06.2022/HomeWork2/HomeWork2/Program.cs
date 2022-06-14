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
            /*
             Homework 2:
             Bir dənə anket proqramı yığacaqsınız. İstifadəçidən onun haqqında məlumatları toplayacaqsınız. Bu məlumatlar ad, soyad, cins, doğum tarixi,
             yaşadığı ölkə, yaşadığı şəhər, boy, çəki, maaş olacaq. Siz bu məlumatları saxlamaq üçün doğru bir data type seçməlisiniz.

             İstifadəçinin daxil edəcəyi məlumatlar belə olacaq:
             Ad: Mark
             Soyad: Henry
             Cins: K və ya Q
             Doğum tarixi: 1990-10-10
             Yaşadığı ölkə: Azərbaycan
             Yaşadığı şəhər: Bakı
             Boy: 1.75
             Çəki: 26.50
             Maaş: 2500.00
             */

            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            string greeting = "Salam, xoş gəlmisizin! Zəhmət olmasa aşağıdakı bölmələri doldurun.";
            Console.WriteLine(greeting);

            Console.WriteLine("Ad:");
            string name = Console.ReadLine();

            Console.WriteLine("Soyad:");
            string surName = Console.ReadLine();

            Console.WriteLine("Cins:");
            Char sex = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Doğum tarixi:");
            DateTime dateOfBirth = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Yaşadığınız ölkə:");
            string currentCountry = Console.ReadLine();

            Console.WriteLine("Yaşadığınız şəhər:");
            string currentCity = Console.ReadLine();

            Console.WriteLine("Boy:");
            int height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Çəki:");
            int weight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Maaş:");
            int wage = Convert.ToInt32(Console.ReadLine());

            Console.ReadLine();
        }
    }
}
