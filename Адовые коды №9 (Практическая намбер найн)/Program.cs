using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//ИСП-23, Бирюков Георгий, 27.11.2021
//В массиве из 20 целых чисел найти наибольший элемент и поменять его местами с первым элементом

namespace Адовые_коды__9__практическая_намбер_найн_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mas = new int[20]; //Массив

            Random rnd = new Random();

            for (int i = 0; i < mas.Length; i++) //Иницилизация случайными числами от 0 до 20
                 mas[i] = rnd.Next(0, 20);

            Console.WriteLine(" Исход.массив ");
            for (int i = 0; i < mas.Length; i++)
                Console.Write(" " + mas[i]);
                Console.WriteLine();

            int maxlnd = 0; //Нахождение максимального числа
            for (int i = 1; i < mas.Length; i++)
                if (mas[i] > mas[maxlnd])
                    maxlnd = i;

            Console.WriteLine(" Самое большое значение " + mas[maxlnd]);

            //Перестановка значений
            int temp = mas[0];
            mas[0] = mas[maxlnd];
            mas[maxlnd] = temp;

            Console.WriteLine(" Отсорт.массив ");
            for (int i = 0; i < mas.Length; i++)
            Console.Write(" " + mas[i]);
            Console.ReadKey(); //Пауза
        }
    }
}
