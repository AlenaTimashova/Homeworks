//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
int Compare(int arr1, int arr2)
{
    if (arr1 == arr2)
        return -1;
    else

if (arr1 > arr2)
        return arr1;

    else
        return arr2;
}

Console.Write("Input first number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (Compare(firstNumber, secondNumber) == -1)
    Console.WriteLine("The numbers are equal");
else
    Console.WriteLine($"{Compare(firstNumber, secondNumber)} is bigger");*/


//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
int Max(int arr1, int arr2, int arr3)
{

int max = arr1;

if(arr2 > max) 
{
    max = arr2;
}
if (arr3 > max)
{
    max = arr3;
}
return max;

}
Console.Write("Input first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input third number: ");
int number3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Max number is " + Max(number1, number2, number3));*/

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
bool EvenNum(int num)
{
    if (num % 2 == 0)
        return true;
    else
        return false;
}

Console.Write("Input an integer number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (EvenNum(number) == true)
    Console.WriteLine($"{number} is even");
else
    Console.WriteLine($"{number} is odd");*/

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Input a positive integer number: ");
int number = Convert.ToInt32(Console.ReadLine());
int currentNumber = 2;

while(currentNumber <= number)
{
    if(currentNumber % 2 == 0)
   { Console.Write(currentNumber + " ");
   }
   currentNumber = currentNumber+2;
}