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
             int, bool, char, string və long tipində dəyişənlər yaradıb onlara dəyər verirsiniz.Sonra elə bir dəyişən yaratmalısınız
            ki, bütün bu dəyişənləri ona dəyər olaraq mənimsədə biləsiniz.
            */

            string student = "Elshad";
            bool startsWith_E = student.StartsWith("E");
            char rank = '3';
            int avgScore = 90;
            long lastResult = 96;

            object a = student;
            object b = startsWith_E;
            object c = rank;
            object d = avgScore;
            object e = lastResult;



        }
    }
}
