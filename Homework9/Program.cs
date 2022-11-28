// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
/*
void NumRow(int number)
{
    Console.Write(number + " ");
    if (number > 1) NumRow(number - 1); 
}

Console.Write("Please, input a number: ");
int num = Convert.ToInt32(Console.ReadLine());
NumRow(num);
*/
// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
int SumofNumbers(int m, int n)
{
    if(m > n)
    {
    return n+= SumofNumbers(m, n + 1);
    }

    if(m < n)
    {
    return m+= SumofNumbers(m + 1, n);
    }
    else return m;
}
*/
Console.Write("Please, input the first number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Please, input the second number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(SumofNumbers(firstNumber, secondNumber));


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int Ackerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return Ackerman(m - 1, 1);
    else
    return Ackerman(m - 1, Ackerman(m, n - 1));
}

Console.WriteLine(Ackerman(firstNumber, secondNumber));