// Задача 50. Напишите программу, которая на вход принимает число, возвращает индексы этого элемента в 
// двумерном массиве или же указание, что такого числа нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int InputElement(string str)
{
    int number;
    string text;
    while (true)
    {
        Console.Write(str);
        text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            break;
        }

        System.Console.WriteLine("Введено некорректное число, повторите ввод");
    }
    return number;
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

string FindElement(int[,] matrix, int element)
{
    string indexes="";
    for (int i=0; i < matrix.GetLength(0); i++)
    {
        for (int j=0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i,j] == element) 
            {
                indexes = indexes + "[" + i + "," + j +"] ";
            }
        }
    }
    return indexes;
}

int element = InputElement("Введи элемент матрицы: ");
int[,] matrix = FillMatrix(3,4);
PrintMatrix(matrix);
string indexes = FindElement(matrix, element);
if (indexes == "") {System.Console.WriteLine($"Числа ({element}) нет в матрице");}
else {System.Console.WriteLine($"Индексы элемента ({element}) в матрице: {indexes}");}
