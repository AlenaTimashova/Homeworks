// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int ExtractDigit(int number)
{
    int a = number / 10;
    int b = a % 10;
    return b;
}

Console.Write("Input a three-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Second digit of {num} is {ExtractDigit(num)}");*/

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int ThirdDigit(int number)

{
    if (number / 100 > 0)
       { while (number / 1000 > 0)
        {
            number = number / 10;
        }
        number = number % 10;
    }
    else
        number = -1;

    return number;    
}

Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());
int result = ThirdDigit(num);

if (result == -1)
    Console.WriteLine($"There is no 3d digit in {num}");
else
    Console.WriteLine($"Third digit of {num} is {result}");

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
bool WeekDay(int number)
{
    if (number == 6 || number == 7)
        return true;
    else
        return false;
}

Console.Write("Input day of the week in digit: ");
int weekDay = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(WeekDay(weekDay)); */