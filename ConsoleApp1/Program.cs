using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
namespace Calcul
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите А");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите Б");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Выберите действие над числами + (1), -(2), /(3), *(4)");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ответ: " + Calcul(a, b, c));
            Console.WriteLine("Максимальное число: " + Max(a, b));
            Console.WriteLine("Минимальное число: " + Min(a, b));
            Console.WriteLine("Введите число для нахождения его факториала n ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Факториал числа  {n} равен: {Factorial(n)} ");
            Console.WriteLine("Введите первое число для нахождения среднего");
            int z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число для нахождения среднего");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите третье число для нахождения среднего");
            int v = Convert.ToInt32(Console.ReadLine());
            Console.ReadKey();
        }
        public static string Calcul(int a, int b, int c)
        {
            if (c == 1)
            {
                a = a + b;
            }
            if (c == 2)
            {
                a = a - b;
            }
            if (c == 3)
            {
                a = a / b;
            }
            if (c == 4)
            {
                a = a * b;
            }
            return a.ToString();
        }
        public static int Max(int a, int b)
        {
            if (a < b)
            {
                return b;
            }
            else
            {
                return a;
            }
        }
        public static int Min(int a, int b)
        {
            if (a > b)
            {
                return b;
            }
            else
            {
                return a;
            }
        }
        public static int Factorial(int n)
        {
            int factorial = 1;
            int i = 1;
            while (i <= n)
            {
                factorial = factorial * i;
                i++;
            }

            return factorial;
        }
    }
}
