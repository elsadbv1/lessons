using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             (Kecen dersin 3-cu taskidir.)
            1. İstifadəçidən ay'ı rəqəm olaraq alıb switch-case'dən istifadə edərək həmin ayın adını ekrana yazdırın. Məsələn 1 olsa yanvar, 5 olsa may.
            2. İstifadəçi ölkənin adını daxil edəndə paytaxtının adını ekrana yazdırın. 10 dənə ölkə olsa kifayətdir.

            */
            //1
            
            int month = Convert.ToInt32(Console.ReadLine());

            switch (month)
            {
                case 1:
                    Console.WriteLine("January");
                    break;
                case 2:
                    Console.WriteLine("February");
                    break;
                case 3:
                    Console.WriteLine("March");
                    break;
                case 4:
                    Console.WriteLine("April");
                    break;
                case 5:
                    Console.WriteLine("May");
                    break;
                case 6:
                    Console.WriteLine("June");
                    break;
                case 7:
                    Console.WriteLine("July");
                    break;
                case 8:
                    Console.WriteLine("August");
                    break;
                case 9:
                    Console.WriteLine("September");
                    break;
                case 10:
                    Console.WriteLine("October");
                    break;
                case 11:
                    Console.WriteLine("November");
                    break;
                case 12:
                    Console.WriteLine("December");
                    break;
                default:
                    Console.WriteLine("Hec birine uygun gelmedi");
                    break;
                    
            }

            Console.ReadLine();
            Console.Clear();
            //2
            string country = Console.ReadLine();
            switch (country)
            {
                case "USA":
                    Console.WriteLine("Washington, D.C");
                    break;
                case "Italy":
                    Console.WriteLine("Rome");
                    break;
                case "England":
                    Console.WriteLine("London");
                    break;
                case "Switzerland":
                    Console.WriteLine("Bern");
                    break;
                case "Japan":
                    Console.WriteLine("Tokyo");
                    break;
                case "China":
                    Console.WriteLine("Beijing");
                    break;
                case "Australia":
                    Console.WriteLine("Canberra");
                    break;
                case "Canada":
                    Console.WriteLine("Ottawa");
                    break;
                case "Azerbaijan":
                    Console.WriteLine("Baku");
                    break;
                case "Turkey":
                    Console.WriteLine("Ankara");
                    break;
                default:
                    Console.WriteLine("Hec birine uygun deyil");
                    break;

            }
            Console.ReadLine();

            

        }
    }
}
