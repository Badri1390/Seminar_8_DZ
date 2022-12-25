// Задача 54: Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Clear();
int m = inputNumber("Введите m: ");
int n = inputNumber("Введите n: "); 
int[,] matrix = FillArray(m, n);
PrintArray2D(matrix);
System.Console.WriteLine();

int min = 0;
Sortirovka(min);
void Sortirovka(int min)
{
    int temp;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            if (matrix[i, j] < matrix[i, (j + 1)])
            {
                temp = matrix[i, j];
                matrix[i, j] = matrix[i, (j + 1)];
                matrix[i, (j + 1)] = temp;
            }

        }

    }
    if (min < matrix.GetLength(0))
    {
        Sortirovka(min+1);
    }
}


PrintArray2D(matrix);

int[,] FillArray(int m, int n)
{
    Random rand = new Random();
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(1, 20);
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


