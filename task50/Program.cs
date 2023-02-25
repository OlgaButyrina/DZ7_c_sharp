//Напишите программу, которая на вход принимает координаты элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] GenerateMatrix(int rows, int cols)
{
    Random rand = new Random();
    int[,] matrix = new int[rows, cols];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(0, 21);
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
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void FindNum(int[,] matr, int x, int y)
{
    int num;
    if (x <= matr.GetLength(0) && y <= matr.GetLength(1))
    {
        num = matr[x-1, y-1];
        System.Console.WriteLine($"По данным координатам находится число {num}");
    }
    else
    { System.Console.WriteLine("Введённые координаты вне матрицы"); }
}

int rows = new Random().Next(3, 6);
int cols = new Random().Next(3, 10);
int[,] myMatrix = GenerateMatrix(rows, cols);
PrintMatrix(myMatrix);
System.Console.WriteLine();
int i = ReadInt("Введите номер строки искомого элемента: ");
int j = ReadInt("Введите номер столбца искомого элемента: ");
System.Console.WriteLine();
FindNum(myMatrix, i, j);