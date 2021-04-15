using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2
{
    class Program
    {
        static void Main(string[] args)
        {
            //4.22 (б)
            Console.WriteLine("Введите число f");
            int f = Convert.ToInt32(Console.ReadLine());
           if (f % 10 == 7)
            {
                Console.WriteLine("Является");
            }
            else
            {
                Console.WriteLine("Не является");
            }
            Console.ReadKey();



        }
    }
}
