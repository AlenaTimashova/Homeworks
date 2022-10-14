//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.Write("Input first number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber == secondNumber)
    Console.WriteLine("Given numbers are equal");
else

if(firstNumber > secondNumber)
{
    Console.WriteLine($"Number {firstNumber} is bigger than number {secondNumber}");
}
else
    Console.WriteLine($"Number {secondNumber} is bigger than number {firstNumber}");
*/

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.Write("Input first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input third number: ");
int number3 = Convert.ToInt32(Console.ReadLine());
int max = number1;

if(number2 > max) 
{
    max = number2;
}
if(number3 > max)
{
    max = number3;
}

Console.WriteLine("Max number is " + max);*/

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
Console.Write("Input an integer number: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number % 2 == 0)
    Console.WriteLine($"{number} is even");
else
    Console.WriteLine($"{number} is odd");*/

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Input a positive integer number: ");
int number = Convert.ToInt32(Console.ReadLine());
int currentNumber = 1;

while(currentNumber <= number)
{
    if(currentNumber % 2 == 0)
   { Console.Write(currentNumber + " ");
   }
   currentNumber++;
}