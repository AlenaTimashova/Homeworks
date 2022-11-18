//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] CreateDouble2DArray(int rows, int columns, int minValue, int maxValue)
{
    double[,] array = new double[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = Math.Round((new Random().NextDouble()), 2) + new Random().Next(minValue, maxValue);

    return array;
}

void ShowDouble2DArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
    Console.WriteLine();
}

//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

void FindArrayElement(double[,] array, int rowIndex, int colIndex)
{
    if (rowIndex < array.GetLength(0) && colIndex < array.GetLength(1))
        Console.WriteLine(array[rowIndex, colIndex]);
    else
        Console.WriteLine("There is no element with such index");
}

//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int [,] Create2DArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue);

    return array;
}

void Show2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
    Console.WriteLine();
}

double[] ArrayColumnAverage(int [,] array)
{
    double[] arrayAverage = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < array.GetLength(0); j++)
            sum += array[j, i];

        arrayAverage[i] = Math.Round(sum / array.GetLength(0), 2);
    }
        
        return arrayAverage;  
}

void ShowArray(double[] array){
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

Console.Write("Input the number of rows: ");
int numX = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the number of columns: ");
int numY = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the array min value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the array max value: ");
int max = Convert.ToInt32(Console.ReadLine());

// double[,] myArray = CreateDouble2DArray(numX, numY, min, max);
// ShowDouble2DArray(myArray);

// Console.Write("Please, input the row index of the element: ");
// int xPosition = Convert.ToInt32(Console.ReadLine());
// Console.Write("Please, input the column index of the element: ");
// int yPosition = Convert.ToInt32(Console.ReadLine());
// FindArrayElement(myArray, xPosition, yPosition);


int [,] myArray = Create2DArray(numX, numY, min, max);
Show2DArray(myArray);

double[] myAverageArray = ArrayColumnAverage(myArray);
ShowArray(myAverageArray);
