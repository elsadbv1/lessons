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
            /*
            (Kecen dersin 3-cu taskidir.)
            1. İstifadəçidən ay'ı rəqəm olaraq alıb switch-case'dən istifadə edərək həmin ayın adını ekrana yazdırın. Məsələn 1 olsa yanvar, 5 olsa may.
            2. İstifadəçi ölkənin adını daxil edəndə paytaxtının adını ekrana yazdırın. 10 dənə ölkə olsa kifayətdir.



            Homework 1:
            Əvvəlcədən iki dəyişəndə username və password saxlayın. Bunlar heç bir zaman dəyişməyəcək şəkildə olsun. Yəni proqramda belə dəyişdirmək mümkün olmasın
            Sonra istifadəçidən username və password'u daxil etməsini istəyin. Əgər istifadəçi doğru məlumatları yazsa ekrana "Sisteme daxil olundu." mesajı çıxsın.
            Yox əgər səhv məlumat daxil etsə, yenidən username və password'u daxil etməsini istəyin. 3 dəfə səhv daxil etdikdən sonra "Hesab bloklandi" yazsın.



            IMPORTANT!!!!
            (Kecen dersin Homework 2'sini de yadima salin verim.)
            */

            const string userName = "username";
            const int password = 1234;

            int password1, password2, password3;
            string username1, username2, username3;

            //1st try
            Console.WriteLine("Username-i daxil edin");
            var userName1 = Console.ReadLine();

            Console.WriteLine("Password-u daxil edin");
            password1 = Convert.ToInt32(Console.ReadLine());


            
            if (password1 == password && userName1 == userName)
            {
                Console.WriteLine("Sisteme daxil olundu.");
            }
            else
            {
                Console.WriteLine("Username ve password-u yeniden daxil edin");
            }
            Console.ReadLine();

            //2nd try
            Console.WriteLine("Username");
            var userName2 = Console.ReadLine();

            Console.WriteLine("Password");
            password2 = Convert.ToInt32(Console.ReadLine());



            if (password2 == password && userName2 == userName)
            {
                Console.WriteLine("Sisteme daxil olundu.");
            }
            else
            {
                Console.WriteLine("Username ve password-u yeniden daxil edin");
            }
            Console.ReadLine();


            //3rd try
            Console.WriteLine("Username");
            var userName3 = Console.ReadLine();

            Console.WriteLine("Password");
            password3 = Convert.ToInt32(Console.ReadLine());



            if (password3 == password && userName3 == userName)
            {
                Console.WriteLine("Sisteme daxil olundu.");
            }
            else
            {
                Console.WriteLine("Hesab bloklandi");
            }
            Console.ReadLine();


        }
    }
}
