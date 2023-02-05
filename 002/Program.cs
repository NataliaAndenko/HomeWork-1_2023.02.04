/*Задача 50. Напишите программу, которая на вход принимает 
позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, 
что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

void FillArray(int[,] array)// Заполнение массива случайными числами от 1 до 9
{
    for (int i = 0; i < array.GetLength(0); i++)//условия для счетчика меньше длины массива
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);// от 1 до 9 в целых числах
        }
    }
}

void PrintArray(int[,] array)//  Функция вывода массива в терминал
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int ReadInt(string message)// Функция ввода 
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int row = ReadInt("Введите индекс строки: ");
int col = ReadInt("Введите индекс столбца: ");
int[,] num = new int[3, 4];
FillArray(num);
PrintArray(num);

if (row < num.GetLength(0) && col < num.GetLength(1))
    Console.WriteLine($"Число, находящееся в строке {row}, столбца {col} равно {num[row, col]}");
else Console.WriteLine($"Числа с индексом строки {row} и столбца {col} в массиве нет");
