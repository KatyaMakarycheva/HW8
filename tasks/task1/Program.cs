// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[rows, columns];
FillArray(array);
Console.WriteLine();
Console.WriteLine("Задан массив: ");
PrintArray(array);
int sum = SumOfRow(array, 0);
int min = 0;

void FillArray(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] figures)
{
    for (int i = 0; i < figures.GetLength(0); i++)
    {
        for (int j = 0; j < figures.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int SumOfRow(int[,] elements, int i)                                    
{
    int sumOfRow = elements[i, 0];
    for (int j = 1; j < elements.GetLength(1); j++)
    {
        sumOfRow = sumOfRow + elements[i, j];
    }
    return sumOfRow;
}

for (int i = 1; i < array.GetLength(0); i++)                           
{
    int pointRow = SumOfRow(array, i);
    if (sum > pointRow)
    {
        sum = pointRow;
        min = i;
    }
}

Console.WriteLine();
Console.WriteLine($"{min + 1} строка");