/*
void ShowArray(int[]array){

    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

        Console.WriteLine();
}
*/
void ShowArray(double[]array){

    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

        Console.WriteLine();
}


//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int[] CreateThreeDigitsArray(int size){

    int[] array = new int[size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(100, 1000);
    
    return array;
}

int EvenCountArray(int[] array){

    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0)
            count++;

    return count;
}

Console.Write("Input size of the array: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateThreeDigitsArray(number);
ShowArray(myArray);

Console.WriteLine("Number of even digits in your array is " + EvenCountArray(myArray)); */

//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях (index).
/*
int[] CreateArray(int size, int min, int max){

    int[] array = new int[size];

    for (int i = 0; i < size; i++)    
        array[i] = new Random().Next(min, max);
    
    return array;
    
}

int SumOddIndexArray(int[] array){

    int sum = 0;

    for (int i = 1; i < array.Length;)
    {
        sum+= array[i];
        i+=2;
    }    
        
    return sum;

}

Console.Write("Input size of the array: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min value of the array: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max value of the array: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateArray(number, minValue,maxValue);
ShowArray(myArray);

Console.WriteLine("Sum for numbers with odd index is: " + SumOddIndexArray(myArray)); */

//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

double[] CreateArray(int size, int min, int max){

    double[] array = new double[size];

    for (int i = 0; i < size; i++)    
        array[i] = Math.Round((new Random().NextDouble()), 2) + new Random().Next(min, max);
    
    return array;
    
}

double MinMaxDifference (double[] array){
   
    double min = array[0];
    double max = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if(array[i] < min)
            min = array[i];
        
        if (array[i] > max)
            max = array[i];
    }

     double dif = max - min;
     return dif;
}

Console.Write("Input size of the array: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min value of the array: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max value of the array: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

double[] myArray = CreateArray(number, minValue, maxValue);
ShowArray(myArray);

Console.WriteLine("The difference between max and min value of the array is: " + MinMaxDifference(myArray));