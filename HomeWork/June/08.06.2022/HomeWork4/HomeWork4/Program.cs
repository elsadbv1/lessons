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

            /*Homework 4:
             Aşağıdakı dəyərləri düzgün tiplərdə dəyişənlər yaradıb saxlayın:
            1: "Hava gozeldir."
             2: '%'
             3: 9999999999999999
             4: true
             5: false
             6: '0'
             7: 0
             8: 150
             9: -111111111115615
             10: 15.2M
             11: 15.2
             12: 15.2F
             13: new DateTime(2020, 12, 12)
             */

            string weather = "Hava gozeldir.";
            char c = '%';
            long l = 9999999999999999;
            bool b = 9 > 8;
            bool b1 = 8 > 9;
            char c1 = '0';
            int i1 = 0;
            byte b2 = 150;
            Int64 i = -111111111115615;
            decimal d = 15.2M;
            double d1 = 15.2;
            float f = 15.2F;
            DateTime date = new DateTime(2020, 12, 12);

        }
    }
}
