using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryOldTask1
{
    /*NET.C#.02 Основные программные конструкции C#
     * Задание 1.
     * Разработать тип, позволяющий вычислять корень n-ой степени из числа методом Ньютона с заданной точностью. 
     * Предусмотрев в нем возможность сравнения полученного результата со значением, рассчитываемым с помощью метода Math.Pow библиотеки классов .NET Framework.	
     * В качестве UI-интерфейса использовать консольное приложение с интерфейсом командной строки, WinForms или WPF-приложение.

     * Задание 2.
     * Разработать тип, позволяющий конвертировать неотрицательное десятичное значение целого числа в строку, содержащую двоичное представление этого значения.
     * В качестве UI-интерфейса использовать консольное приложение с интерфейсом командной строки, WinForms или WPF-приложение.
    */
    public class Method
    {
        const double eps = 0.001;
        static int n = 2;
        public static int ValueA = 4;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        static int BinPow(int A, int n)
        {
            if (n == 0)
                return 1;
            if (n % 2 == 1)
                return BinPow(A, n - 1) * A;
            else
            {
                int b = BinPow(A, n / 2);
                return b * b;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="n"></param>
        /// <param name="A"></param>
        /// <returns></returns>
        static double Niuton(int n, int A)//TODO 
        {
            double xk = 3;
            double result = 0;
            while (Math.Abs(result - xk) > eps) // пересмотреть метод останова
            {
                result = xk;
                xk = (((n - 1) * xk + A / Math.Pow(xk, n - 1)) / n);
            }
            return result;
        }

        /*
       * найдено для квадратного корня в сети 
      public static double SqRtN(int N)
      {
          double x = 1;
          double eps = 1e-15;
          for (;;)
          {
              double nx = (x + N / x)/2;
              if (Math.Abs(x - nx) < eps) break;
              x = nx;
          }
          return (x);
      }
       */
    }
}
