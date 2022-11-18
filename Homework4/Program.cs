//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
int Power (int number, int degree){
    
    int result = 1;
    for (int i = 0; i < degree; i++)
    {
        result *= number;
    }
    return result;
}

Console.Write("Input a number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a degree for the number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{num1} powered by {num2} is {Power(num1, num2)}");*/

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int Sum (int number){

    int result = 0;

  while (number > 0)
  {
    int digit = number%10;
    result += digit;
    number = number/10;
    
  }
  return result;
}

Console.Write("Input a number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Sum of the digits of {num1} is {Sum(num1)}");*/

//Задача 29: Напишите программу, которая ненерирует массив из m элементов, заданный пользователем и выводит их на экран.

int[] GetArray (int size){

    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
    Console.Write($"Input element {(i+1)} for your array: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void ShowArray(int[]array){

    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

        Console.WriteLine();
}


Console.Write("Input a size for array: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] myArray = GetArray(number);
ShowArray(myArray); 

