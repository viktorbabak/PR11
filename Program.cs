using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;

// Вариант № 1
// 1.Задано целое положительное четырехзначное число N (N > 0).
// Найти сумму между произведениями первых двух и последних двух его цифр.
// 2. Проверить истинность высказывания: 
// "Квадратное уравнение A·x2 + B·x + C = 0 " +
// "с данными коэффициентами A (A ≠ 0), B, C имеет ровно два вещественных корней".
// 3.Арифметические действия над числами пронумерованы следующим образом:
// 1 - сложение, 2 - вычитание, 3 - умножение, 4 - деление.
// Дан номер действия N (целое число в диапазоне от 1 до 4) и вещественные числа A и B (B не равно 0).
// Выполнить над числами указанное действие и вывести результат.
namespace PR11
{
    class Program
    {
        static void Main(string[] args)
        {
        //_____________Task-1_____________
        Label: int N = 0;
            Console.WriteLine("\tЗадание №1");
            Console.WriteLine("Введите 4-х значное число(N > 0):");

            try
            {
                N = Convert.ToInt32(Console.ReadLine());
            }
            catch (System.FormatException exception)
            {
                Console.WriteLine("MESSAGE - " + exception.Message.ToString()); //сообщение об ошибке
            }

            if (N <= 0)
            {
                Console.WriteLine("Ошибка, число отрицательно!");
                goto Label;
            }

            if (N >= 1000 && N <= 9999)
            {
                Console.WriteLine("Вычисления:\n");
            }

            else
            {
                Console.WriteLine("Ошибка, число больше/меньше 4-х знаков!\n");
                goto Label;
            }
            int Ch1 = N / 1000;
            int Ch2 = (N % 1000) / 100;
            int Ch3 = (N % 100) / 10;
            int Ch4 = N % 10;
            int vRes = (Ch1 * Ch2) + (Ch3 * Ch4);
            Console.WriteLine("Ответ: {0}\n", vRes);

            //_____________Task-3_____________
            Console.WriteLine("\tЗадание №3");
            Console.WriteLine("\tДействия:\n1. Сложение\n");
            Console.WriteLine("2. Вычитание\n");
            Console.WriteLine("3. Умножение\n");
            Console.WriteLine("4. Деление\n");
            Console.WriteLine("Введите два вещественных числа:");

        Label3: double A = 0.0;
            double B = 0.0;
            
            try
            {
                Console.WriteLine("Число A:");
                A = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Число B:");
                B = Convert.ToDouble(Console.ReadLine());
            }
            
            catch (System.FormatException exception)
            {
                Console.WriteLine("MESSAGE - " + exception.Message.ToString()); //сообщение об ошибке
                goto Label3;
            }
            
            if (B <= 0)
            {
                Console.WriteLine("Ошибка, число B отрицательно!");
                goto Label3;
            }
            
            Label3_1:Console.WriteLine("Введите номер действия(1-4):");
            int vN = 0;
            
            try
            {
                vN = Convert.ToInt32(Console.ReadLine());
            }

            catch(System.FormatException exception)
            {
                Console.WriteLine("MESSAGE - " + exception.Message.ToString()); //сообщение об ошибке
            }
            
            if (vN < 1 || vN > 4)
            {
                Console.WriteLine("Ошибка, число не входит в диапазон действий!\n");
                goto Label3_1;
            }
            else 
            {
                Console.WriteLine("Вычисления:");
                goto Label3_2;
            }
            Label3_2: switch (vN)
            {
                case (1):
                    {
                        double vAdd = A + B;
                        Console.WriteLine("\tСумма = {0}\n", vAdd);
                        break;
                    }
                case (2):
                    {
                        double vSub = A - B;
                        Console.WriteLine("\tРазность = {0}\n", vSub);
                        break;
                    }
                case (3):
                    {
                        double vMul = A * B;
                        Console.WriteLine("\tРезультат умножения = {0}", vMul);
                        break;
                    }
                case (4):
                    {
                        double vDiv = A / B;
                        Console.WriteLine("\tРезудьтат деления = {0}", vDiv);
                        break;
                    }
            }
        }
    }
}
