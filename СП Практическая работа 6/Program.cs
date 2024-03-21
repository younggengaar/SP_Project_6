using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СП_Практическая_работа_6
{
    internal class Program
    {
        //ЗАДАЧА 1

//static void Main(string[] args)
//{
//    for (int num = 1000; num <= 9999; num++)
//    {
//        if (num % 2 == 0 && num % 7 == 0 && num % 11 == 0 && Sum(num) == 30)
//        {
//            Console.WriteLine($"Найден номер автомобиля: {num}");
//            break;
//        }
//    }
//    Console.ReadKey();
//}
//static int Sum(int number)
//{
//    int sum = 0;
//    while (number > 0)
//    {
//        sum += number % 10; //получ последнюю цифру и доб к сумме
//        number /= 10; //удал последнюю цифру 
//    }
//    return sum;
//}



//ЗАДАЧА 2

//static void Main(string[] args)
//{
//    int[,] array = new int[6, 6];

//    for (int i = 0; i < 6; i++)
//    {
//        int numb = i + 1;
//        for (int j = 0; j < 6; j++)
//        {
//            array[i, j] = numb;
//            numb++;
//            if (numb > 6)
//            {
//                numb = 1;
//            }
//        }
//    }
//    for (int i = 0; i < 6; i++)
//    {
//        for (int j = 0; j < 6; j++)
//        {
//            Console.Write(array[i, j]);
//        }
//        Console.WriteLine();
//    }
//    Console.ReadKey();
//}



//ЗАДАЧА 3

//static void Main(string[] args)
//{
//    Console.Write("Введите размер квадратной матрицы:");
//    int n = int.Parse(Console.ReadLine());
//    int[,] matrix = new int[n, n];
//    int number = 1;
//    for (int i = 0; i < n; i++)
//    {
//        if (i % 2 == 0)
//        {
//            for (int j = 0; j < n; j++)
//            {
//                matrix[i, j] = number++;
//            }
//        }
//        else
//        {
//            for (int j = n - 1; j >= 0; j--)
//            {
//                matrix[i, j] = number++;
//            }
//        }
//    }
//    Console.WriteLine("Результат:");
//    Matrix(matrix);
//    Console.ReadKey();
//}
//static void Matrix(int[,] matrix)
//{
//    int n = matrix.GetLength(0);
//    for (int i = 0; i < n; i++)
//    {
//        for (int j = 0; j < n; j++)
//        {
//            Console.Write(matrix[i, j] + "\t");
//        }
//        Console.WriteLine();
//    }
//}
    }
}
