// Задача 56: Задайте прямоугольный двумерный массив.
//  Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке
//  и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();
int m = inputNumber("Введите m: ");
int n = inputNumber("Введите n: ");
const int LEFT_RANGE = 1;
const int RIGHT_RANGE = 10;
int[,] matrix = FillAndPrintArray(m, n, LEFT_RANGE, RIGHT_RANGE);

PrintArray2D(matrix);
System.Console.WriteLine();

int sumSecond = 0;
int sumFirst = 0;
int index = 0;
for (int i = 0; i < matrix.GetLength(1); i++)
{
    sumFirst += matrix[0, i];
}

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        sumSecond += matrix[i, j];
    }
    if (sumSecond < sumFirst)
    {
        sumFirst = sumSecond;
        index = i;
    }
    sumSecond = 0;

}
System.Console.WriteLine("Строка №: " + (index + 1));






int[,] FillAndPrintArray(int m, int n, int LEFT_RANGE, int RIGHT_RANGE)
{
    Random rand = new Random();
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(LEFT_RANGE, RIGHT_RANGE);
        }
    }
    return array;
}

void PrintArray2D(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write(arr[i, j] + " ");
        }
        System.Console.WriteLine();
    }

}

int inputNumber(string str)
{
    int number;
    string text;

    while (true)
    {
        System.Console.Write(str);
        text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            break;
        }
        System.Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
    }
    return number;
}

