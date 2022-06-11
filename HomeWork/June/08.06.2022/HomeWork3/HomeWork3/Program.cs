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
            /*Homework 3:
             İstifadəçidən yaşını, maaşını, boyunu, çəkisini və neçə dostu olduğunu soruşacaqsınız.Daxil etdiyi bütün dəyərləri ilk öncə int tipinə convert
             edəcəksiniz.Daha sonra int dəyişənini byte tipinə cast edəcəksiniz(explicit conversion).
             Burada istifadəçi maaşı və yaşı xaricində digər məlumatları byte'ın max dəyərindən çox yazsa heç bir xəta çıxmasın. Maaşını və ya yaşını byte
             tipinin qəbul edəcəyi maksimum dəyərdən çox yazarsa elə edin ki, proqramda xəta çıxsın.
             */

            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Console.WriteLine("Neçə yaşınız var?");
            string age = Console.ReadLine();

            Console.WriteLine("Nə qədər maaş alırsınız?");
            string wage = Console.ReadLine();

            Console.WriteLine("Boyunuz nə qədərdir?");
            string height = Console.ReadLine();

            Console.WriteLine("Çəkiniz nə qədərdir?");
            string weight = Console.ReadLine();

            Console.WriteLine("Neçə dostunuz var?");
            string friend = Console.ReadLine();

            int age1 = int.Parse(age);
            int wage1 = int.Parse(wage);
            int height1 = int.Parse(height);
            int weight1 = int.Parse(weight);
            int friend1 = int.Parse(friend);


            byte height2 = (byte)height1;
            byte weight2 = (byte)weight1;
            byte friend2 = (byte)friend1;

            checked
            {
                byte age2 = (byte)age1;
                byte wage2 = (byte)wage1;

            }

            Console.ReadLine();

        }
    }
}
