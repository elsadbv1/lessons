using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Homework 4: İstifadəçidən qeyd etdiyim tiplərdə dəyər alıb onları uyğun tipdə dəyişənlərə çevirəcəksiz. bool, string, short, long int, char, datetime. 
            */
            Console.WriteLine("Is London capital of Italy?");
            string bool1 = Console.ReadLine();
            bool data1 = Convert.ToBoolean(bool1);

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            string name1 = name;

            Console.WriteLine("Height");
            string height = Console.ReadLine();
            short height1 = Convert.ToInt16(height);

            Console.WriteLine("Weight");
            string weight = Console.ReadLine();
            long weight1 = Convert.ToInt64(weight);

            Console.WriteLine("GPA");
            string gpa = Console.ReadLine();
            int gpa1 = Convert.ToInt32(gpa);

            Console.WriteLine("First letter of your surname");
            string firstLetter = Console.ReadLine();
            char firstLetter1 = Convert.ToChar(firstLetter);

            Console.WriteLine("Date of birth");
            string dateOfBirth = Console.ReadLine();
            DateTime dateOfBirth1 = Convert.ToDateTime(dateOfBirth);








        }
    }
}
