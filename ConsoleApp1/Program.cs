using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace практика6
{
    internal class Program
    {
        static void Main(string[] args)
        {;
            Console.WriteLine("1 task");

            Console.Write("Введите a: "); int a = int.Parse(Console.ReadLine());
            Console.Write("Введите b: "); int b = int.Parse(Console.ReadLine());
            Calcul(a, b);

            Console.WriteLine("2 task");
            Console.Write("Введите a: "); int p = int.Parse(Console.ReadLine());
            Console.Write("Введите b: "); int o = int.Parse(Console.ReadLine());
            Min(p, o);
            Max(p, o);

            Console.WriteLine("3 task");

            Console.Write("Введите строку либо число для проверки: "); string str = Console.ReadLine();
            IsPalindrome(str);

            Console.WriteLine("4 task");

            Console.Write("Введите n: "); int n = int.Parse(Console.ReadLine());
            Factorial(n);

            Console.WriteLine("5 task");

            Console.Write("Введите a: "); int m = int.Parse(Console.ReadLine());
            Console.Write("Введите b: "); int v = int.Parse(Console.ReadLine());
            Console.Write("Введите c: "); int d = int.Parse(Console.ReadLine());
            Average(m, v, d);

            Console.WriteLine("6 task");

            Console.Write("Введите слово или текст: "); string text = Console.ReadLine();
            Console.Write("Введите символ для поиска: "); string symb = Console.ReadLine();
            FindChar(text, symb);

            Console.WriteLine("7 task");

            Console.Write("Введите длину пароля: "); int length = int.Parse(Console.ReadLine());
            GeneratePassword(length);

            Console.WriteLine("8 task");

            Console.Write("Введите градус в Цельсиях: "); double c = double.Parse(Console.ReadLine());
            Console.Write("Введите градус в Фаренгейтах: "); double f = double.Parse(Console.ReadLine());
            CelsiusToFahrenheit(c);
            FahrenheitToCelsius(f);

            Console.WriteLine("9 task");

            Console.Write("Введите предложение для перестановки: "); string sentence = Console.ReadLine();
            ReverseWords(sentence);

            Console.WriteLine("10 task");

            Console.Write("Введите число: "); int w = int.Parse(Console.ReadLine());
            MultiplicationTable(w);

            Console.ReadKey();
        }
        public static void Calcul(int a, int b)
        {
            int chas = a / b;
            Console.WriteLine($"Частное чисел {a} и {b} = {chas}");
            int proiz = a * b;
            Console.WriteLine($"Произведение чисел {a} и {b} = {proiz}");
            int raz = a - b;
            Console.WriteLine($"Разность чисел {a} и {b} = {raz}");
            int sum = a + b;
            Console.WriteLine($"Сумма чисел {a} и {b} = {sum}");

        }
        public static void Min(int p, int o)
        {
            if (p < o)
            {
                Console.WriteLine($"Наименьшее число - {p}");
            }
            else
            {
                Console.WriteLine($"Наименшьее число - {o}");
            }
        }
        public static void Max(int p, int o)
        {
            if (p > o)
            {
                Console.WriteLine($"Наибольшее число - {p}");
            }
            else
            {
                Console.WriteLine($"Наибольшее число - {o}");
            }
        }
        public static void IsPalindrome(string str)
        {
            var revstr = new string(str.Reverse().ToArray());
            if (revstr == str)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
        public static void Factorial(int n)
        {
            var factorial = 1;
            for (int i = 1; i <= n; i++)
                factorial *= i;
            Console.WriteLine($"Факториал числа {n} = {factorial}");
        }
        public static void Average(int m, int v, int d)
        {
            int aver = (m + v + d) / 3;
            Console.WriteLine($"Среднее арифмитическое чисел {m}, {v}, {d} = {aver}");
        }
        public static void FindChar(string text, string symb)
        {
            int index = text.IndexOf(symb);

            if (index != -1)
            {
                Console.WriteLine(index);
            }
            else
            {
                Console.WriteLine($"-1");
            }
        }
        public static void GeneratePassword(int length)
        {
            string password = "";
            Random random = new Random();

            for (int i = 0; i < length; i++)
            {
                int gap = random.Next(0, 9);
                password += gap.ToString();
            }
            Console.WriteLine($"Ваш пароль: {password}");

        }
        public static void CelsiusToFahrenheit(double c)
        {
            int F = Convert.ToInt32(c) * (9 / 5) + 32;
            Console.WriteLine($"{c} градусов Цельсия в Фаренгейтах будет - {F}");
        }
        public static void FahrenheitToCelsius(double f)
        {
            int C = (Convert.ToInt32(f) - 32) * (5 / 9);
            Console.WriteLine($"{f} градусов Цельсия в Фаренгейтах будет - {C}");
        }
        public static void ReverseWords(string sentence)
        {
            string[] words = sentence.Split(' ');
            Array.Reverse(words);
            Console.Write("Перестановленное предложение: ");
            Console.WriteLine(string.Join(" ", words));
        }
        public static void MultiplicationTable(int w)
        {
            Console.WriteLine($"Таблица умножения на {w}");
            for (int i = 1; i <= 10; i++)
            {

                Console.WriteLine($"{w} x {i} = {w * i}");
            }
        }
    }
}