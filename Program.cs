using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 1.Определить, имеются ли в одномерном массиве случайных чисел элементы, значения которых являются четными.


            //int[] nums = new int[5];
            //Random yyy = new Random();

            //for (byte i = 0; i < 5; i++)
            //{
            //    nums[i] = yyy.Next(1, 255);
            //}

            //Console.WriteLine("Четные");
            //for (byte i = 0; i < 5; i++)
            //{
            //    if (nums[i] % 2 == 0)
            //    {
            //        Console.WriteLine(nums[i]);
            //    }
            //}

            //Console.WriteLine("Не четные");
            //for (byte i = 0; i < 5; i++)
            //{
            //    if (nums[i] % 2 != 0)
            //    {
            //        Console.WriteLine(nums[i]);
            //    }
            //}

            //Задача 2.Найти сумму и количество отрицательных элементов одномерного массива с явной инициализацией: 1, -4, -7, 8, -10, 12, -14, -17, 20, 21.


            //int[] nums = new int[] { 1, -4, -7, 8, -10, 12, -14, -17, 20, 21 };
            //int sum = 0;
            //int count = 0;

            //foreach (int element in nums)
            //{
            //    if (element < 0)
            //    {
            //        sum += element;
            //        count++;
            //    }
            //}

            //Console.WriteLine($"Сумма отрицательных элементов: {sum}");
            //Console.WriteLine($"Количество отрицательных элементов: {count}");

            //Задача 3. Вывести элементы массива, заполненного с клавиатуры, на экран в обратном порядке.


            //int[] nums = new int[5];
            //int i = 0;
            //    for (i = 0; i < 5; i++)
            //    {
            //        Console.Write($"Введите {i} элемент - ");
            //        nums[i] = int.Parse(Console.ReadLine());
            //    }
            //     for (i = 4; i > -1; i--)
            //    {
            //    Console.WriteLine(nums[i]);
            //    }

            //Задача 4.В одномерном массиве, заполненном случайным образом, увеличить элементы в 2 раза.


            //int[] nums = new int[5];
            //Random yyy = new Random();
            //int c = 0;
            //    for (byte i = 0; i < 5; i++)
            //    {
            //        nums[i] = yyy.Next(1, 255);
            //    }
            //    foreach (byte i in nums)
            //{
            //    c++;
            //    Console.WriteLine($"{c} элемент - {i}\n{i}*2 = {i*2}");
            //}


            //Задача 5. Составьте программу формирования из массива A(N) двух массивов, в которых первый массив заполнен отрицательными, а второй – положительными элементами.

            //int[] all = new int[5];
            //int[] minus = new int[5];
            //int[] plus = new int[5];
            //Random yyy = new Random();

            //for (byte i = 0; i < 5; i++)
            //{
            //    all[i] = yyy.Next(-255, 255);
            //}

            //for (byte i = 0; i < 5; i++)
            //{
            //    if (all[i] < 0)
            //    {
            //        minus[i] = all[i];
            //    }
            //    else
            //    {
            //        plus[i] = all[i];
            //    }
            //}
            //Console.WriteLine("Положительные: ");
            //foreach (int i in plus)
            //{
            //    if (i != 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("Отрицательные: ");
            //foreach (int i in minus)
            //{
            //    if (i!=0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
          
            //Console.ReadKey();
        }
    }
}
