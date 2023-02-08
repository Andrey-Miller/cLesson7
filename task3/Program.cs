// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

int[,] FillMatrix(int rows, int cols)
{
    Random rand = new Random();
    int[,] matrix = new int[rows,cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matrix[i,j] = rand.Next(0, 11);
        }        
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
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

double[] ColsAvg(int[,] matrix)
{
    double[] avgs = new double[matrix.GetLength(1)];
    for (int j=0; j<matrix.GetLength(1);j++)
    {
        for (int i=0; i<matrix.GetLength(0);i++)
        {
            avgs[j] = avgs[j] + matrix[i,j]; 
        }
        avgs[j]=avgs[j]/matrix.GetLength(0);
    }
    return avgs;
}
int[] rowsCols = InputRowsCals("Введи кол-во строк и столбцов через пробел: ");
int[,] matrix = FillMatrix(rowsCols[0],rowsCols[1]);
PrintMatrix(matrix);
double[] avgs = ColsAvg(matrix);
for (int i=0; i<avgs.Length;i++)
{
    System.Console.WriteLine($"Среднее арифмитическое {i+1} стобца: {Math.Round(avgs[i], 2)}");
}