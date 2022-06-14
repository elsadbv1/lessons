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
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nə qədər maaş alırsınız?");
            int wage = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Boyunuz nə qədərdir?");
            int height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Çəkiniz nə qədərdir?");
            int weight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Neçə dostunuz var?");
            int friend = Convert.ToInt32(Console.ReadLine());

          

            byte height1 = (byte)height;
            byte weight1 = (byte)weight;
            byte friend1 = (byte)friend;

            checked
            {
                byte age1 = (byte)age;
                byte wage1 = (byte)wage;

            }

            Console.ReadLine();

        }
    }
}
