//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
int[,] Create2DArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int cols = 0; cols < columns; cols++)
            array[i, cols] = new Random().Next(minValue, maxValue + 1);

    return array;
}
*/
void Show2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int cols = 0; cols < array.GetLength(1); cols++)
            Console.Write(array[i, cols] + " ");

        Console.WriteLine();
    }
    Console.WriteLine();
}
/*
void ArrangeArrayLineByDecrease(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int k = 0; k < array.GetLength(0) - 2; k++)
            for (int cols = 0; cols < array.GetLength(0) - 1; cols++)
                if (array[i, cols] < array[i, cols + 1])
                {
                    int temp = array[i, cols];
                    array[i, cols] = array[i, cols + 1];
                    array[i, cols + 1] = temp;
                }
}

*/
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов. 
/*
int[] ArrayRowSum(int[,] array)
{

    int[] sum = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
        for (int cols = 0; cols < array.GetLength(1); cols++)
            sum[i] += array[i, cols];

    return sum;
}

int MinElementSumRow(int[,] array, string msg = "Generated array:\n")
{
    int[] rowSum = ArrayRowSum(array);
    int row = 0;
    for (int i = 1; i < rowSum.Length; i++)
    {
        if (rowSum[i] < rowSum[row])
            row = i;
    }
    return row + 1;

}

Console.Write("Input the number of rows: ");
int numX = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the number of columns: ");
int numY = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the array min value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the array max value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = Create2DArray(numX, numY, min, max);
Show2DArray(myArray);

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

ShowArray(ArrayRowSum(myArray));
Console.WriteLine();
Console.WriteLine("The row with min sum is: " + MinElementSumRow(myArray));
*/
// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/*
int[,] MatrixPower(int[,] firstArray, int[,] secondArray)
{
    int[,] matrix = new int[secondArray.GetLength(0), firstArray.GetLength(1)];
    if (firstArray.GetLength(1) == secondArray.GetLength(0))
    {
        for (int k = 0; k < firstArray.GetLength(0); k++)
            for (int i = 0; i < secondArray.GetLength(0); i++)
                for (int cols = 0; cols < secondArray.GetLength(1); cols++)
                    matrix[k, i] += firstArray[k, cols] * secondArray[cols, i];
    }
    return matrix;
}

Console.WriteLine("First array data:");
Console.Write("Input a number of rows: ");
int firstArrayX = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int firstArrayY = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the array min value: ");
int firstMin = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the array max value: ");
int firstMax = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Second array data:");
Console.Write("Input a number of rows: ");
int secondArrayX = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int secondArrayY = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the array min value: ");
int secondMin = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the array max value: ");
int secondMax = Convert.ToInt32(Console.ReadLine());

int[,] firstMatrix = Create2DArray(firstArrayX, firstArrayY, firstMin, firstMax);
Show2DArray(firstMatrix);
int[,] secondMatrix = Create2DArray(secondArrayX, secondArrayY, secondMin, secondMax);
Show2DArray(secondMatrix);

int[,] result = MatrixPower(firstMatrix, secondMatrix);
Show2DArray(result);

*/

//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
/*
bool CompareArrayElements(int[,,] array, int element)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int cols = 0; cols < array.GetLength(1); cols++)
            for (int k = 0; k < array.GetLength(2); k++)
                if (array[i, cols, k] == element) return true;

    return false;
}

int[,,] Create3DArray(int rows, int columns, int depth)
{
    int[,,] array = new int[rows, columns, depth];

    for (int i = 0; i < rows; i++)
        for (int cols = 0; cols < columns; cols++)
        {
            int k = 0;
            while (k < array.GetLength(2))
                {
                    int value = new Random().Next(10, 100);
                    if (CompareArrayElements(array, value)) continue;
                    array[i, cols, k] = value;
                    k++;
                }
        }

    return array;
}

void Show3DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int cols = 0; cols < array.GetLength(1); cols++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
                Console.Write(array[i, cols, k] + $"({i}, {cols}, {k}) ");

            Console.WriteLine();
        }

    }
    Console.WriteLine();
}

int[,,] myArray = Create3DArray(2, 2, 2);
Show3DArray(myArray);
*/

// Напишите программу, которая заполнит спирально массив.

int[,] CreateSpiralMatrix(int rows, int cols)
{
    int[,] array = new int[rows, cols];
    
    int iBegin = 0, iEnd = 0, jBegin = 0, jEnd = 0;
    int i = 0;
    int j = 0;
    
    for (int k = 0; k < array.Length; k++)
    {
        array[i, j] = k + 1;
        if (i == iBegin && j < array.GetLength(1) - jEnd - 1)
            j++;
         else if (j == array.GetLength(1) - jEnd - 1 && i < array.GetLength(0) - jEnd - 1)
            i++;
        else if (i == array.GetLength(0) - jEnd - 1 && j > jBegin)
            j--;
        else
            i--;

       if ((i == iBegin + 1) && (j == jEnd) && (jEnd != array.GetLength(1) - jEnd - 1))
       {
            iBegin++;
            iEnd++;
            jBegin++;
            jEnd++;
        }
    }
    
    return array;
}

Console.Write("Input the number of rows: ");
int numX = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the number of columns: ");
int numY = Convert.ToInt32(Console.ReadLine());
int[,] myArray = CreateSpiralMatrix(numX, numY);
Show2DArray(myArray);