using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TamGiac
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.Write("\n");
            Console.Write("Bai tap xet Tam Giac \n");
            Console.Write("------------------------------------------");
            Console.Write("\n");

            Console.Write("Nhap a: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nNhap b: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nNhap c: ");
            c = Convert.ToInt32(Console.ReadLine());

            if (a == b && b == c)
            {
                Console.Write("Day la tam giac deu\n");
            }
            else if (a == b || a == c || b == c)
            {
                if((a*a + b*b == c*c)||(b*b + c*c == a*a)||(a*a + c*c == b*b))
                    Console.Write("Day la tam giac vuong can\n");
                else
                    Console.Write("Day la tam giac can\n");
            }
            else if ((a * a + b * b == c * c) || (b * b + c * c == a * a) || (a * a + c * c == b * b))
            {
                Console.Write("Day la tam giac vuong \n");
            }
            else
            {
                Console.Write("Day la tam giac thuong\n");
            }

            Console.ReadKey();
        }
    }
}
