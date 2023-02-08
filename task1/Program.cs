// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

int[] InputRowsCals(string str)
{
    int[] input = new int[2];
    string text;
    newTry:
    Console.Write(str);
    text = Console.ReadLine();
    string[] split = text.Split(' ');
    for (int i = 0; i <= 1; i++)
    {
        if (!(int.TryParse(split[i], out input[i])) || split.Length !=2 || (Convert.ToInt32(input[i]) <= 0))
        {   
            System.Console.WriteLine("Введены некорректные данные, повторите ввод");
            goto newTry;
        }                     
    }
    return input;
}

double[,] FillMatrix(int rows, int cols)
{
    Random rand = new Random();
    double[,] matrix = new double[rows,cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matrix[i,j] = Math.Round(rand.Next(-10, 11) + rand.NextDouble(), 1);;
        }        
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i,j] + "\t");
        }
        System.Console.WriteLine();        
    }
}

int[] rowsCols = InputRowsCals("Введи кол-во строк и столбцов через пробел: ");
double[,] matrix = FillMatrix(rowsCols[0],rowsCols[1]);
PrintMatrix(matrix);