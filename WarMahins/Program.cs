using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarMahins
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int r = Convert.ToInt32(Console.ReadLine());
            int a = r % 10;
            int b = r / 1000;
            int c = r / 10 % 10;
            int d = r / 100 % 10;
            if ((a == b) && (c == d))
            {
                Console.WriteLine("Da");
            }
            else
            {
                Console.WriteLine("Net");
            }
            Console.ReadKey();
              

          
            
        }
    }
}
