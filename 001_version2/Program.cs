/*Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/
double[,] a = new double[3, 4];
Random random = new Random();
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        a[i, j] = random.NextDouble() * 100; // NextDouble() - случайное веществ. число от 0 до 1
        Console.Write("{0,6:F2}", a[i, j]);// {0,6:F2} вот эта конструкция - форматирование на веществ.числа
    }
    Console.WriteLine();
}
