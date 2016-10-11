using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LibraryOldTask1;

namespace ConsoleApplicationOldTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число 'А' из которого будем извлекать корень");
            string A =Console.ReadLine();
            Console.WriteLine("Введите число 'n' степень кореня");
            string n = Console.ReadLine();
            
            //Console.WriteLine(Method.Niuton(n,ValueA));
            //Console.WriteLine( Method.BinPow(2, 3));
            Console.WriteLine("Число А = "+ Method.ValueA);

            Console.WriteLine("Программа отработала");
            Console.Read();
        }    
    }

}
