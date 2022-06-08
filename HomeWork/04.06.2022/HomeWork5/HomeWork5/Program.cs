using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Homework 5:
             Global ve local deyisenlerin ferqlerini kodla ve comment olaraq izah edin. */

            int a = 1;
            
            // a digərlərinə görə qlobal olduğu üçün heç birini a-da istifadə edə bilmirik, amma hamısında a-nı istifadə edə bilirik
            {
                int b = 2;
                a = 1;
                // yalnız a-nı istifadə edə bilirik
                {
                    int c = 3;
                    a = 1;
                    b = 2;
                    // a və b-ni istifadə edə bilirik
                    {
                        int d = 4;
                        a = 1;
                        b = 2;
                        c = 3;
                        //a, b, c-ni istifadə edə bilirik
                        {
                            int e = 5;
                            a = 1;
                            b = 2;
                            c = 3;
                            d = 4;
                            //a, b, c, d-ni istifadə edə bilirik
                        }


                    }



                }


            }







        }
    }
}
